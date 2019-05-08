FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY PropertReadApi/PropertReadApi.csproj PropertReadApi/
RUN dotnet restore PropertReadApi/PropertReadApi.csproj
COPY . .
WORKDIR /src/PropertReadApi
RUN dotnet build PropertReadApi.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish PropertReadApi.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "PropertReadApi.dll"]
