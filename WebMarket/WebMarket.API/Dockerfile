FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["WebMarket.API/WebMarket.API.csproj", "WebMarket.API/"]
RUN dotnet restore "WebMarket.API/WebMarket.API.csproj"
COPY . .
WORKDIR "/src/WebMarket.API"
RUN dotnet build "WebMarket.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebMarket.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebMarket.API.dll"]
