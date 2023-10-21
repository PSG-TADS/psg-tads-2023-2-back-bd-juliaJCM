/*
--JUNÇÃO 3 TABELAS--
Abaixo 3 tabelas estão sendo combinadas utilizando o comando INNER JOIN
Ao final, será me entregue apenas: 
NOME,CPF da tabela Clientes;
Modelo da tabela Veiculos;
Valor, MetodoPagamento da tabela Faturamentos;
*/
SELECT Clientes.Nome,Clientes.CPF, 
Veiculos.Modelo,
Faturamentos.Valor, Faturamentos.MetodoPagamento
FROM Clientes
INNER JOIN Veiculos
ON Clientes.Id = Veiculos.ClienteId
INNER JOIN Faturamentos
ON Clientes.Id = Faturamentos.ClienteId

----------------------------------------------
/*
--ORDER BY e WHERE--
Abaixo 3 tabelas estão sendo combinadas utilizando o comando INNER JOIN.
A claúsula WHERE me retorna apenas o nome,CPF,
modelo do veiculo e valor cobrado dos clientes cujo método 
de pagamento escolhido foi 'Débito'.
Ao final,é solicitado que os resultados sejam organizados em
ordem alfabética a partir do ORDER BY
*/
SELECT Clientes.Nome,Clientes.CPF,
Veiculos.Modelo,
Faturamentos.Valor, Faturamentos.MetodoPagamento
FROM Clientes
INNER JOIN Veiculos
ON Clientes.Id = Veiculos.ClienteId
INNER JOIN Faturamentos
ON Clientes.Id = Faturamentos.ClienteId
WHERE Faturamentos.MetodoPagamento = 'Débito'
ORDER BY Nome ASC
----------------------------------------------
/*
--LIKE--
Abaixo 3 tabelas estão sendo combinadas utilizando o comando INNER JOIN.
A claúsula LIKE retorna como resultado apenas
os clientes que possuem um veiculo cujo modelo
começa com a letra 'H'
*/
SELECT Clientes.Nome,
Veiculos.Modelo,
Faturamentos.Valor, Faturamentos.MetodoPagamento
FROM Clientes
INNER JOIN Veiculos
ON Clientes.Id = Veiculos.ClienteId
INNER JOIN Faturamentos
ON Clientes.Id = Faturamentos.ClienteId
WHERE Veiculos.Modelo LIKE 'H%'

----------------------------------------------
/*
--IN--
Abaixo 3 tabelas estão sendo combinadas utilizando o comando INNER JOIN.
A claúsula IN retorna como resultado apenas
os clientes que pagaram valores exatos de 5, 15 e 20
*/
SELECT Clientes.Nome,
Veiculos.Modelo,
Faturamentos.Valor, Faturamentos.MetodoPagamento
FROM Clientes
INNER JOIN Veiculos
ON Clientes.Id = Veiculos.ClienteId
INNER JOIN Faturamentos
ON Clientes.Id = Faturamentos.ClienteId
WHERE Faturamentos.Valor IN (15, 20, 5)

----------------------------------------------
/*
--GROUP BY--
Abaixo 2 tabelas estão sendo combinadas utilizando o INNER JOIN.
A claúsula GROUP BY irá agrupar as linhas da tabela Valor e
me retornar apenas o valor máximo dos clientes cujo Id é
3, 6 e 7
*/
SELECT Nome, MAX(Valor) AS ValorMaximo
FROM Clientes
INNER JOIN Faturamentos
ON Clientes.Id = Faturamentos.ClienteId
WHERE Clientes.Id IN (3,6,7)
GROUP BY Clientes.Nome

----------------------------------------------
/*
---GROUP BY e HAVING-
Abaixo 2 tabelas estão sendo combinadas utilizando o INNER JOIN.
A claúsula GROUP BY irá agrupar as linhas da tabela Valor e
me retornar apenas o valor máximo dos clientes cujo Id é
3, 6 e 7.
O HAVING é responsável por trazer apenas os valores
que sejam menores que 25
*/
SELECT Nome, SUM(Valor) AS ValorMaximo
FROM Clientes
INNER JOIN Faturamentos
ON Clientes.Id = Faturamentos.ClienteId
WHERE Clientes.Id IN (3,6,7)
GROUP BY Clientes.Nome
HAVING SUM(Valor) < 25

----------------------------------------------
/*
--SUBSELECT COM CORRELAÇÃO--
Abaixo é realizada uma subconsulta com correlação,
uma vez que ela retorna valores de tabelas externas.
Ao final, é retornado apenas o cliente cujo 
o valor do faturamento seja 15.
*/
SELECT Clientes.Nome,Clientes.CPF,
Clientes.Email, Clientes.Id
FROM Clientes
WHERE Id IN
	(SELECT ClienteId
	FROM Faturamentos
	WHERE Valor = '15')

----------------------------------------------
/*
--SUBSELECT SEM CORRELAÇÃO--
Abaixo é realizada uma subconsulta sem correlação
da tabela veiculos.
Ao final, é retornado apenas as informações do
veiculo cujo modelo começa com 'F'
*/
SELECT Veiculos.Modelo, Veiculos.Placa
FROM Veiculos
WHERE Modelo IN
	(SELECT Modelo 
	FROM Veiculos
	WHERE Modelo LIKE 'F%')

----------------------------------------------
/*
--EXISTS--
Abaixo a claúsula EXISTS verifica se existe
ao menos uma linha na tabela Clientes que 
corresponde ao número na tabela Veiculos.
Se a condição for verdadeira, o resultado apresentado será 
o CPF e nome dos clientes
*/
SELECT Clientes.Nome,Clientes.CPF
FROM Clientes
WHERE EXISTS (SELECT Modelo
	FROM Veiculos
	WHERE Clientes.Id = Veiculos.ClienteId)

----------------------------------------------
/*
--VIEW--
Abaixo foi criada uma VIEW cujo nome é Historico, onde
seu princiapal objetivo é simplificar consultas complexas.
O resultado dessa visão será apenas o nome, modelo do veículo,
valor do faturamento e o método de pagamento de um cliente.
*/
CREATE VIEW Historico AS
SELECT Clientes.Nome, Veiculos.Modelo,
Faturamentos.Valor, Faturamentos.MetodoPagamento
FROM Clientes
INNER JOIN Veiculos
ON Clientes.Id = Veiculos.ClienteId
INNER JOIN Faturamentos
ON Clientes.Id = Faturamentos.ClienteId
