FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["app1/Docker.Proxy.AppOne/Docker.Proxy.AppOne.csproj", "app1/Docker.Proxy.AppOne/"]
RUN dotnet restore "app1/Docker.Proxy.AppOne/Docker.Proxy.AppOne.csproj"
COPY . .
WORKDIR "/src/app1/Docker.Proxy.AppOne"
RUN dotnet build "Docker.Proxy.AppOne.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Docker.Proxy.AppOne.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Docker.Proxy.AppOne.dll"]
