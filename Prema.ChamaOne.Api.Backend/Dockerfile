# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Switch to root temporarily to install packages
USER root
# Install tzdata to support time zones
RUN apt-get update && apt-get install -y tzdata \
    && ln -fs /usr/share/zoneinfo/Africa/Nairobi /etc/localtime \
    && dpkg-reconfigure -f noninteractive tzdata \
    && apt-get clean \
    && rm -rf /var/lib/apt/lists/*
# Switch back to app user
USER app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Prema.ChamaOne.Api.Backend.csproj", "."]
RUN dotnet restore "./Prema.ChamaOne.Api.Backend.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./Prema.ChamaOne.Api.Backend.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Prema.ChamaOne.Api.Backend.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Create directory with correct permissions
USER root
RUN mkdir -p ./Database/LocationData && chown -R app:app ./Database
USER app

# Copy the CSV file to the image
COPY --chown=app:app ["Database/LocationData/kenya-location-data.csv", "./Database/LocationData/"]

# Set environment variable for timezone
ENV TZ=Africa/Nairobi
ENTRYPOINT ["dotnet", "Prema.ChamaOne.Api.Backend.dll"]