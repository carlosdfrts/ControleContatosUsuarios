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

**Página Inicial após Login**
<img width="1920" height="936" alt="image" src="https://github.com/user-attachments/assets/278ff0d4-c2b5-4a0c-9f0e-836837eff00e" />

**Tela de listagem de contatos**  
<img width="1920" height="934" alt="image" src="https://github.com/user-attachments/assets/b4a5143f-6840-4ae4-a6ab-7e10e69a3a09" />

**Tela de criar contato**  
<img width="1920" height="935" alt="image" src="https://github.com/user-attachments/assets/f1883d93-0d7f-4f24-a11c-bc9886c209a4" />

**Tela de editar contato**  
<img width="1920" height="933" alt="image" src="https://github.com/user-attachments/assets/e22f0f8b-d7b3-40ff-aed8-70c4e2baf87f" />

**Tela de confirmação de exclusão**  
<img width="1920" height="936" alt="image" src="https://github.com/user-attachments/assets/d1f3ad20-208a-4dcb-a66f-14ac751db3b0" />

**Tela de listagem de usuários**
<img width="1920" height="934" alt="image" src="https://github.com/user-attachments/assets/c4136b4b-0fe5-4fda-adc4-fbf2533d5442" />

**Tela de criar usuário**
<img width="1920" height="934" alt="image" src="https://github.com/user-attachments/assets/a150b73b-b440-4750-b91c-8c15b5e1ac9c" />

---

## Como rodar o projeto

1. Clone o repositório:

```bash
git clone https://github.com/carlosdfrts/ControleContatosUsuarios
