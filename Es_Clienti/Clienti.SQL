CREATE TABLE Clienti(
id INT AUTO_INCREMENT PRIMARY KEY,
nome VARCHAR(100),
cognome VARCHAR(100),
email VARCHAR(100),
eta INT,
citta VARCHAR(100)
);

INSERT INTO Clienti (nome, cognome, email, eta, citta) VALUES
('Luca', 'Rossi', 'luca.rossi@gmail.com', 28, 'Milano'),
('Giulia', 'Bianchi', 'giulia.bianchi@yahoo.it', 34, 'Roma'),
('Marco', 'Verdi', 'marco.verdi@hotmail.com', 41, 'Torino'),
('Sara', 'Russo', 'sara.russo@gmail.com', 25, 'Napoli'),
('Alessandro', 'Ferrari', 'alessandro.ferrari@example.com', 38, 'Firenze'),
('Francesca', 'Gallo', 'francesca.gallo@outlook.it', 30, 'Bologna'),
('Davide', 'Romano', 'davide.romano@gmail.com', 27, 'Genova'),
('Elena', 'Conti', 'elena.conti@example.com', 33, 'Venezia'),
('Matteo', 'De Luca', 'matteo.deluca@yahoo.it', 45, 'Palermo'),
('Chiara', 'Moretti', 'chiara.moretti@gmail.com', 29, 'Verona'),
('Federico', 'Mariani', 'federico.mariani@hotmail.com', 36, 'Parma'),
('Valentina', 'Rizzo', 'valentina.rizzo@example.com', 24, 'Bari'),
('Giorgio', 'Leone', 'giorgio.leone@outlook.it', 39, 'Catania'),
('Martina', 'Caruso', 'martina.caruso@gmail.com', 31, 'Trieste'),
('Simone', 'Costa', 'simone.costa@example.com', 26, 'Perugia'),
('Ilaria', 'Greco', 'ilaria.greco@gmail.com', 35, 'Lecce'),
('Nicola', 'Fontana', 'nicola.fontana@yahoo.it', 42, 'Pisa'),
('Claudia', 'Santoro', 'claudia.santoro@example.com', 28, 'Modena'),
('Andrea', 'Fabbri', 'andrea.fabbri@gmail.com', 37, 'Reggio Emilia'),
('Beatrice', 'Marchetti', 'beatrice.marchetti@hotmail.com', 32, 'Padova');


SELECT *
FROM Clienti;

SELECT *
FROM Clienti
WHERE email LIKE '%@gmail%';

SELECT nome, email
FROM Clienti
WHERE email LIKE '%@gmail.com';

SELECT nome
FROM Clienti
WHERE nome LIKE 'A%';

SELECT nome
FROM Clienti
WHERe nome LIKE '%a$';

SELECT cognome
FROM Clienti
WHERE CHAR_LENGTH(cognome) = 5;

SELECT cognome
FROM Clienti
WHERE cognome LIKE '_____';

SELECT nome, eta
FROM Clienti
WHERE eta BETWEEN 31 AND 40;

SELECT nome, eta
FROM Clienti
WHERE eta BETWEEN 30 AND 40;

SELECT nome, citta
FROM Clienti
WHERE citta LIKE 'roma';

SELECT nome, citta
FROM Clienti
WHERE citta LIKE '%roma%';