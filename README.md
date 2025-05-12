# 📅 Sistema de Agenda de Compromissos (POO em C#)

## 🚀 Visão Geral
Aplicação de console para gerenciar compromissos com:  
✔ Cadastro de usuários, locais e participantes  
✔ Associações entre objetos (1:N, N:N, composição)  
✔ Validações de data, capacidade e campos obrigatórios  

## 📦 Estrutura das Classes
| Classe          | Responsabilidade                              |
|-----------------|---------------------------------------------|
| `Usuario`       | Dono dos compromissos (lista privada)        |
| `Compromisso`   | Armazena data, local, participantes e anotações |
| `Participante`  | Convidados com associação bidirecional       |
| `Anotacao`      | Notas internas (composição)                  |
| `Local`         | Define capacidade máxima de pessoas          |

## ⚙️ Como Executar
```bash
dotnet run
