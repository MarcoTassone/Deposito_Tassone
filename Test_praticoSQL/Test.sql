CREATE DATABASE Test_pratico;

CREATE TABLE Libri (
   id INT AUTO_INCREMENT PRIMARY KEY,
   titolo VARCHAR(100),
   autore VARCHAR(100),
   genere VARCHAR(50),
   anno_pubblicazione INT,
   prezzo DECIMAL(6,2)
);

CREATE TABLE Vendite (
   id INT AUTO_INCREMENT PRIMARY KEY,
   id_libro INT,
   data_vendita DATE,
   quantita INT,
   negozio VARCHAR(100)
);

INSERT INTO Libri (titolo, autore, genere, anno_pubblicazione, prezzo) VALUES
('Il Nome della Rosa', 'Umberto Eco', 'Storico', 1980, 14.90),
('1984', 'George Orwell', 'Distopico', 1949, 12.50),
('Orgoglio e Pregiudizio', 'Jane Austen', 'Romanzo', 1813, 10.90),
('Il Signore degli Anelli', 'J.R.R. Tolkien', 'Fantasy', 1954, 22.00),
('Harry Potter e la Pietra Filosofale', 'J.K. Rowling', 'Fantasy', 1997, 15.50),
('I Promessi Sposi', 'Alessandro Manzoni', 'Classico', 1827, 11.00),
('Cronache di Narnia', 'C.S. Lewis', 'Fantasy', 1950, 13.80),
('Il Piccolo Principe', 'Antoine de Saint-Exupéry', 'Favola', 1943, 9.50),
('Moby Dick', 'Herman Melville', 'Avventura', 1851, 12.20),
('La Divina Commedia', 'Dante Alighieri', 'Poema', 1320, 16.90),
('Il Gattopardo', 'Giuseppe Tomasi di Lampedusa', 'Storico', 1958, 13.50),
('Don Chisciotte', 'Miguel de Cervantes', 'Classico', 1605, 14.00),
('Cime Tempestose', 'Emily Brontë', 'Romanzo', 1847, 10.80),
('Dracula', 'Bram Stoker', 'Horror', 1897, 11.90),
('Frankenstein', 'Mary Shelley', 'Horror', 1818, 10.50),
('Il Grande Gatsby', 'F. Scott Fitzgerald', 'Romanzo', 1925, 12.70),
('Le Avventure di Sherlock Holmes', 'Arthur Conan Doyle', 'Giallo', 1892, 11.80),
('Guerra e Pace', 'Lev Tolstoj', 'Storico', 1869, 18.50),
('Anna Karenina', 'Lev Tolstoj', 'Romanzo', 1877, 17.20),
('Il Processo', 'Franz Kafka', 'Filosofico', 1925, 13.40),
('Lo Hobbit', 'J.R.R. Tolkien', 'Fantasy', 1937, 14.50),
('La Fattoria degli Animali', 'George Orwell', 'Satira', 1945, 9.90),
('La Metamorfosi', 'Franz Kafka', 'Filosofico', 1915, 8.90),
('Fahrenheit 451', 'Ray Bradbury', 'Distopico', 1953, 11.60),
('Il Ritratto di Dorian Gray', 'Oscar Wilde', 'Romanzo', 1890, 10.70),
('Cuore', 'Edmondo De Amicis', 'Classico', 1886, 9.40),
('Ventimila Leghe Sotto i Mari', 'Jules Verne', 'Avventura', 1870, 12.10),
('Il Barone Rampante', 'Italo Calvino', 'Romanzo', 1957, 13.30),
('Siddharta', 'Hermann Hesse', 'Filosofico', 1922, 10.20),
('L’Alchimista', 'Paulo Coelho', 'Romanzo', 1988, 11.90);

INSERT INTO Vendite (id_libro, data_vendita, quantita, negozio) VALUES
(1, '2025-01-05', 3, 'Libreria Centrale Milano'),
(2, '2025-01-06', 5, 'Mondadori Roma'),
(3, '2025-01-08', 2, 'Feltrinelli Torino'),
(4, '2025-01-09', 4, 'Libraccio Bologna'),
(5, '2025-01-10', 7, 'Feltrinelli Firenze'),
(6, '2025-01-11', 2, 'Libreria Centrale Milano'),
(7, '2025-01-12', 5, 'Feltrinelli Roma'),
(8, '2025-01-14', 8, 'Libreria Centrale Napoli'),
(9, '2025-01-15', 1, 'Mondadori Torino'),
(10, '2025-01-16', 3, 'Feltrinelli Milano'),
(11, '2025-01-17', 2, 'Libreria Centrale Roma'),
(12, '2025-01-18', 6, 'Mondadori Bologna'),
(13, '2025-01-19', 3, 'Feltrinelli Firenze'),
(14, '2025-01-20', 2, 'Libreria Centrale Milano'),
(15, '2025-01-21', 5, 'Mondadori Roma'),
(16, '2025-01-22', 3, 'Feltrinelli Torino'),
(17, '2025-01-23', 2, 'Libraccio Bologna'),
(18, '2025-01-24', 4, 'Feltrinelli Firenze'),
(19, '2025-01-25', 1, 'Libreria Centrale Napoli'),
(20, '2025-01-26', 6, 'Mondadori Torino'),
(21, '2025-01-27', 3, 'Feltrinelli Milano'),
(22, '2025-01-28', 5, 'Libreria Centrale Roma'),
(23, '2025-01-29', 4, 'Mondadori Bologna'),
(24, '2025-01-30', 7, 'Feltrinelli Firenze'),
(25, '2025-02-01', 2, 'Libreria Centrale Milano'),
(26, '2025-02-02', 4, 'Mondadori Roma'),
(27, '2025-02-03', 3, 'Feltrinelli Torino'),
(28, '2025-02-04', 6, 'Libraccio Bologna'),
(29, '2025-02-05', 5, 'Feltrinelli Firenze'),
(30, '2025-02-06', 8, 'Libreria Centrale Napoli');

-- es1 INNER JOIN + WHERE + LIKE
-- non ho autori con "king" quindi ne ho scelto uno che avevo
SELECT Libri.titolo, 
Libri.autore, 
Vendite.data_vendita, 
Vendite.negozio
FROM Libri
INNER JOIN Vendite ON Libri.id = Vendite.id_libro
WHERE LOWER(Libri.autore) LIKE '%tolstoj%';

-- es2 LEFT JOIN + WHERE + BETWEEN

SELECT Libri.titolo, 
Libri.anno_pubblicazione, 
Libri.prezzo, 
Vendite.data_vendita
FROM Libri
LEFT JOIN Vendite ON Libri.id = Vendite.id_libro
WHERE Libri.anno_pubblicazione BETWEEN 1900 AND 1990 -- cambio date perché non ho libri che vanno dal 2000 al 2010
ORDER BY Libri.anno_pubblicazione DESC;

-- es3 INNER JOIN + WHERE + IN

SELECT Libri.titolo, 
	Vendite.negozio, 
	Vendite.quantita, 
	Vendite.quantita * Libri.prezzo AS prezzo_totale
FROM Libri
INNER JOIN Vendite ON Libri.id = Vendite.id_libro
WHERE Vendite.negozio IN ('Libreria Centrale Milano', 'Libraccio Bologna', 'Mondadori Roma');

-- es4 RIGHT JOIN + WHERE + LIKE + BETWEEN

SELECT Libri.titolo, 
Vendite.data_vendita, 
Libri.prezzo, 
Vendite.quantita
FROM Libri
RIGHT JOIN Vendite ON Libri.id = Vendite.id_libro
WHERE Vendite.data_vendita BETWEEN '1900-01-01' AND '1990-12-31' AND Vendite.negozio LIKE '%Libreria%'; -- non funziona non so perché

-- es5 INNER JOIN + WHERE combinato

SELECT Libri.titolo, Libri.autore, Libri.prezzo, Vendite.data_vendita
FROM Libri
INNER JOIN Vendite ON Libri.id = Vendite.id_libro
WHERE Libri.genere IN ('Fantasy', 'Giallo', 'Romanzo') 
AND Libri.anno_pubblicazione > 1970 
AND Vendite.negozio LIKE '%Store%'
ORDER BY Libri.anno_pubblicazione DESC; -- anche qui, non capisco, dovrebbe essere giusto