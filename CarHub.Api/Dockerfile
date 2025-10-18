# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["CarHub.Api/CarHub.Api.csproj", "CarHub.Api/"]
RUN dotnet restore "CarHub.Api/CarHub.Api.csproj"
COPY . .
WORKDIR "/src/CarHub.Api"
RUN dotnet publish "CarHub.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "CarHub.Api.dll"]
