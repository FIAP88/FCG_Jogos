# Etapa base de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

# Expõe explicitamente as portas usadas pela aplicação
EXPOSE 80
EXPOSE 443

# Define variável de ambiente para Kestrel escutar na porta 5030
ENV ASPNETCORE_URLS=http://+:5030

# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia apenas os arquivos de projeto para aproveitar cache
COPY FiapCloudGamesAPI/*.csproj FiapCloudGamesAPI/
RUN dotnet restore FiapCloudGamesAPI/FCG_API_Jogos.csproj

# Copia o restante do código
COPY . .

# Publica o projeto
RUN dotnet publish FiapCloudGamesAPI/FCG_API_Jogos.csproj -c Release -o /app/publish

# Etapa final de runtime
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "FCG_API_Jogos.dll"]