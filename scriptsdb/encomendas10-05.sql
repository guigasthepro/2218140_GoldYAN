-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 11-Maio-2021 às 00:55
-- Versão do servidor: 10.4.17-MariaDB
-- versão do PHP: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `goldyan`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `encomendas`
--

CREATE TABLE `encomendas` (
  `idencomenda` int(11) NOT NULL,
  `linha` int(11) NOT NULL,
  `idservico` int(11) NOT NULL,
  `peso` int(11) DEFAULT NULL,
  `apontamentos` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `quantidade` int(11) DEFAULT NULL,
  `precounitario` int(11) DEFAULT NULL,
  `precototal` int(11) DEFAULT NULL,
  `idlocalizacao` varchar(20) COLLATE utf8_bin DEFAULT 'Empty',
  `idestado` varchar(11) COLLATE utf8_bin DEFAULT 'Empty',
  `idproduto` int(11) DEFAULT NULL,
  `colaboradoratribuido` varchar(22) COLLATE utf8_bin DEFAULT NULL,
  `datadeentrega` varchar(23) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Extraindo dados da tabela `encomendas`
--

INSERT INTO `encomendas` (`idencomenda`, `linha`, `idservico`, `peso`, `apontamentos`, `quantidade`, `precounitario`, `precototal`, `idlocalizacao`, `idestado`, `idproduto`, `colaboradoratribuido`, `datadeentrega`) VALUES
(1, 1, 145, 9, 'FICOU ANEL OA C/BTS P/ Nº22', 1, 65, 65, NULL, NULL, NULL, NULL, '28 05 2021 12: 00'),
(1, 2, 146, 158, 'FICOU TAÇA PRATA PARA FAZER PEGA', 1, 80, 80, NULL, NULL, NULL, NULL, '28 05 2021 12: 00');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `encomendas`
--
ALTER TABLE `encomendas`
  ADD PRIMARY KEY (`idencomenda`,`linha`),
  ADD KEY `idproduto` (`idservico`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
