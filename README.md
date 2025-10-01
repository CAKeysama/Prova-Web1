# 📘 Prova Web1 - CRUD de Usuários (ASP.NET Core MVC)

Este repositório contém um exemplo prático de **CRUD de Usuários** feito em **ASP.NET Core MVC**, utilizando **Entity Framework Core com banco de dados em memória**.  

⚠️ **Atenção**: Este projeto foi desenvolvido com fins **exclusivamente educacionais**, para ajudar alunos que tiveram dificuldades em compreender os conteúdos durante as aulas.  
Não deve ser usado em produção.  

---

## ✨ Funcionalidades

✅ Listar todos os usuários  
✅ Criar novos usuários  
✅ Editar dados existentes  
✅ Excluir usuários  

📌 Cada usuário possui:
- **Id** (gerado automaticamente)
- **Nome**
- **Email**
- **Telefone**

---

## 🛠️ Tecnologias Utilizadas
- [ASP.NET Core MVC](https://learn.microsoft.com/aspnet/core)  
- [Entity Framework Core](https://learn.microsoft.com/ef/core/)  
- Banco **InMemory** (somente para testes)  
- Razor Views  
- Bootstrap (estilização básica do template MVC)  

---

## ▶️ Como Rodar o Projeto

1. Clone este repositório ou baixe o código-fonte.  
2. Abra no **Visual Studio**.  
3. Instale os pacotes necessários (caso ainda não tenha feito):  

   ```powershell
   dotnet add package Microsoft.EntityFrameworkCore
   dotnet add package Microsoft.EntityFrameworkCore.InMemory

4. Compile o projeto (`Ctrl + Shift + B`).
5. Execute (`Ctrl + F5`).
6. Acesse no navegador:

   ```
   https://localhost:xxxx/Users
   ```

   *(substitua `xxxx` pela porta gerada pelo Visual Studio)*

---

## 🧩 Estrutura do Projeto

```
📂 ProvaWeb1
 ┣ 📂 Controllers
 ┃ ┗ 📄 UsersController.cs   → Lógica do CRUD
 ┣ 📂 Models
 ┃ ┣ 📄 User.cs              → Modelo de usuário com validações
 ┃ ┗ 📄 AppDbContext.cs      → Contexto do EF Core (InMemory)
 ┣ 📂 Views
 ┃ ┗ 📂 Users
 ┃    ┣ 📄 Index.cshtml      → Listagem
 ┃    ┣ 📄 Create.cshtml     → Formulário de criação
 ┃    ┣ 📄 Edit.cshtml       → Formulário de edição
 ┃    ┗ 📄 Delete.cshtml     → Confirmação de exclusão
 ┣ 📄 Program.cs             → Configuração do app e rotas
 ┗ 📄 README.md              → Este arquivo
```

---

## 🔍 O que está acontecendo?

* **`User`** → Define os dados do usuário (Nome, Email, Telefone, Id).
* **`AppDbContext`** → Gerencia o "banco de dados" em memória.
* **`UsersController`** → Controla todas as operações (Listar, Criar, Editar, Excluir).
* **Views** → Renderizam a interface para o usuário.
* **Banco InMemory** → Guarda os dados enquanto a aplicação roda.

  > Ao reiniciar o projeto, os dados são apagados.

---

## 📌 Observações

* O banco em memória é **temporário**.
* Este projeto é apenas um **guia educacional**.
* Pode ser usado como **modelo base** para implementar CRUDs em projetos futuros.

---

👨‍💻 Desenvolvido para fins educacionais e de prática em **ASP.NET Core MVC**.
