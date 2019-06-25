FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["app2/Docker.Proxy.AppTwo/Docker.Proxy.AppTwo.csproj", "app2/Docker.Proxy.AppTwo/"]
RUN dotnet restore "app2/Docker.Proxy.AppTwo/Docker.Proxy.AppTwo.csproj"
COPY . .
WORKDIR "/src/app2/Docker.Proxy.AppTwo"
RUN dotnet build "Docker.Proxy.AppTwo.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Docker.Proxy.AppTwo.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Docker.Proxy.AppTwo.dll"]
