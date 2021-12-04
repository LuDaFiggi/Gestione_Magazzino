-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Creato il: Dic 04, 2021 alle 11:54
-- Versione del server: 10.4.6-MariaDB
-- Versione PHP: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `progetto`
--

DELIMITER $$
--
-- Procedure
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `InserisciUtente` (IN `Nome` VARCHAR(20), IN `Cognome` VARCHAR(30), IN `Email` VARCHAR(50))  NO SQL
INsert into utenti(nome,cognome,email)
VALUES(Nome,Cognome,Email)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SelezionaTutto` ()  NO SQL
SELECT * from utenti$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Struttura della tabella `utenti`
--

CREATE TABLE `utenti` (
  `Id` int(11) NOT NULL,
  `nome` varchar(20) NOT NULL,
  `cognome` varchar(30) NOT NULL,
  `email` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `utenti`
--

INSERT INTO `utenti` (`Id`, `nome`, `cognome`, `email`) VALUES
(1, 'Marco', 'Rossi', 'ciao@ciao.com'),
(2, 'Marco', 'Rossi', 'ciao@ciao.com'),
(3, 'Alessandro', 'Facciani', 'ciao@ciao.com'),
(4, 'Alessandro', 'Facciani', 'ciao@ciao.com'),
(5, '#Nome', '#Cognome', '#mail'),
(6, '@Nome', '@Cognome', '@mail'),
(7, '@Nome', '@Cognome', '@mail'),
(8, '@Nome', '@Cognome', '@mail'),
(9, '@Nome', '@Cognome', '@mail'),
(10, '@Nome', '@Cognome', '@mail'),
(11, '@Nome', '@Cognome', '@mail'),
(12, '', '', NULL),
(13, '', '', NULL),
(14, 'Marco', 'Rossi', 'ciao@ciao.com'),
(15, 'Marco', 'Rossi', 'ciao@ciao.com'),
(16, 'Marco', 'Rossi', 'ciao@ciao.com'),
(17, 'Marco', 'Rossi', 'ciao@ciao.com'),
(18, 'Marco', 'Rossi', 'ciao@ciao.com'),
(19, 'Marco', 'Rossi', 'ciao@ciao.com'),
(20, 'Marco', 'Rossi', 'ciao@ciao.com'),
(21, 'Marco', 'Rossi', 'ciao@ciao.com'),
(22, 'Marco', 'Rossi', 'ciao@ciao.com'),
(23, 'Marco', 'Rossi', 'ciao@ciao.com'),
(24, 'Marco', 'Rossi', 'ciao@ciao.com'),
(25, 'Marco', 'Rossi', 'ciao@ciao.com'),
(26, 'Marco', 'Rossi', 'ciao@ciao.com'),
(27, 'Marco', 'Rossi', 'ciao@ciao.com'),
(28, 'Marco', 'Rossi', 'ciao@ciao.com'),
(29, 'Marco', 'Rossi', 'ciao@ciao.com'),
(30, 'Marco', 'Rossi', 'ciao@ciao.com'),
(31, 'Marco', 'Rossi', 'ciao@ciao.com'),
(32, 'Marco', 'Rossi', 'sus@ciao.com'),
(33, 'Marco', 'Rossi', 'sus@ciao.com'),
(34, 'Ciao', 'Ciao', 'sus@ciao.com');

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `utenti`
--
ALTER TABLE `utenti`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `utenti`
--
ALTER TABLE `utenti`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
