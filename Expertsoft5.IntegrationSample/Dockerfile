#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Expertsoft5.IntegrationSample/Expertsoft5.IntegrationSample.csproj", "Expertsoft5.IntegrationSample/"]
RUN dotnet restore "Expertsoft5.IntegrationSample/Expertsoft5.IntegrationSample.csproj"
COPY . .
WORKDIR "/src/Expertsoft5.IntegrationSample"
RUN dotnet build "Expertsoft5.IntegrationSample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Expertsoft5.IntegrationSample.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Expertsoft5.IntegrationSample.dll"]