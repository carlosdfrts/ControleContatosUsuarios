# Cadastro de Contatos MVC

Sistema de **CRUD de contatos com autenticação e controle de usuários**, desenvolvido em **ASP.NET Core MVC**, utilizando **Entity Framework Core** e **SQL Server**.

O projeto permite o gerenciamento de contatos e usuários, com sistema de login, validação de permissões com filtragem e diferenciação entre usuário comum e administrador.

---

## Tecnologias utilizadas

- ASP.NET Core MVC  
- C#  
- Entity Framework Core  
- SQL Server  
- Bootstrap 5  

---

## Funcionalidades

- Criar contatos e usuários
- Editar contatos e usuários
- Excluir contatos e usuários
- Listar todos os contatos e usuários
- Validação de campos obrigatórios  
- Confirmação de exclusão
- Identity (login e autenticação personalizada)
  
---

## Sistema de Usuários

O sistema conta com autenticação baseada em banco de dados:

- Tela de login
- Validação de usuário e senha
- Senhas armazenadas no banco de dados
- Controle de acesso por tipo de usuário

## Tipos de usuário
Usuário padrão

- Pode acessar o sistema
- Pode visualizar e gerenciar contatos (conforme regra definida)

Administrador

- Pode gerenciar contatos
- Pode criar, editar e excluir usuários
- Possui acesso total ao sistema

## Funcionalidades

## Contatos

- Criar contatos
- Editar contatos
- Excluir contatos
- Listar todos os contatos
- Validação de campos obrigatórios
- Confirmação de exclusão

## Usuários

- Cadastro de usuários
- Edição de usuários
- Exclusão de usuários
- Listagem de usuários
- Login com validação no banco de dados
- Controle de acesso por perfil (Usuário / Admin)

---

## Screenshots

**Tela de listagem de contatos**  
<img width="1920" height="936" alt="image" src="https://github.com/user-attachments/assets/4b972d44-f988-4217-b3ce-0e93bfe823cc" />

**Tela de criar contato**  
<img width="1920" height="935" alt="image" src="https://github.com/user-attachments/assets/00b3569d-7cfc-4d0e-a29e-192331663e8c" />

**Tela de editar contato**  
<img width="1920" height="935" alt="image" src="https://github.com/user-attachments/assets/a771eac1-1c71-4bdc-9069-f7b49a90fd9e" />

**Tela de confirmação de exclusão**  
<img width="1920" height="935" alt="image" src="https://github.com/user-attachments/assets/c33ebede-3dea-470a-8eaa-47ee3025843f" />

**Tela de listagem de usuários**
<img width="1920" height="934" alt="image" src="https://github.com/user-attachments/assets/51bd6474-4bd8-431b-b323-e7db0f01f148" />

**Tela de criar usuário**
<img width="1918" height="936" alt="image" src="https://github.com/user-attachments/assets/a39605d2-820d-4524-ad6c-1e706fad8b5f" />

---

## Como rodar o projeto

1. Clone o repositório:

```bash
git clone https://github.com/SEU-USUARIO/NOME-DO-REPOSITORIO.git
