FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY PropertyUpdateApi/PropertyUpdateApi.csproj PropertyUpdateApi/
RUN dotnet restore PropertyUpdateApi/PropertyUpdateApi.csproj
COPY . .
WORKDIR /src/PropertyUpdateApi
RUN dotnet build PropertyUpdateApi.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish PropertyUpdateApi.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "PropertyUpdateApi.dll"]
