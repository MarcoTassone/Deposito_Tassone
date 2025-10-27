SELECT Clienti.nome, SUM(Ordini.import), COUNT(Ordini.id)
FROM Clienti
INNER JOIN Ordini ON Clienti.id = Ordini.id_cliente
GROUP BY Clienti.nome;

SELECT Clienti.nome, Clienti.citta
FROM Clienti
LEFT JOIN Ordini ON Clienti.id = Ordini.id_cliente
WHERE Ordini.id_cliente IS NULL;

SELECT Ordini.id, Ordini.data_ordine, Ordini.import
FROM Clienti
RIGHT JOIN Ordini ON Clienti.id = Ordini.id_cliente
WHERE Clienti.id IS NULL;