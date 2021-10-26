-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 26 Paź 2021, 14:58
-- Wersja serwera: 10.4.18-MariaDB
-- Wersja PHP: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `3ti_sp_cw4_x2021`
--
CREATE DATABASE IF NOT EXISTS `3ti_sp_cw4_x2021` DEFAULT CHARACTER SET utf8 COLLATE utf8_polish_ci;
USE `3ti_sp_cw4_x2021`;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `sections`
--

DROP TABLE IF EXISTS `sections`;
CREATE TABLE `sections` (
  `id` int(11) NOT NULL,
  `name` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `description` text COLLATE utf8_polish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `sections`
--

INSERT INTO `sections` (`id`, `name`, `description`) VALUES
(1, 'administracja', 'Dużo pracy z papierami'),
(2, 'transport', 'kierowcy z talentem do zabijania'),
(3, 'sprzedaż', 'Dużo pracy z klientem'),
(4, 'ochrona', 'Jeszcze więcej pracy z krnąbrnym klientem'),
(5, 'sprzątająca', 'Dużo pracy bez klienta'),
(6, 'kierownictwo', 'mało pracy z pracownikami');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `workers`
--

DROP TABLE IF EXISTS `workers`;
CREATE TABLE `workers` (
  `id` int(11) NOT NULL,
  `firstname` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `lastname` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `salary` decimal(10,2) NOT NULL,
  `section` int(11) NOT NULL,
  `description` text COLLATE utf8_polish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `workers`
--

INSERT INTO `workers` (`id`, `firstname`, `lastname`, `salary`, `section`, `description`) VALUES
(1, 'Adam', 'Nowak', '3300.00', 4, 'To jest ciekawy gość'),
(2, 'Minika', 'Janik', '3500.00', 1, NULL),
(3, 'Tomasz', 'Bomasz', '2500.00', 3, 'To jest ciekawy gość'),
(4, 'Roman', 'Janik', '3500.00', 1, NULL),
(5, 'Urszula', 'Małecka', '4200.00', 6, NULL),
(6, 'Ewelina', 'Lina', '2700.00', 3, NULL),
(7, 'Grażyna', 'Spężyna', '2900.00', 3, NULL),
(8, 'Ryszard', 'Turecki', '3700.00', 4, NULL),
(9, 'Wanda', 'Manda', '3100.00', 5, NULL),
(10, 'Bronisław', 'Skisław', '3300.00', 2, NULL);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `sections`
--
ALTER TABLE `sections`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `workers`
--
ALTER TABLE `workers`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_workers_sections` (`section`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `sections`
--
ALTER TABLE `sections`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT dla tabeli `workers`
--
ALTER TABLE `workers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `workers`
--
ALTER TABLE `workers`
  ADD CONSTRAINT `fk_workers_sections` FOREIGN KEY (`section`) REFERENCES `sections` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
