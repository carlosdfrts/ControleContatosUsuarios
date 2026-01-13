# Cadastro de Contatos MVC

Sistema completo de CRUD de contatos com autenticação, controle de usuários e permissões, desenvolvido em **ASP.NET Core MVC**, utilizando **Entity Framework Core** e **SQL Server**.

O projeto implementa um fluxo completo de cadastro e gerenciamento, incluindo autenticação personalizada, diferenciação entre perfis (Usuário / Admin) e interface responsiva utilizando Bootstrap.

---

## Tecnologias Utilizadas

- **ASP.NET Core MVC**
- **C# / .NET**
- **Entity Framework Core**
- **SQL Server**
- **Bootstrap 5**
- **JavaScript (DataTables)**

---

## Funcionalidades

### Autenticação e Usuários
- Login com validação no banco de dados  
- Perfis com permissões:
  - **Usuário:** acesso às funcionalidades básicas
  - **Administrador:** acesso total ao sistema
- Cadastro, edição e exclusão de usuários  
- Senhas armazenadas no banco

### Contatos
- Criar novos contatos  
- Editar contatos  
- Excluir contatos  
- Listagem de todos os contatos  
- Validação de campos obrigatórios  
- Tela de confirmação de exclusão  
- Interface amigável + DataTable  

---

## Arquitetura do Projeto
- Padrão **MVC**
- Repository Pattern  
- Migrations do EF Core
- Camadas separadas:
  - Controllers  
  - Models  
  - Repositórios  
  - Views  

---

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

## Como Rodar o Projeto

### 1. Clone o repositório
```bash
git clone https://github.com/carlosdfrts/ControleContatosUsuarios

