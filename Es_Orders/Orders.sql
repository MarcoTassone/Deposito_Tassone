CREATE DATABASE Orders;

CREATE TABLE Clienti
(id INT AUTO_INCREMENT PRIMARY KEY,
nome VARCHAR(100),
citta VARCHAR(100)
);

CREATE TABLE Ordini
(id INT AUTO_INCREMENT PRIMARY KEY,
id_cliente INT,
data_ordine DATE,
import DECIMAL (7,2)
);

INSERT INTO Clienti(nome, citta) VALUES
('Luca', 'Milano'),
('Giulia', 'Roma'),
('Marco', 'Torino'),
('Sara', 'Napoli'),
('Alessandro', 'Firenze'),
('Francesca', 'Bologna'),
('Davide', 'Genova'),
('Elena', 'Venezia'),
('Matteo', 'Palermo'),
('Chiara', 'Verona'),
('Federico', 'Parma'),
('Valentina', 'Bari'),
('Giorgio', 'Catania'),
('Martina', 'Trieste'),
('Simone', 'Perugia'),
('Ilaria', 'Lecce'),
('Nicola', 'Pisa'),
('Claudia', 'Modena'),
('Andrea', 'Reggio Emilia'),
('Beatrice', 'Padova');

INSERT INTO Ordini (id_cliente, data_ordine, import) VALUES
(1, '2025-01-05', 150.50),
(2, '2025-01-08', 200.00),
(3, '2025-01-10', 320.75),
(4, '2025-01-12', 120.00),
(5, '2025-01-15', 450.25),
(6, '2025-01-18', 310.40),
(7, '2025-01-20', 275.90),
(8, '2025-01-22', 180.00),
(9, '2025-01-25', 500.50),
(10, '2025-01-28', 220.00),
(11, '2025-02-01', 330.75),
(12, '2025-02-04', 140.00),
(13, '2025-02-06', 410.25),
(14, '2025-02-09', 290.40),
(15, '2025-02-12', 260.90),
(16, '2025-02-15', 190.00),
(17, '2025-02-18', 520.50),
(18, '2025-02-20', 230.00),
(19, '2025-02-23', 340.75),
(20, '2025-02-26', 150.00);

SELECT Clienti.nome, Ordini.data_ordine, Ordini.import
FROM Ordini
INNER JOIN Clienti ON Ordini.id = Clienti.id;

SELECT Clienti.nome, Ordini.data_ordine, Ordini.import
FROM Clienti
LEFT JOIN Ordini ON Clienti.id = Ordini.id_cliente;

UPDATE Ordini
SET id_cliente = 22
WHERE id = 15;

SELECT Clienti.nome , Ordini.data_ordine, Ordini.import
FROM Clienti
RIGHT JOIN Ordini ON Clienti.id = Ordini.id_cliente;