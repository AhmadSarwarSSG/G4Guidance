#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["G4Guidance/G4Guidance.csproj", "G4Guidance/"]
RUN dotnet restore "G4Guidance/G4Guidance.csproj"
COPY . .
WORKDIR "/src/G4Guidance"
RUN dotnet build "G4Guidance.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "G4Guidance.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "G4Guidance.dll"]