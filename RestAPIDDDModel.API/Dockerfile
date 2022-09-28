#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RestAPIDDDModel.API/RestAPIDDDModel.API.csproj", "RestAPIDDDModel.API/"]
COPY ["RestAPIModeloDDD.Infrastructure/RestAPIDDDModel.Infrastructure.csproj", "RestAPIModeloDDD.Infrastructure/"]
COPY ["RestAPIModeloDDD.Domain/RestAPIDDDModel.Domain.csproj", "RestAPIModeloDDD.Domain/"]
COPY ["RestAPIModeloDDD.Domain.Services/RestAPIDDDModel.Domain.Services.csproj", "RestAPIModeloDDD.Domain.Services/"]
COPY ["RestAPIModeloDDD.Domain.Core/RestAPIDDDModel.Domain.Core.csproj", "RestAPIModeloDDD.Domain.Core/"]
COPY ["RestAPIModeloDDD.Application/RestAPIDDDModel.Application.csproj", "RestAPIModeloDDD.Application/"]
RUN dotnet restore "RestAPIDDDModel.API/RestAPIDDDModel.API.csproj"
COPY . .
WORKDIR "/src/RestAPIDDDModel.API"
RUN dotnet build "RestAPIDDDModel.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RestAPIDDDModel.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestAPIDDDModel.API.dll"]