-- phpMyAdmin SQL Dump
-- version 4.5.4.1deb2ubuntu2.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Czas generowania: 21 Lip 2019, 02:14
-- Wersja serwera: 5.7.26-0ubuntu0.16.04.1
-- Wersja PHP: 7.0.33-0ubuntu0.16.04.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `xaynware`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `changelog`
--

CREATE TABLE `changelog` (
  `time` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `msg` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Zrzut danych tabeli `changelog`
--

INSERT INTO `changelog` (`time`, `msg`) VALUES
('2019-07-08 01:05:33', 'Hello guys its first version of the loader.');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `logs`
--

CREATE TABLE `logs` (
  `id` int(11) NOT NULL,
  `action` enum('report','login','debug','info') NOT NULL,
  `hwid` varchar(255) DEFAULT NULL,
  `ip` varchar(255) NOT NULL,
  `extra` varchar(255) NOT NULL,
  `time` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Zrzut danych tabeli `logs`
--

INSERT INTO `logs` (`id`, `action`, `hwid`, `ip`, `extra`, `time`) VALUES
(190, 'login', '84671F5BCXXXXXXXXXXXXXXXXXXXXXXXXXX', 'ip\n', 'success', '2019-07-20 13:42:59'),
(191, 'login', '84671F5BCXXXXXXXXXXXXXXXXXXXXXXXXXX', 'ip\n', 'success', '2019-07-20 22:08:20');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `hwid` varchar(255) NOT NULL,
  `banned` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Zrzut danych tabeli `users`
--

INSERT INTO `users` (`id`, `hwid`, `banned`) VALUES
(1, '650FEXXXXXXXXXXXXXXXXXXXXXXXXXX', 0),
(2, '84671XXXXXXXXXXXXXXXXXXXXXXXXXX', 0),
(6, '5C9697XXXXXXXXXXXXXXXXXXXXXXXXXX', 0),
(7, '415268XXXXXXXXXXXXXXXXXXXXXXXXXX', 0);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indexes for table `changelog`
--
ALTER TABLE `changelog`
  ADD PRIMARY KEY (`time`);

--
-- Indexes for table `logs`
--
ALTER TABLE `logs`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `hwid` (`hwid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `logs`
--
ALTER TABLE `logs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=192;
--
-- AUTO_INCREMENT dla tabeli `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
