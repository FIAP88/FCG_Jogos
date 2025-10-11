# 🎮 FCG_Jogos — API de Jogos da FIAP Cloud Games

API REST para gerenciamento de jogos e integração com pagamentos, busca e métricas, desenvolvida em **.NET 8** com práticas modernas de desenvolvimento.

---

## 🧬 Índice

- [Sobre o Projeto](#sobre-o-projeto)  
- [Tecnologias](#tecnologias)  
- [Arquitetura & Infra](#arquitetura--infra)  
- [Pré-requisitos](#pré-requisitos)  
- [Instalação](#instalação)  
- [Configuração](#configuração)  
- [Execução](#execução)  
- [Endpoints da API](#endpoints-da-api)  
- [Testes](#testes)  
- [Docker](#docker)  
- [Monitoramento & Logs](#monitoramento--logs)  
- [Segurança](#segurança)  
- [Performance](#performance)  
- [Deploy](#deploy)  
- [Roadmap / Futuras melhorias](#roadmap--futuras-melhorias)  
- [Licença](#licença)  
- [Equipe / Contribuição](#equipe--contribuição)  
- [Suporte / Contato](#suporte--contato)  

---

## 📘 Sobre o Projeto

A API **FCG_Jogos** é um microserviço responsável pelo gerenciamento dos jogos na plataforma **FIAP Cloud Games**.  
Ela oferece integração com:

- serviço de pagamentos externo (via API)  
- ElasticSearch para indexação e busca  
- métricas e telemetria (Prometheus, OpenTelemetry, Application Insights)  
- autenticação e autorização via JWT  

### ✨ Funcionalidades

- CRUD de jogos  
- Integração com serviço de pagamento  
- Indexação de dados em ElasticSearch  
- Logging, rastreamento e métricas  
- Middlewares de tratamento de erros e correlação de requisições  

---

## 💻 Tecnologias

### 🧩 Core & Infraestrutura

- .NET 8  
- C#  
- ASP.NET Core Web API  
- Entity Framework Core + SQL Server  
- ElasticSearch / NEST  
- JWT com `Microsoft.AspNetCore.Authentication.JwtBearer`  
- OpenTelemetry + Azure Monitor / Application Insights  
- Prometheus (via `prometheus-net`)  
- Serilog para logging  
- Middleware customizado para tratamento de erros e correlação  
- HTTP Client para integração com API de pagamentos  

---

## 🏛 Arquitetura & Infra

A arquitetura do projeto está organizada para manter separação de responsabilidades, modularidade e testabilidade.  

- Camadas (ideal): Presentation / Serviços / Infra / Configuração  
- Middlewares personalizados (`tratamento de erros`, `correlação`, `info do usuário`)  
- Integração com ElasticSearch (indexação de jogos)  
- Uso de `IHttpClientFactory` para chamadas externas  
- Telemetria distribuída com OpenTelemetry + Application Insights  

---

## ⚙️ Pré-requisitos

- .NET 8 SDK  
- SQL Server (Azure SQL ou local)  
- ElasticSearch acessível  
- Credenciais de API de pagamentos e chave secreta  
- Docker (se usar contêiner)  
- Git  

---

## 🚀 Instalação

```bash
# Clonar o repositório
git clone https://github.com/FIAP88/FCG_Jogos.git
cd FCG_Jogos

# Restaurar dependências
dotnet restore

# Compilar
dotnet build
