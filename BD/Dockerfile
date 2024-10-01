# Используем базовый образ с ASP.NET Core Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

# Используем базовый образ для сборки приложения
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["BD.csproj", "./"]
RUN dotnet restore "./BD.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "BD.csproj" -c Release -o /app/build

# Выполняем сборку приложения
FROM build AS publish
RUN dotnet publish "BD.csproj" -c Release -o /app/publish

# Запускаем контейнер
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BD.dll"]