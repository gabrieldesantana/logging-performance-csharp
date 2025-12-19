# Logging Performance – C# / .NET

**Logging com foco em performance no .NET**  
Este repositório apresenta exemplos e comparações de técnicas de *logging* em C#, com ênfase em **alto desempenho** e **baixo custo de alocação**.

---

## 🚀 Visão Geral

O objetivo deste projeto é apresentar **boas práticas de logging performático em aplicações .NET**, comparando abordagens comuns com técnicas otimizadas.  
Em sistemas de alta carga, o logging mal implementado pode causar degradação significativa de performance — este repositório ajuda a entender e evitar esse problema.

---

## 🧠 Por que performance de logging importa?

Embora essencial, o logging pode ser caro quando:

- Há concatenação ou interpolação de strings desnecessária;
- O nível de log está desabilitado, mas o custo de formatação ainda ocorre;
- Há muitas alocações de memória por log;
- O sistema processa grande volume de requisições.

Este projeto explora formas de **manter observabilidade sem comprometer o throughput da aplicação**.

---

## 🛠️ Tecnologias utilizadas

- C#
- .NET 6+
- `Microsoft.Extensions.Logging`

---

## ▶️ Como executar

### Pré-requisitos

- .NET SDK 8 ou superior
- Visual Studio, VS Code ou Rider

### Executando o projeto

```bash
git clone https://github.com/gabrieldesantana/logging-performance-csharp.git
cd logging-performance-csharp
dotnet restore
dotnet build
dotnet run
