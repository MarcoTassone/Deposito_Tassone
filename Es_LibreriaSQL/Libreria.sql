CREATE DATABASE IF NOT EXISTS Libreria;
USE Libreria;
CREATE TABLE IF NOT EXISTS Libri(
id INT AUTO_INCREMENT PRIMARY KEY,
titolo VARCHAR(100),
autore VARCHAR(100),
genere VARCHAR(50),
prezzo DECIMAL(5,2),
anno_pubblicazione INT 
);

INSERT INTO Libri(
titolo,
autore,
genere,
prezzo,
anno_pubblicazione
)
VALUES (
"Harry Potter e la pietra filosofale",
"J.K. Rowling",
"romanzo",
100.00,
1997
), (
"Presidente?",
"Mirko Campari",
"Vita vera",
50.00,
2025
), (
"Faccio un passo avanti",
"Pinocchio",
"fantasy",
20.00,
1935
), (
"Hanno ucciso l'uomo ragno",
"883",
"pop",
883.00,
2002
), (
"Steve Jobs",
"Walter Isaacson",
"biografia",
120.00,
2011
), (
"Star Wars L'erede dell'Impero",
"Timothy Zahn",
"fantasy",
13.99,
1991
);

SELECT genere,
	COUNT(*) AS NumeroLibri,
    AVG(prezzo) AS PrezzoMedio
FROM Libreria.Libri
GROUP BY genere
ORDER BY genere ASC;

SELECT anno_pubblicazione
FROM Libreria.Libri
WHERE anno_pubblicazione > 2010
ORDER BY anno_pubblicazione DESC, prezzo ASC;