CREATE TABLE IF NOT EXISTS Vendite(
id INT AUTO_INCREMENT PRIMARY KEY,
prodotto VARCHAR(100),
categoria VARCHAR(50),
quantita INT,
prezzo_unitario DECIMAL(6,2),
data_vendita DATE
);

INSERT INTO Vendite (prodotto, categoria, quantita, prezzo_unitario, data_vendita) VALUES
('Laptop Lenovo IdeaPad', 'Informatica', 3, 799.99, '2025-01-10'),
('Mouse Logitech M185', 'Accessori', 10, 19.99, '2025-01-12'),
('Smartphone Samsung Galaxy S23', 'Telefonia', 5, 899.50, '2025-02-05'),
('Stampante HP DeskJet 2700', 'Periferiche', 2, 79.90, '2025-02-10'),
('Monitor LG 24"', 'Periferiche', 4, 159.99, '2025-02-15'),
('Tastiera Meccanica Corsair', 'Accessori', 3, 119.90, '2025-02-18'),
('Auricolari Apple AirPods', 'Telefonia', 6, 149.00, '2025-03-02'),
('Hard Disk Seagate 1TB', 'Informatica', 5, 59.99, '2025-03-05'),
('SSD Samsung 1TB', 'Informatica', 4, 109.00, '2025-03-07'),
('Cuffie Sony WH-1000XM5', 'Audio', 2, 349.90, '2025-03-10'),
('Tablet Apple iPad 10', 'Tablet', 3, 459.00, '2025-03-15'),
('Smartwatch Garmin Venu 3', 'Wearable', 2, 379.99, '2025-03-18'),
('Notebook HP Pavilion', 'Informatica', 4, 699.00, '2025-03-20'),
('Router TP-Link Archer AX55', 'Rete', 3, 129.99, '2025-03-22'),
('TV Samsung 55" 4K', 'Elettrodomestici', 2, 699.90, '2025-03-25'),
('Console PlayStation 5', 'Gaming', 2, 549.99, '2025-04-01'),
('Controller Xbox Wireless', 'Gaming', 5, 59.99, '2025-04-03'),
('MacBook Air M3', 'Informatica', 2, 1299.00, '2025-04-10'),
('Fotocamera Canon EOS 250D', 'Fotografia', 1, 629.90, '2025-04-12'),
('Powerbank Anker 20000mAh', 'Accessori', 8, 39.99, '2025-04-15');

SELECT DISTINCT categoria,
	COUNT(*) AS TotaleVendite
FROM Libreria.Vendite
GROUP BY categoria;

SELECT DISTINCT categoria,
	AVG(prezzo_unitario) AS PrezzoMedio
FROM Libreria.Vendite
GROUP BY categoria;

SELECT prodotto,
	SUM(quantita)
FROM Libreria.Vendite
GROUP BY prodotto;

SELECT
	MAX(prezzo_unitario) AS PrezzoMassimo,
	MIN(prezzo_unitario) AS PrezzoMinimo
FROM Libreria.Vendite;

SELECT COUNT(*) AS NumeroVendite
FROM Libreria.Vendite;

SELECT prodotto,
	prezzo_unitario
FROM Libreria.Vendite
ORDER BY prezzo_unitario DESC
LIMIT 5;

SELECT SUM(quantita) AS QuantitaVenduta
FROM Libreria.Vendite
GROUP BY prodotto
ORDER BY QuantitaVenduta ASC
LIMIT 3;