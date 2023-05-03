FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BNP.SensiorTesting.Api/BNP.SensiorTesting.Api.csproj", "BNP.SensiorTesting.Api/"]
RUN dotnet restore "BNP.SensiorTesting.Api/BNP.SensiorTesting.Api.csproj"
COPY . .
WORKDIR "/src/BNP.SensiorTesting.Api"
RUN dotnet build "BNP.SensiorTesting.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BNP.SensiorTesting.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BNP.SensiorTesting.Api.dll"]
