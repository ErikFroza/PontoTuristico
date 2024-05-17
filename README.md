﻿# PontoTuristico

## Configuração do Projeto

- O Banco de dados utilizado foi o Sql Server
- Abra o Visual Studio 2022
- Altere sua configuração do banco no arquivo Program.cs

```
builder.Services.AddDbContext<BancoContext> (options => options.UseSqlServer("Data Source=<SUA_CONFIGURACAO_HOST>;Initial Catalog=BD_SistemaPontoTuristico;User ID=<SEU_USUARIO>;Password=<SUA_SENHA>;Encrypt=False"));
```
*Substitua todos os valores entre < > pelas configurações corretas do seu banco de dados para que ele funcione corretamente.*

- No console de gerenciamento de pacotes, execute o código a seguir:

```
Update-Database
```
