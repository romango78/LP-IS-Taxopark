#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Taxopark/Taxopark.csproj", "Taxopark/"]
RUN dotnet restore "Taxopark/Taxopark.csproj"
COPY . .
WORKDIR "/src/Taxopark"
RUN dotnet build "Taxopark.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Taxopark.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Taxopark.dll"]