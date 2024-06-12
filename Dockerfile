FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["BlogApp/BlogApp.csproj", "BlogApp/"]
RUN dotnet restore "BlogApp/BlogApp.csproj"
COPY . .
WORKDIR "/src/BlogApp"
RUN dotnet build "BlogApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlogApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlogApp.dll"]