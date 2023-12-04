# Locadão - Sistema de Locação de Veículos

## Descrição

Locadão é uma API de locação de veículos desenvolvida em C# utilizando ASP.NET Core. Ela permite o gerenciamento de clientes, veículos e locações, proporcionando uma forma eficiente e moderna para empresas de locação gerenciarem suas operações.

## Funcionalidades

- **Cadastro de Clientes**: Permite adicionar, atualizar e excluir clientes do sistema.
- **Gerenciamento de Veículos**: Possibilita o cadastro e atualização de informações dos veículos, bem como o registro de locações.
- **Controle de Locações**: Administra as locações dos veículos, incluindo o início e fim do período de locação e o valor total.

## Endpoints da API

A API esta rodando na porta `7120`


### Obter Todos os Clientes

```http
GET /api/Clientes
```
Retorna uma lista de todos os clientes cadastrados.

### Obter Cliente por ID
```http
GET /api/Clientes/{id}
```
Retorna os detalhes de um cliente específico com base no ID fornecido. Se o cliente não for encontrado, um erro 404 é retornado.

### Adicionar Cliente
```http
POST /api/Clientes
```
Cria um novo registro de cliente. O corpo da solicitação deve conter os detalhes do cliente a serem adicionados.

#### Body
```json
{
    "id": 6,
    "nome": "Luydson",
    "cpf": "323.486.889-69",
    "dataNascimento": "1998-11-28",
    "endereco": "74 Tv. Benício Fontenele, São Luis",
    "idade": 24,
    "cnh": true,
    "veiculos": [
        {
            "id": 9,
            "marca": "Fiat",
            "modelo": "Argo",
            "placa": "dec-5647",
            "ano": 2021,
            "precoDiaria": 100.0,
            "alugado": true,
            "cliente": 6,
            "locacoes": [
                {
                    "id": 5,
                    "veiculo": 9,
                    "dataInicio": "2023-11-10",
                    "dataFim": "2023-11-20",
                    "valorTotal": 500.0
                }
            ]
        }
    ]
}
```
* - ![Screenshot_5](https://github.com/jcr04/Locadao.ASP.NET/assets/70778525/1ccd2d93-2ad5-4ee3-9c9a-e746f0da40d2)


### Atualizar Cliente
```http
PUT /api/Clientes/{id}
```
Atualiza os detalhes de um cliente existente com base no ID fornecido. O ID na URL deve corresponder ao ID no corpo da solicitação

### Excluir Cliente
```http
DELETE /api/Clientes/{id}
```
Remove um cliente do sistema com base no ID fornecido.
