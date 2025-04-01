# Aplicação de registro de usuario em terminal - Processo seletivo 

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Uma aplicação de terminal desenvolvida em C# (.NET 8.0) para registro de usuário, criada como parte de um processo seletivo de estágio. O sistema demonstra conceitos de programação fundamentais e a capacidade de implementar operações CRUD básicas em um ambiente de console.

## 📋 Descrição

Aplicação de console para gerenciamento de usuários com as seguintes funcionalidades:
- Registro de usuários com **nome**, **email** e **idade**
- Validação de dados de entrada
- Listagem de usuários registrados
- Interface terminal simples e intuitiva

Desenvolvida para demonstrar:
- Dominio da linguagem C#
- Técnicas de validação de entrada
- Manipulação de dados na memória
- Organização de código limpo
- Interação com aplicações de console

## ✨ Principais Features

- 📝 **Registro de Usuario** com campos:
  - Nome (obrigatório)
  - Email (validação de formato com regex)
  - Idade (validação para inteiro positivo)
- 📋 **Listagem de usuários** com exibição formatada
- ⚠️ **Validação de entrada** com mensagens de erro
- ♻️ **Menu Interativo** com opções:
  - Registrar novos usuarios
  - Listar todos os usuarios
  - Procurar usuario por nome
  - Sair da aplicação
- 💾 **Persistência de dados em memória** durante a execução

## ⚙️ Pré-requisitos

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
- Terminal/Prompt de Comando
- IDE utilizada: Rider
  
## 🚀 Instalação e Execução

1. Clone o repositorio:
   ```bash
   git clone https://github.com/Gerson-Gomes/AutoMind-Intership.git

2. Restaure as dependencias
   ```bash
   dotnet restore
3. Execute a aplicação
   ```bash
   dotnet run


## 🖥️ Exemplo de uso
```bash
O que deseja fazer?

1. Cadastrar novo Usuario
2. Listar Usuarios
3. Procurar nome
4. Encerrar sessão

===Exemplo de Listagem===
Nome: Gerson
Email: gerson@gmail.com
Idade: 29

Nome: David
Email: david@gmail.com
Idade: 45

Nome: Vanessa
Email: vanessa@hotmail.com
Idade: 22
-----------------------------------

===Exemplo de Busca===
Digite o nome Usuario:
Gerson

Gerson - gerson@gmail.com - 29




