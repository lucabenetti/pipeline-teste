#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5238
ENV ASPNETCORE_URLS=http://*:5238

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PipeTeste.csproj", "."]
RUN dotnet restore "./PipeTeste.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "PipeTeste.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PipeTeste.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PipeTeste.dll"]