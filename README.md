## Sobre Singleton e Monostate

## Singleton
O singleton é um padrão criacional do GOF, no livro Design Patterns. Ele foi criado para garantir que uma classe tenha somente uma instância e forneça um ponto global de acesso para a mesma.

### Problemas do Singleton com SOLID

Singleton é considerado um anti-pattern por não respeitar o princípio do SOLID de responsabilidade única e também não utilizar interface para sua implementação.

## Monostate 

O padrão monostate foi proposto para resolver os problemas do singleton. A ideia é que seja possível ter várias instâncias de uma classe, com implementações diferente, porém elas podem compartilhar o mesmo dado e estado, ou seja, um objeto com a mesma intância.


# Projeto

Nesse projeto construí um console application que cria uma instância de uma lista de Movie, adicionando itens na lista, usando tanto o singleton quanto o monostate pattern. 

No caso do Singleton é possível observar que o objeto retornado sempre será o mesmo no final, porém no caso do monostate a classe instanciada tem instancias diferentes, porém compartilham a mesma instância do item em questão. 




