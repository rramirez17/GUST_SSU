#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#RUN --name gustmssql -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=RaulPass22" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Gust.Core/Gust.Core.csproj", "Gust.Core/"]
RUN dotnet restore "Gust.Core/Gust.Core.csproj"
COPY . .
WORKDIR "/src/Gust.Core"
RUN dotnet build "Gust.Core.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Gust.Core.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Gust.Core.dll"]
