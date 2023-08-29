FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Harpocrates.API/Harpocrates.API.csproj", "Harpocrates.API/"]
RUN dotnet restore "Harpocrates.API/Harpocrates.API.csproj"
COPY . .
WORKDIR "/src/Harpocrates.API"
RUN dotnet build "Harpocrates.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Harpocrates.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Harpocrates.API.dll"]
