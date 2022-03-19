-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Creato il: Gen 31, 2022 alle 12:52
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
-- Database: `db5c`
--

DELIMITER $$
--
-- Procedure
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `AccessoDatabase` (IN `Var_nome` VARCHAR(50), IN `Var_pass` VARCHAR(50))  NO SQL
SELECT COUNT(idRisorsa) as "accessi" from risorseprogetto where Var_nome = nome and Var_pass = pass$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InserisciUtente` (IN `Nome` VARCHAR(20), IN `Cognome` VARCHAR(30), IN `Email` VARCHAR(50))  NO SQL
INsert into utenti(nome,cognome,email)
VALUES(Nome,Cognome,Email)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SelezionaTutto` ()  NO SQL
SELECT * from utenti$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Struttura della tabella `risorseprogetto`
--

CREATE TABLE `risorseprogetto` (
  `idRisorsa` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `pass` varchar(50) NOT NULL,
  `livelloSicurezza` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `risorseprogetto`
--

INSERT INTO `risorseprogetto` (`idRisorsa`, `nome`, `pass`, `livelloSicurezza`) VALUES
(1, 'alex', 'pass1', 3),
(2, 'samu', 'pass2', 2),
(3, 'cassi', 'pass3', 1);

-- --------------------------------------------------------

--
-- Struttura della tabella `tbllibri`
--

CREATE TABLE `tbllibri` (
  `id` int(10) UNSIGNED NOT NULL,
  `titolo` varchar(200) NOT NULL,
  `autore` varchar(200) NOT NULL,
  `prezzo` decimal(3,2) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dump dei dati per la tabella `tbllibri`
--

INSERT INTO `tbllibri` (`id`, `titolo`, `autore`, `prezzo`) VALUES
(1, 'Bibbia 5c info', 'reda', '9.99'),
(2, 'harry potter', 'jk rowling', '9.99');

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `risorseprogetto`
--
ALTER TABLE `risorseprogetto`
  ADD PRIMARY KEY (`idRisorsa`);

--
-- Indici per le tabelle `tbllibri`
--
ALTER TABLE `tbllibri`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `risorseprogetto`
--
ALTER TABLE `risorseprogetto`
  MODIFY `idRisorsa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT per la tabella `tbllibri`
--
ALTER TABLE `tbllibri`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
