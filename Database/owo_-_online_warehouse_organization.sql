-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Creato il: Gen 21, 2022 alle 18:06
-- Versione del server: 10.4.22-MariaDB
-- Versione PHP: 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `owo - online warehouse organization`
--

DELIMITER $$
--
-- Procedure
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertOdine` (IN `CodiceO` VARCHAR(45), IN `IdP` INT, IN `Quant` INT)  INSERT INTO ordine(CodiceOrdine,IdProdotto,Quantita) VALUES (CodiceP,IdP,Quant)$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Struttura della tabella `clienti`
--

CREATE TABLE `clienti` (
  `idClienti` int(11) NOT NULL,
  `NomeAzienda` varchar(45) DEFAULT NULL,
  `CodiceFiscale` varchar(45) DEFAULT NULL,
  `PartitaIva` varchar(45) DEFAULT NULL,
  `Telefono` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `IdIndirizzo` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='		';

--
-- Dump dei dati per la tabella `clienti`
--

INSERT INTO `clienti` (`idClienti`, `NomeAzienda`, `CodiceFiscale`, `PartitaIva`, `Telefono`, `Email`, `IdIndirizzo`) VALUES
(1, 'Coca-Cola', '123456789', '987654321', '3913913491', 'cocacola@gmail.com', NULL),
(2, 'BricoMan', '443245534', '203974733', '27678203232', 'brico@gmail.com', NULL);

-- --------------------------------------------------------

--
-- Struttura della tabella `fornitore`
--

CREATE TABLE `fornitore` (
  `idFornitore` int(11) NOT NULL,
  `NomeAzienda` varchar(45) DEFAULT NULL,
  `CodiceFiscale` varchar(45) DEFAULT NULL,
  `PartitaIva` varchar(45) DEFAULT NULL,
  `Telefono` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `IdIndirizzo` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `fornitore`
--

INSERT INTO `fornitore` (`idFornitore`, `NomeAzienda`, `CodiceFiscale`, `PartitaIva`, `Telefono`, `Email`, `IdIndirizzo`) VALUES
(1, 'Coca-Cola', '123456789', '987654321', '3913913491', 'cocacola@gmail.com', NULL),
(2, 'BricoMan', '443245534', '203974733', '27678203232', 'brico@gmail.com', NULL);

-- --------------------------------------------------------

--
-- Struttura della tabella `indirizzo`
--

CREATE TABLE `indirizzo` (
  `idIndirizzo` int(11) NOT NULL,
  `Via` varchar(45) DEFAULT NULL,
  `NumeroCivico` int(11) DEFAULT NULL,
  `Citta` varchar(45) DEFAULT NULL,
  `Provincia` varchar(45) DEFAULT NULL,
  `CAP` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `indirizzo`
--

INSERT INTO `indirizzo` (`idIndirizzo`, `Via`, `NumeroCivico`, `Citta`, `Provincia`, `CAP`) VALUES
(1, 'Mario Rossi', 22, 'Milano', 'MI', 20021),
(2, 'Verdi Rossi', 45, 'Meda', 'MB', 20032);

-- --------------------------------------------------------

--
-- Struttura della tabella `ordine`
--

CREATE TABLE `ordine` (
  `idOrdini` int(11) NOT NULL,
  `CodiceOrdine` varchar(10) DEFAULT NULL,
  `IdProdotto` int(11) DEFAULT NULL,
  `Quantita` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `ordine`
--

INSERT INTO `ordine` (`idOrdini`, `CodiceOrdine`, `IdProdotto`, `Quantita`) VALUES
(1, 'C0001', 1, 100),
(2, 'C0002', 3, 20),
(3, 'C0003', 3, 50);

-- --------------------------------------------------------

--
-- Struttura della tabella `prodotto`
--

CREATE TABLE `prodotto` (
  `idProdotto` int(11) NOT NULL,
  `NomeProdotto` varchar(50) DEFAULT NULL,
  `Descrizione` varchar(200) DEFAULT NULL,
  `Quantita` int(11) DEFAULT NULL,
  `Prezzo` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `prodotto`
--

INSERT INTO `prodotto` (`idProdotto`, `NomeProdotto`, `Descrizione`, `Quantita`, `Prezzo`) VALUES
(1, 'Coca-Cola', 'Bevanda energetica frizzante', 100, 2),
(2, 'Viti', 'Meteriali per la costruzione', 400, 0.1),
(3, 'Schede Video', 'Componente per l\'aquisizione di immagini', 200, 250),
(4, 'Tachipirina', 'Prodotto farmaceutico', 10, 2.5),
(5, 'Martelli', 'Utensile per costruzioni', 20, 5);

-- --------------------------------------------------------

--
-- Struttura della tabella `risorsa`
--

CREATE TABLE `risorsa` (
  `idRisorsa` int(11) NOT NULL,
  `nomeUtente` varchar(45) DEFAULT NULL,
  `passwordUtente` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `risorsa`
--

INSERT INTO `risorsa` (`idRisorsa`, `nomeUtente`, `passwordUtente`) VALUES
(1, 'alex', 'pass1'),
(2, 'bonfi', 'pass2'),
(3, 'meri', 'pass3');

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `clienti`
--
ALTER TABLE `clienti`
  ADD PRIMARY KEY (`idClienti`);

--
-- Indici per le tabelle `fornitore`
--
ALTER TABLE `fornitore`
  ADD PRIMARY KEY (`idFornitore`);

--
-- Indici per le tabelle `indirizzo`
--
ALTER TABLE `indirizzo`
  ADD PRIMARY KEY (`idIndirizzo`);

--
-- Indici per le tabelle `ordine`
--
ALTER TABLE `ordine`
  ADD PRIMARY KEY (`idOrdini`);

--
-- Indici per le tabelle `prodotto`
--
ALTER TABLE `prodotto`
  ADD PRIMARY KEY (`idProdotto`);

--
-- Indici per le tabelle `risorsa`
--
ALTER TABLE `risorsa`
  ADD PRIMARY KEY (`idRisorsa`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `clienti`
--
ALTER TABLE `clienti`
  MODIFY `idClienti` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT per la tabella `fornitore`
--
ALTER TABLE `fornitore`
  MODIFY `idFornitore` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT per la tabella `indirizzo`
--
ALTER TABLE `indirizzo`
  MODIFY `idIndirizzo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT per la tabella `ordine`
--
ALTER TABLE `ordine`
  MODIFY `idOrdini` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT per la tabella `prodotto`
--
ALTER TABLE `prodotto`
  MODIFY `idProdotto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT per la tabella `risorsa`
--
ALTER TABLE `risorsa`
  MODIFY `idRisorsa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
