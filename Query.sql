--Inserts na tabela de Produto
INSERT INTO Produto VALUES ('E5-575-72N3', 'Windows 10', 'Acer', 'Aspire E5', 'Intel core I7','16gb','Novo','15.6','SSD 256gb','Disponível')
INSERT INTO Produto VALUES ('E7-D785-85N8',	'Windows 10', 'Dell', 'Inspirion 3583', 'Intel core I7', '8gb', '15', 'Novo', 'HD 500gb', 'Disponível')
INSERT INTO Produto VALUES ('NP550XCJ-KT2BR','Windows 10', 'Samsung', 'Book E30', 'Intel core I3', '4gb', '15.6', 'Novo','Full HD (1920x1080)','Disponível')

/*Script para consulta de produtos, se o mesmo está alocado com algum cliente e qual a data prevista de devolução. */
SELECT prod.Marca 'Marca notebook',
prod.Modelo 'Modelo notebook',
prod.Status 'Status locação',
cli.Nome 'Nome cliente',
(CONVERT(VARCHAR, loc.DataFinal, 3)) 'Data prevista devolução'
FROM Locacao loc
INNER JOIN Cliente cli ON cli.ClienteId = loc.ClienteId
INNER JOIN Produto prod ON prod.ProdutoId = loc.ProdutoId