#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
ENV BuildingDocker true
WORKDIR /src
COPY ["DevFreela.API/DevFreela.API.csproj", "DevFreela.API/"]
COPY ["DevFreela.Infrastructure/DevFreela.Infrastructure.csproj", "DevFreela.Infrastructure/"]
COPY ["DevFreela.Core/DevFreela.Core.csproj", "DevFreela.Core/"]
COPY ["DevFreela.Application/DevFreela.Application.csproj", "DevFreela.Application/"]
RUN dotnet restore "DevFreela.API/DevFreela.API.csproj"
COPY . .
WORKDIR "/src/DevFreela.API"
RUN dotnet build "DevFreela.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DevFreela.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet DevFreela.API.dll