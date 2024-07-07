# Base stage
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["YourProject.csproj", "./"]
RUN dotnet restore "./YourProject.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "YourProject.csproj" -c Release -o /app/build

# Publish stage
FROM build AS publish
RUN dotnet publish "YourProject.csproj" -c Release -o /app/publish

# Final stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN mkdir -p ./Database/LocationData
COPY ["Database/LocationData/kenya-location-data.csv", "./Database/LocationData/"]

ENTRYPOINT ["dotnet", "YourProject.dll"]
