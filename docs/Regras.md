Entidades:
 - Carros: Representa um tipo de carro dentro do stand, disponivel para compra
 - Empregado: O trablhador do stand, que pode vender carros e alterar info
	sobre os mesmos 
 - Cliente: Alguem que pode comprar carros
 - Vendas: Uma transação de um carro, inclui o preco da venda e o quem comprou

Relações importantes:
- O empregado vende um determinado carro
- O cliente pode ter vendas, associadas a sua compra de um carro
- O carro pode estar envolvido numa venda, implica a venda de um carro especifico.

Regras de negócio:
- Apenas um empregado pode alterar informação sobre o carro
- Apenas o cliente pode comprar carros
- O preço da venda é o preço do carro no momento da venda
