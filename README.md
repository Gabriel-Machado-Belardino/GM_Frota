# GM_Frota — Sistema de Logística para Transportadora

Aplicação de console em C# (.NET) que simula o controle de colaboradores e veículos de uma
transportadora, aplicando os pilares de Programação Orientada a Objetos: abstração, herança,
encapsulamento e polimorfismo.

## Requisitos atendidos

- **Abstração e Herança**: `FuncionarioTransporte` é uma classe abstrata que não pode ser
  instanciada diretamente. `MotoristaCarreta` e `EntregadorMoto` herdam dela.
- **Encapsulamento**: `Nome`, `Registro` e `Veiculo` são expostos por propriedades a partir de
  campos privados.
- **Construtores**: a classe base possui um construtor para os dados comuns; as classes filhas
  chamam `base(...)` e complementam com seus próprios atributos (`CategoriaCnh` e `ZonaEntrega`).
- **Polimorfismo**: `MostrarDetalhes()` é `virtual` na classe base e recebe `override` em cada
  classe filha, exibindo as particularidades de cada função.

## Estrutura de pastas

```
GM_Frota/
├── entities/       # Classes concretas (FuncionarioTransporte, MotoristaCarreta, EntregadorMoto, Veiculo, Carreta, Moto)
├── interfaces/      # Contratos implementados pelas entidades
├── utils/           # Utilitários (ConsoleWriter, formatação de saída no console)
├── Program.cs        # Ponto de entrada: instancia os colaboradores e chama MostrarDetalhes() de forma polimórfica
└── integrantes.md    # RM, nome dos integrantes e link do repositório
```

## Como executar

Pré-requisitos: [.NET SDK](https://dotnet.microsoft.com/) instalado (ou Visual Studio 2026).

```bash
dotnet run
```

Ou abra `GM_Frota.slnx` no Visual Studio 2026 e execute com `F5`.

## Integrantes

Ver [integrantes.md](integrantes.md).
