
# Projeto API Futebol (.NET 8)

## ✅ Requisitos

- .NET SDK 8 instalado
- Visual Studio Code com extensão C# (OmniSharp ou C# Dev Kit)

---

## 🚀 Como rodar o projeto

1. Abra a pasta do projeto no Visual Studio Code.
2. No terminal integrado (Ctrl + `), execute os comandos:

```bash
dotnet restore
dotnet build
dotnet run
```

3. Aguarde a aplicação iniciar e copie a URL exibida no terminal (exemplo: https://localhost:7050).
4. Acesse no navegador:

```
http://127.0.0.1:5500/frontend/index.html
```

---

## 🧩 Estrutura

- `/Controllers` – Controladores da API.
- `/Models` – Modelos de dados, como a classe `Jogador`.
- `/Data` – Contexto do banco de dados (`AppDbContext`).
- `Program.cs` – Configuração principal da aplicação.

---

Desenvolvido para fins acadêmicos.
