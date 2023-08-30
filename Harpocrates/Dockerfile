FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Harpocrates/Harpocrates.csproj", "Harpocrates/"]
RUN dotnet restore "Harpocrates/Harpocrates.csproj"
COPY . .
WORKDIR "/src/Harpocrates"
RUN dotnet build "Harpocrates.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Harpocrates.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Harpocrates.dll"]
