# 🍷 Vinheria Agnello - Sistema de Estoque

![C#](https://img.shields.io/badge/language-C%23-blue.svg)
![Status](https://img.shields.io/badge/status-em%20desenvolvimento-yellow)
![License](https://img.shields.io/badge/license-MIT-green)

> Um sistema de estoque moderno, organizado e extensível para a Vinheria Agnello, totalmente construído com C# e princípios sólidos de orientação a objetos.

---

## 📌 Sobre o Projeto

Este projeto foi desenvolvido para simular a gestão de estoque de uma vinheria tradicional que busca digitalizar seus processos mantendo a elegância e a experiência do cliente como foco principal.

A aplicação é **100% console-based**, com foco na arquitetura de software e organização de código.

---

## 🧱 Arquitetura

Estruturado seguindo o princípio de separação de responsabilidades:

```
VinheriaAgnello/
├── Models/              # Definições das entidades
├── Repositories/        # Regras de acesso a dados (simulados)
├── Services/            # Regras de negócio
└── Program.cs           # Interface principal (menu interativo)
```

---

## ✨ Funcionalidades

- Cadastro completo de vinhos
- Listagem com formatação elegante
- Edição com preservação de dados
- Remoção por ID
- Estrutura de repositórios em memória
- Sistema pronto para receber:
  - Filtros por tipo, origem, safra
  - Avaliação de sommelier
  - Compatibilidade com exportação `.csv`

---

## 🚀 Tecnologias utilizadas

- [.NET 9](https://dotnet.microsoft.com/)
- C# 12
- Console App
- Clean Code
- Programação Orientada a Objetos

---

## 🎯 Futuras melhorias

- Exportação para Excel ou CSV
- Integração com banco de dados real (EF Core)
- Filtro por harmonização ou tipo de uva
- Sistema de recomendações estilo sommelier

---

## 🪪 Licença

Este projeto está licenciado sob a licença MIT.
