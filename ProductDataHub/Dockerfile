#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["ProductDataHub/ProductDataHub.csproj", "ProductDataHub/"]
RUN dotnet restore "ProductDataHub/ProductDataHub.csproj"
COPY . .
WORKDIR "/src/ProductDataHub"
RUN dotnet build "ProductDataHub.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProductDataHub.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProductDataHub.dll"]