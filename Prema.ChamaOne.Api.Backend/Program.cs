using Microsoft.EntityFrameworkCore;
using Prema.ChamaOne.Api.Backend.Database;
using Prema.ChamaOne.Api.Backend.Controllers;
using Prema.ChamaOne.Api.Backend.AutoMapper;
using Prema.ChamaOne.Api.Backend.Services;
using Prema.ChamaOne.Api.Backend.AppSettings;
using Prema.ChamaOne.Api.Backend.BulkSms;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using Prema.ChamaOne.Api.Backend.Telegram;
using Prema.ChamaOne.Api.Backend.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder
            .WithOrigins("http://localhost:4200") // Update this with your Angular app's URL
            .AllowAnyHeader()
            .AllowAnyMethod());
});

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(MappingProfile));

string connectionString = builder.Configuration.GetConnectionString("MySqlConnectionString");
var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));

builder.Services.AddDbContext<ChamaOneDatabaseContext>(
    dbContextOptions => dbContextOptions
        .UseMySql(connectionString, serverVersion)
        // The following three options help with debugging, but should
        // be changed or removed for production.
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors()
);

builder.Services.AddHttpClient();
builder.Services.AddSingleton<MobileSasa>();
builder.Services.Configure<MobileSasaSettings>(builder.Configuration.GetSection("MobileSasa"));
builder.Services.Configure<TelegramBotSettings>(builder.Configuration.GetSection("TelegramBot"));
builder.Services.AddSingleton<TelegramBot>();
builder.Services.AddSingleton<Logger>();

builder.Services.AddHostedService<ContributionUpdaterService>();
builder.Services.AddHostedService<ContributionReminderService>();

var app = builder.Build();

// Apply migrations on startup
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ChamaOneDatabaseContext>();
    dbContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowSpecificOrigin");

app.UseAuthorization();

app.MapControllers();

app.MapGenderEndpoints();

app.MapMemberEndpoints();

app.MapContributionEndpoints();

app.MapLoanEndpoints();

app.MapSMSRecordEndpoints();

app.Run();
