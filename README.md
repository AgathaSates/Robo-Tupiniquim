# Robô Tupiniquim - Desbrave Marte

![Status Finalizado](https://img.shields.io/badge/Status-Finalizado-green?color=Green)

 ### Demonstração

>![Demonstração do Projeto, gif imgur](https://i.imgur.com/cB2VLyW.gif)

## Índice

- [Introdução](#introdução)
- [Tecnologias usadas](#tecnologias-usadas)
- [Funcionalidades](#funcionalidades)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Como Usar](#como-usar)
- [Sobre o Projeto](#sobre-o-projeto)
- [Autor](#autor)

## Introdução

Robo Tupiniquim é uma aplicação de console que simula a exploração de 2 robôs em Marte.
A aplicação permite que os usuários controlem os movimentos do robô, veja sua posição final e acompanhe o histórico de exploração.

## Tecnologias usadas

[![Tecnologias](https://skillicons.dev/icons?i=git,github,cs,dotnet,visualstudio)](https://skillicons.dev)

## Funcionalidades

- **Inicializar Robôs**: Nomeie e defina as posições iniciais e direções dos robôs.
- **Movimentação do Robô**: Controle os movimentos do robô usando comandos para avançar, virar à esquerda ou virar à direita.
- **Área de Exploração**: Defina a área de exploração com dimensões personalizáveis.
- **Histórico de Missões**: Acompanhe e exiba o histórico de missões dos robôs de forma detalhada.
- **Validação de entradas:** Apenas os valores solicitados são aceitos, caso contrário, o usuário será instruído a inserir um valor válido.

### Comandos Exemplos

- `M`: Avançar
- `E`: Virar à esquerda
- `D`: Virar à direita

## Estrutura do Projeto

- `Entidades` – Representações de objetos como robô, terreno, etc.

- `Utilitários` – Métodos auxiliares como validações e escrita no console.

- `Program.cs` – Ponto de entrada principal da aplicação.


## Como Usar

### Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

### 1. Clone o repositório.
 
```
git clone https://github.com/AgathaSates/Robo-Tupiniquim.git
```
### 2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz

```
cd Robo-Tupiniquim
```

### 3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

### 4. Navegue até a pasta do projeto

```
cd Robo-Tupiniquim.ConsoleApp
```

### 5. Execute o projeto

```
dotnet run
```

## Sobre o Projeto
Desenvolvido durante o curso Fullstack da [Academia do Programador](https://academiadoprogramador.net) 2025

## Autor

- [Agatha Sates](https://github.com/AgathaSates) – Estudante de Desenvolvimento de Software na [Academia do Programador](https://academiadoprogramador.net)
