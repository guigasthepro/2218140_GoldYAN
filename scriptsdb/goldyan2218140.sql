-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 22-Fev-2021 às 13:20
-- Versão do servidor: 10.4.17-MariaDB
-- versão do PHP: 8.0.1

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
CREATE DATABASE IF NOT EXISTS `goldyan` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `goldyan`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `administracao`
--
-- Criação: 20-Jan-2021 às 15:49
--

CREATE TABLE `administracao` (
  `Dia` date NOT NULL,
  `Ganhos` int(11) NOT NULL,
  `Perdas` int(11) NOT NULL,
  `Vendas` int(11) NOT NULL,
  `stockinicio` int(11) NOT NULL,
  `stockfim` int(11) NOT NULL,
  `pouro` int(11) NOT NULL,
  `pprata` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- RELACIONAMENTOS PARA TABELAS `administracao`:
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetroleclaims`
--
-- Criação: 20-Jan-2021 às 17:08
--

CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `aspnetroleclaims`:
--   `RoleId`
--       `aspnetroles` -> `Id`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetroles`
--
-- Criação: 20-Jan-2021 às 17:08
--

CREATE TABLE `aspnetroles` (
  `Id` varchar(255) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `aspnetroles`:
--

--
-- Extraindo dados da tabela `aspnetroles`
--

INSERT INTO `aspnetroles` (`Id`, `Name`, `NormalizedName`, `ConcurrencyStamp`) VALUES
('1', 'Admin', 'Administrador', NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetuserclaims`
--
-- Criação: 20-Jan-2021 às 17:08
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `aspnetuserclaims`:
--   `UserId`
--       `aspnetusers` -> `Id`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetuserlogins`
--
-- Criação: 20-Jan-2021 às 17:08
--

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(128) NOT NULL,
  `ProviderKey` varchar(128) NOT NULL,
  `ProviderDisplayName` longtext DEFAULT NULL,
  `UserId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `aspnetuserlogins`:
--   `UserId`
--       `aspnetusers` -> `Id`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetuserroles`
--
-- Criação: 20-Jan-2021 às 17:08
--

CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(255) NOT NULL,
  `RoleId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `aspnetuserroles`:
--   `RoleId`
--       `aspnetroles` -> `Id`
--   `UserId`
--       `aspnetusers` -> `Id`
--

--
-- Extraindo dados da tabela `aspnetuserroles`
--

INSERT INTO `aspnetuserroles` (`UserId`, `RoleId`) VALUES
('05983ac5-6033-44b1-9a62-cdf2b19e6746', '1'),
('0fb9188d-43f1-4c06-9679-26773a7342ba', '1'),
('17b69848-f77f-49fa-a466-a74d7fdfbe61', '1'),
('4e979777-db7b-4dcd-b948-cf5511dc041d', '1');

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetusers`
--
-- Criação: 20-Jan-2021 às 17:08
--

CREATE TABLE `aspnetusers` (
  `Id` varchar(255) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext DEFAULT NULL,
  `SecurityStamp` longtext DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL,
  `PhoneNumber` longtext DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `aspnetusers`:
--

--
-- Extraindo dados da tabela `aspnetusers`
--

INSERT INTO `aspnetusers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
('05983ac5-6033-44b1-9a62-cdf2b19e6746', 'guigasthepro@gmail.com', 'GUIGASTHEPRO@GMAIL.COM', 'guigasthepro@gmail.com', 'GUIGASTHEPRO@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAECiBoIQ9hF3lmd1E0O5qURKwFBXIO9r9Da31zmkLx+qvkDzeZ5fpxaVgcMoSMoMG4A==', 'M23RE5HZILOTK4YRWC5OJS5WLZV3EFXW', 'ae133941-a19d-400e-8e4c-829fc60c336c', NULL, 0, 0, NULL, 1, 0),
('0fb9188d-43f1-4c06-9679-26773a7342ba', 'Afonso Dias', 'AFONSO@GMAIL.COM', 'afonso@gmail.com', 'AFONSO@GMAIL.COM', 1, 'AQAAAAEAACcQAAAAEMXpr6W24Lnhffy1tYXBw0KJpfQUliL1wJh9g+V6ZI+VxCEhDbpj8HLkWlphnWfo6w==', '3CE775OYZZY5HYK7INDISSK47KI6CPY2', '7058c8b2-d337-4733-8b76-9f2f3e60d1ae', NULL, 0, 0, NULL, 1, 0),
('17b69848-f77f-49fa-a466-a74d7fdfbe61', 'guigastheepro@gmail.com', 'GUIGASTHEEPRO@GMAIL.COM', 'guigastheepro@gmail.com', 'GUIGASTHEEPRO@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEJ1Y4zyQBXjF3Zm0hJ2/3JgFWqVuWqH2kHvjDmWk9Bx6pOFgZmmZlh4U1Cvg0Q9xlw==', 'MA7PEXLCM7VZ3HM4BV7NJ7LYL2C6I2I2', 'f8da86ff-cd22-4b26-9735-5e37ee4c294e', NULL, 0, 0, NULL, 1, 0),
('4e979777-db7b-4dcd-b948-cf5511dc041d', 'pedroabreu@trollador.pt', 'PEDROABREU@TROLLADOR.PT', 'pedroabreu@trollador.pt', 'PEDROABREU@TROLLADOR.PT', 1, 'AQAAAAEAACcQAAAAEPIU5DNu83Q8D8aL46s5MEuMlhnuqtxBH1cAEFxErpyE5SpChIdqHMUrhcU3AP1Khg==', 'UJYO4S64T6HCRPC4B3GXGYFSYTERLLJS', 'f43f9dd9-4392-44f6-8f82-f127f0e88f9c', NULL, 0, 0, NULL, 1, 0),
('6a01e420-3b0f-4f84-b80d-88c4509d9d5e', 'guigastheeepro@gmail.com', 'GUIGASTHEEEPRO@GMAIL.COM', 'guigastheeepro@gmail.com', 'GUIGASTHEEEPRO@GMAIL.COM', 1, 'AQAAAAEAACcQAAAAEI+UlCqkgzyCCO1mueWvzAaDA7hWm7dw99v3gPkgUCo92QIRQ25gp6/UvpWmD9qpow==', 'OVPHWXENVPDSGBSL5BX73YBFB72Q4VGT', 'ec5df5b7-e8fa-4529-bab3-bf672a2660e1', NULL, 0, 0, NULL, 1, 0),
('98c580f6-7e9c-4549-ac76-ff6e39659230', 'afonsocc@gmail.com', 'AFONSOCC@GMAIL.COM', 'afonsocc@gmail.com', 'AFONSOCC@GMAIL.COM', 1, 'AQAAAAEAACcQAAAAECzzVK2NUQM1A0hXfBb9I8K4v3X10qyDlcikMNvYaOemAz0eAY2DM//IFFo/HMsJBA==', 'L3QNN7JY76UNFM4ZPSERKACDJH57I3ZH', 'e8398ddb-bbd3-4685-a039-977c7821754a', NULL, 0, 0, NULL, 1, 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetusertokens`
--
-- Criação: 20-Jan-2021 às 17:08
--

CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(255) NOT NULL,
  `LoginProvider` varchar(128) NOT NULL,
  `Name` varchar(128) NOT NULL,
  `Value` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `aspnetusertokens`:
--   `UserId`
--       `aspnetusers` -> `Id`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `bancos`
--
-- Criação: 08-Fev-2021 às 12:49
--

CREATE TABLE `bancos` (
  `idbanco` int(11) NOT NULL,
  `codigobanco` varchar(8) NOT NULL,
  `nome` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `bancos`:
--

--
-- Extraindo dados da tabela `bancos`
--

INSERT INTO `bancos` (`idbanco`, `codigobanco`, `nome`) VALUES
(2, 'asafss', 'Bdadasnco do afonso');

-- --------------------------------------------------------

--
-- Estrutura da tabela `classificacaoprodutos`
--
-- Criação: 16-Fev-2021 às 09:01
--

CREATE TABLE `classificacaoprodutos` (
  `IDClassificacao` int(11) NOT NULL,
  `codigo` int(11) NOT NULL,
  `descricao` varchar(50) NOT NULL,
  `codigoat` varchar(2) NOT NULL,
  `inventario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `classificacaoprodutos`:
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--
-- Criação: 22-Fev-2021 às 11:33
--

CREATE TABLE `clientes` (
  `idcliente` int(11) NOT NULL,
  `idencomenda` int(11) NOT NULL,
  `nome` varchar(1000) COLLATE utf8_bin NOT NULL,
  `telefone` int(11) NOT NULL,
  `email` varchar(1000) COLLATE utf8_bin NOT NULL,
  `morada` varchar(1000) COLLATE utf8_bin NOT NULL,
  `moradaopcional` varchar(1000) COLLATE utf8_bin DEFAULT NULL,
  `codigopostal` varchar(100) COLLATE utf8_bin NOT NULL,
  `nif` int(11) NOT NULL,
  `profissao` varchar(30) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- RELACIONAMENTOS PARA TABELAS `clientes`:
--

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`idcliente`, `idencomenda`, `nome`, `telefone`, `email`, `morada`, `moradaopcional`, `codigopostal`, `nif`, `profissao`) VALUES
(1, 0, 'Afonso', 21333, 'guigasthepro@gmail.com', 'llll', 'llll', '12333', 12333, 'awdawd'),
(2, 0, 'Teresa', 849868498, 'afonsocc@gmail.com', 'eaweawe', 'eaweawe1', '12333', 44545, 'awdawd'),
(3, 0, 'Pedro Abreu', 919999999, 'TopXuxa@gmail.com', 'Rua do Kazzio', 'Praceta Cesario Verde', '2999123', 912939, 'Trolador'),
(4, 0, 'Afon444so', 845454, 'guigasthepro@gmail.com', 'llll', 'eaweawe1', '12333', 555, 'Ola'),
(9, 0, 'Afo5555', 95989, 'pedroabreu@trollador.pt', 'eaweawe', 'llll', '65656', 96595, 'Trolador'),
(10, 0, 'Guilherme Simao', 910938701, 'guigasthepro@gmail.com', 'Rua Da Milharada', '', '2745-822', 444444, 'Desempregado'),
(11, 0, 'BTL Network', 910938701, 'btlnetwork2.0@gmail.com', 'Rua Dona Isabel de Aragão', 'Rua Dona Isabel de Aragão', '2605-253', 111222, 'Desempregado'),
(12, 0, 'Guilherme Firmino Simao', 910938701, 'guigasthepro@gmail.com', 'Rua Da Milharada', 'Rua Da Milharada', '2745-822', 123123, 'Desempregado'),
(13, 0, 'Simao', 910938701, 'tesimao@gmail.com', 'Rua Da Milharada', 'Rua Da Milharada', '2745-822', 744445, 'Desempregado'),
(14, 0, 'Guilherme Luz', 912391923, 'luz@gmail.com', 'Rua da Maria Joaquna', '12312313', '123123', 123123, 'Desempregado'),
(16, 0, 'BTL N123123etwork', 910938701, 'btlnetwork2.0@gmail.com', 'Rua Dona Isabel de Aragão', 'Rua Dona Isabel de Aragão', '2605-253', 1231, 'Desempregado'),
(17, 0, 'Guilawdawdawdawdherme Simaoa', 910938701, 'guigasthepro@gmail.com', 'Rua Da Milharada', 'Rua Da Milharada', '2745-82', 12312312, 'adwdawdawda'),
(18, 0, 'Guilawdawdawdherme Simao', 910938701, 'tesimao@gmail.com', 'Rua Da Milharada', 'Rua Da Milharada', '2745-822', 123, 'awdawdawda');

-- --------------------------------------------------------

--
-- Estrutura da tabela `codigopostal`
--
-- Criação: 20-Jan-2021 às 15:49
--

CREATE TABLE `codigopostal` (
  `idcodigopostal` int(11) NOT NULL,
  `descricao` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `codigopostal`:
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `colaboradores`
--
-- Criação: 17-Fev-2021 às 12:33
--

CREATE TABLE `colaboradores` (
  `idcolaborador` int(11) NOT NULL,
  `idservico` int(11) NOT NULL,
  `idprofissao` int(11) NOT NULL,
  `nome` varchar(100) COLLATE utf8_bin NOT NULL,
  `password` varchar(100) COLLATE utf8_bin NOT NULL,
  `permissões` int(11) NOT NULL,
  `ganhoph` int(11) NOT NULL,
  `telefone` int(11) NOT NULL,
  `email` varchar(30) COLLATE utf8_bin NOT NULL,
  `comissao` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- RELACIONAMENTOS PARA TABELAS `colaboradores`:
--   `idprofissao`
--       `profissoes` -> `idprofissao`
--   `idservico`
--       `servicos` -> `idservico`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `encomendas`
--
-- Criação: 17-Fev-2021 às 12:36
--

CREATE TABLE `encomendas` (
  `idencomenda` int(11) NOT NULL,
  `idfabrico` int(11) NOT NULL,
  `idcliente` int(11) NOT NULL,
  `produtoid` int(11) NOT NULL,
  `criadapor` varchar(100) COLLATE utf8_bin NOT NULL,
  `estado` varchar(100) COLLATE utf8_bin NOT NULL,
  `datacriada` varchar(1000) COLLATE utf8_bin NOT NULL,
  `quantidade` int(11) NOT NULL,
  `peso` int(11) NOT NULL,
  `precounitario` int(11) NOT NULL,
  `desconto` int(11) NOT NULL,
  `precototal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- RELACIONAMENTOS PARA TABELAS `encomendas`:
--   `produtoid`
--       `produtos` -> `idproduto`
--   `idfabrico`
--       `fabrico` -> `idfabrico`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `fabrico`
--
-- Criação: 17-Fev-2021 às 12:30
--

CREATE TABLE `fabrico` (
  `idfabrico` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `fabrico`:
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `familiaprodutos`
--
-- Criação: 18-Fev-2021 às 09:37
--

CREATE TABLE `familiaprodutos` (
  `idfproduto` int(11) NOT NULL,
  `idunidade` int(11) DEFAULT NULL,
  `tipo` varchar(10) NOT NULL,
  `codigo` varchar(11) NOT NULL,
  `nome` int(11) NOT NULL,
  `descricao` varchar(30) NOT NULL,
  `descricaoeq` varchar(15) NOT NULL,
  `toque` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `familiaprodutos`:
--   `idunidade`
--       `unidades` -> `IDUnidade`
--

--
-- Extraindo dados da tabela `familiaprodutos`
--

INSERT INTO `familiaprodutos` (`idfproduto`, `idunidade`, `tipo`, `codigo`, `nome`, `descricao`, `descricaoeq`, `toque`) VALUES
(1, NULL, 'll', 'jkbgg', 1, '1', '1', 1.02);

-- --------------------------------------------------------

--
-- Estrutura da tabela `faturas`
--
-- Criação: 20-Jan-2021 às 15:49
--

CREATE TABLE `faturas` (
  `faturaid` int(11) NOT NULL,
  `idfornecedor` int(11) NOT NULL,
  `produtoid` int(11) NOT NULL,
  `tipo` int(11) NOT NULL,
  `custo` int(11) NOT NULL,
  `pago` int(11) NOT NULL,
  `peso` int(11) NOT NULL,
  `quantidade` int(11) NOT NULL,
  `feitio` int(11) NOT NULL,
  `cotacao` int(11) NOT NULL,
  `pvp` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- RELACIONAMENTOS PARA TABELAS `faturas`:
--   `idfornecedor`
--       `fornecedores` -> `idfornecedor`
--   `produtoid`
--       `produtos` -> `idproduto`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `fornecedores`
--
-- Criação: 17-Fev-2021 às 12:35
--

CREATE TABLE `fornecedores` (
  `idfornecedor` int(11) NOT NULL,
  `idbanco` int(11) NOT NULL,
  `alcunhafornecedor` varchar(100) COLLATE utf8_bin NOT NULL,
  `nomefornecedor` varchar(100) COLLATE utf8_bin NOT NULL,
  `datacriada` varchar(100) COLLATE utf8_bin NOT NULL,
  `telemovel` int(11) NOT NULL,
  `telefone` int(11) NOT NULL,
  `morada` varchar(60) COLLATE utf8_bin NOT NULL,
  `idcodigopostal` int(11) NOT NULL,
  `nif` int(11) NOT NULL,
  `iban` varchar(30) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- RELACIONAMENTOS PARA TABELAS `fornecedores`:
--   `idbanco`
--       `bancos` -> `idbanco`
--   `idcodigopostal`
--       `codigopostal` -> `idcodigopostal`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `materias`
--
-- Criação: 20-Jan-2021 às 15:49
--

CREATE TABLE `materias` (
  `idmateria` int(11) NOT NULL,
  `alcunha` int(11) NOT NULL,
  `nome` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `materias`:
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `modelos`
--
-- Criação: 17-Fev-2021 às 12:36
--

CREATE TABLE `modelos` (
  `idmodelo` int(11) NOT NULL,
  `idmolde` int(11) NOT NULL,
  `alcunha` varchar(100) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `idmateria` int(11) NOT NULL,
  `idservicos` int(11) NOT NULL,
  `produtoidf` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `modelos`:
--   `idmateria`
--       `materias` -> `idmateria`
--   `idservicos`
--       `servicos` -> `idservico`
--   `produtoidf`
--       `familiaprodutos` -> `idfproduto`
--   `idmolde`
--       `produtos` -> `idproduto`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `molde`
--
-- Criação: 27-Jan-2021 às 12:36
--

CREATE TABLE `molde` (
  `idmolde` int(11) NOT NULL,
  `codigo` varchar(50) NOT NULL,
  `descricao` varchar(75) NOT NULL,
  `idfproduto` int(11) NOT NULL,
  `gaveta` int(11) NOT NULL,
  `tempo` varchar(50) NOT NULL,
  `peso` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `molde`:
--

--
-- Extraindo dados da tabela `molde`
--

INSERT INTO `molde` (`idmolde`, `codigo`, `descricao`, `idfproduto`, `gaveta`, `tempo`, `peso`) VALUES
(3, 'XVV', 'Molde para brinco de cristal', 0, 1, '120', 0),
(4, 'PAI', 'Exemplo do molde pai a funcionar :)', 0, 1, '120', 0),
(5, 'AFS', 'Molde anel para afonso dias', 1, 20, '320', 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--
-- Criação: 18-Fev-2021 às 09:49
--

CREATE TABLE `produtos` (
  `idproduto` int(11) NOT NULL,
  `familiaproduto` int(11) DEFAULT NULL,
  `tipoproduto` int(11) DEFAULT NULL,
  `idfornecedor` int(11) DEFAULT NULL,
  `idfabrico` int(11) DEFAULT NULL,
  `codigo` varchar(20) NOT NULL,
  `nome` varchar(200) DEFAULT NULL,
  `descricao` varchar(200) DEFAULT NULL,
  `quantidade` int(11) DEFAULT NULL,
  `contrastaria` varchar(30) DEFAULT NULL,
  `preco` int(11) DEFAULT NULL,
  `pvp` int(11) DEFAULT NULL,
  `customedio` int(11) DEFAULT NULL,
  `feitio` int(11) DEFAULT NULL,
  `feitiograma` int(11) DEFAULT NULL,
  `cotacao` int(11) DEFAULT NULL,
  `gaveta` int(11) DEFAULT NULL,
  `tempo` varchar(6) DEFAULT NULL,
  `peso` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- RELACIONAMENTOS PARA TABELAS `produtos`:
--   `tipoproduto`
--       `tipoproduto` -> `idtipoproduto`
--   `familiaproduto`
--       `familiaprodutos` -> `idfproduto`
--   `idfornecedor`
--       `fornecedores` -> `idfornecedor`
--

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`idproduto`, `familiaproduto`, `tipoproduto`, `idfornecedor`, `idfabrico`, `codigo`, `nome`, `descricao`, `quantidade`, `contrastaria`, `preco`, `pvp`, `customedio`, `feitio`, `feitiograma`, `cotacao`, `gaveta`, `tempo`, `peso`) VALUES
(7, 1, 1, NULL, NULL, 'MOL', '', 'awdawda', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, '120', 120.3),
(10, 1, 1, NULL, 0, 'XVV', NULL, 'Molde para brinco de cristal', 0, NULL, 0, 0, 0, 0, 0, 0, 1, '120', 2),
(11, NULL, NULL, NULL, NULL, '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(12, NULL, NULL, NULL, NULL, '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(13, 1, 1, NULL, NULL, 'PAI', NULL, 'Exemplo do molde pai a funcionar :)', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, '120', 23);

-- --------------------------------------------------------

--
-- Estrutura da tabela `profissoes`
--
-- Criação: 20-Jan-2021 às 15:49
--

CREATE TABLE `profissoes` (
  `idprofissao` int(11) NOT NULL,
  `codigo` varchar(6) NOT NULL,
  `nome` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `profissoes`:
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `servicos`
--
-- Criação: 17-Fev-2021 às 12:33
--

CREATE TABLE `servicos` (
  `idservico` int(11) NOT NULL,
  `idfornecedor` int(11) NOT NULL,
  `idunidade` int(11) NOT NULL,
  `alcunha` int(11) NOT NULL,
  `nomeservico` int(11) NOT NULL,
  `custo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- RELACIONAMENTOS PARA TABELAS `servicos`:
--   `idunidade`
--       `unidades` -> `IDUnidade`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `stock`
--
-- Criação: 20-Jan-2021 às 15:49
--

CREATE TABLE `stock` (
  `stockid` int(11) NOT NULL,
  `produtoid` int(11) NOT NULL,
  `quantidade` int(11) NOT NULL,
  `adicionadoqd` varchar(100) NOT NULL,
  `removidoqd` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- RELACIONAMENTOS PARA TABELAS `stock`:
--   `produtoid`
--       `produtos` -> `idproduto`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tipoproduto`
--
-- Criação: 17-Fev-2021 às 11:58
--

CREATE TABLE `tipoproduto` (
  `idtipoproduto` int(11) NOT NULL,
  `codigo` varchar(5) NOT NULL,
  `descricao` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `tipoproduto`:
--

--
-- Extraindo dados da tabela `tipoproduto`
--

INSERT INTO `tipoproduto` (`idtipoproduto`, `codigo`, `descricao`) VALUES
(1, 'MOL', 'Molde'),
(2, 'BRC', 'Brinco');

-- --------------------------------------------------------

--
-- Estrutura da tabela `unidades`
--
-- Criação: 20-Jan-2021 às 15:49
--

CREATE TABLE `unidades` (
  `IDUnidade` int(11) NOT NULL,
  `indice` varchar(10) NOT NULL,
  `descricao` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `unidades`:
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `__efmigrationshistory`
--
-- Criação: 20-Jan-2021 às 17:08
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELACIONAMENTOS PARA TABELAS `__efmigrationshistory`:
--

--
-- Extraindo dados da tabela `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20210120165606_identity', '3.1.10');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `administracao`
--
ALTER TABLE `administracao`
  ADD PRIMARY KEY (`Dia`);

--
-- Índices para tabela `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Índices para tabela `aspnetroles`
--
ALTER TABLE `aspnetroles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Índices para tabela `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Índices para tabela `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Índices para tabela `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Índices para tabela `aspnetusers`
--
ALTER TABLE `aspnetusers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Índices para tabela `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Índices para tabela `bancos`
--
ALTER TABLE `bancos`
  ADD PRIMARY KEY (`idbanco`);

--
-- Índices para tabela `classificacaoprodutos`
--
ALTER TABLE `classificacaoprodutos`
  ADD PRIMARY KEY (`IDClassificacao`);

--
-- Índices para tabela `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`idcliente`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices para tabela `codigopostal`
--
ALTER TABLE `codigopostal`
  ADD PRIMARY KEY (`idcodigopostal`);

--
-- Índices para tabela `colaboradores`
--
ALTER TABLE `colaboradores`
  ADD PRIMARY KEY (`idcolaborador`),
  ADD KEY `idprofissao` (`idprofissao`),
  ADD KEY `idservico` (`idservico`);

--
-- Índices para tabela `encomendas`
--
ALTER TABLE `encomendas`
  ADD PRIMARY KEY (`idencomenda`),
  ADD KEY `idproduto` (`produtoid`),
  ADD KEY `idfabrico` (`idfabrico`);

--
-- Índices para tabela `fabrico`
--
ALTER TABLE `fabrico`
  ADD PRIMARY KEY (`idfabrico`);

--
-- Índices para tabela `familiaprodutos`
--
ALTER TABLE `familiaprodutos`
  ADD PRIMARY KEY (`idfproduto`),
  ADD KEY `idunidade` (`idunidade`);

--
-- Índices para tabela `faturas`
--
ALTER TABLE `faturas`
  ADD PRIMARY KEY (`faturaid`),
  ADD KEY `idfornecedor` (`idfornecedor`,`produtoid`),
  ADD KEY `produtoid` (`produtoid`);

--
-- Índices para tabela `fornecedores`
--
ALTER TABLE `fornecedores`
  ADD PRIMARY KEY (`idfornecedor`),
  ADD KEY `idbanco` (`idbanco`),
  ADD KEY `idcodigopostal` (`idcodigopostal`);

--
-- Índices para tabela `materias`
--
ALTER TABLE `materias`
  ADD PRIMARY KEY (`idmateria`);

--
-- Índices para tabela `modelos`
--
ALTER TABLE `modelos`
  ADD PRIMARY KEY (`idmodelo`),
  ADD KEY `idmateria` (`idmateria`,`idservicos`),
  ADD KEY `idservicos` (`idservicos`),
  ADD KEY `produtoidf` (`produtoidf`),
  ADD KEY `idmolde` (`idmolde`);

--
-- Índices para tabela `molde`
--
ALTER TABLE `molde`
  ADD PRIMARY KEY (`idmolde`),
  ADD KEY `idfproduto` (`idfproduto`);

--
-- Índices para tabela `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`idproduto`),
  ADD KEY `familiaproduto` (`familiaproduto`),
  ADD KEY `produtos_ibfk_2` (`tipoproduto`),
  ADD KEY `idfornecedor` (`idfornecedor`),
  ADD KEY `idfabrico` (`idfabrico`);

--
-- Índices para tabela `profissoes`
--
ALTER TABLE `profissoes`
  ADD PRIMARY KEY (`idprofissao`);

--
-- Índices para tabela `servicos`
--
ALTER TABLE `servicos`
  ADD PRIMARY KEY (`idservico`),
  ADD KEY `idfornecedor` (`idfornecedor`),
  ADD KEY `idunidade` (`idunidade`);

--
-- Índices para tabela `stock`
--
ALTER TABLE `stock`
  ADD PRIMARY KEY (`stockid`),
  ADD KEY `produtoid` (`produtoid`);

--
-- Índices para tabela `tipoproduto`
--
ALTER TABLE `tipoproduto`
  ADD PRIMARY KEY (`idtipoproduto`),
  ADD UNIQUE KEY `CodigoUnico` (`codigo`);

--
-- Índices para tabela `unidades`
--
ALTER TABLE `unidades`
  ADD PRIMARY KEY (`IDUnidade`);

--
-- Índices para tabela `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `bancos`
--
ALTER TABLE `bancos`
  MODIFY `idbanco` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `classificacaoprodutos`
--
ALTER TABLE `classificacaoprodutos`
  MODIFY `IDClassificacao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `clientes`
--
ALTER TABLE `clientes`
  MODIFY `idcliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT de tabela `encomendas`
--
ALTER TABLE `encomendas`
  MODIFY `idencomenda` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `faturas`
--
ALTER TABLE `faturas`
  MODIFY `faturaid` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `fornecedores`
--
ALTER TABLE `fornecedores`
  MODIFY `idfornecedor` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `materias`
--
ALTER TABLE `materias`
  MODIFY `idmateria` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `modelos`
--
ALTER TABLE `modelos`
  MODIFY `idmodelo` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `molde`
--
ALTER TABLE `molde`
  MODIFY `idmolde` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `produtos`
--
ALTER TABLE `produtos`
  MODIFY `idproduto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de tabela `profissoes`
--
ALTER TABLE `profissoes`
  MODIFY `idprofissao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `stock`
--
ALTER TABLE `stock`
  MODIFY `stockid` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tipoproduto`
--
ALTER TABLE `tipoproduto`
  MODIFY `idtipoproduto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `unidades`
--
ALTER TABLE `unidades`
  MODIFY `IDUnidade` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `colaboradores`
--
ALTER TABLE `colaboradores`
  ADD CONSTRAINT `colaboradores_ibfk_1` FOREIGN KEY (`idprofissao`) REFERENCES `profissoes` (`idprofissao`),
  ADD CONSTRAINT `colaboradores_ibfk_2` FOREIGN KEY (`idservico`) REFERENCES `servicos` (`idservico`);

--
-- Limitadores para a tabela `encomendas`
--
ALTER TABLE `encomendas`
  ADD CONSTRAINT `encomendas_ibfk_2` FOREIGN KEY (`produtoid`) REFERENCES `produtos` (`idproduto`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `encomendas_ibfk_3` FOREIGN KEY (`idfabrico`) REFERENCES `fabrico` (`idfabrico`);

--
-- Limitadores para a tabela `familiaprodutos`
--
ALTER TABLE `familiaprodutos`
  ADD CONSTRAINT `familiaprodutos_ibfk_1` FOREIGN KEY (`idunidade`) REFERENCES `unidades` (`IDUnidade`);

--
-- Limitadores para a tabela `faturas`
--
ALTER TABLE `faturas`
  ADD CONSTRAINT `faturas_ibfk_1` FOREIGN KEY (`idfornecedor`) REFERENCES `fornecedores` (`idfornecedor`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `faturas_ibfk_2` FOREIGN KEY (`produtoid`) REFERENCES `produtos` (`idproduto`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `fornecedores`
--
ALTER TABLE `fornecedores`
  ADD CONSTRAINT `fornecedores_ibfk_1` FOREIGN KEY (`idbanco`) REFERENCES `bancos` (`idbanco`),
  ADD CONSTRAINT `fornecedores_ibfk_2` FOREIGN KEY (`idcodigopostal`) REFERENCES `codigopostal` (`idcodigopostal`);

--
-- Limitadores para a tabela `modelos`
--
ALTER TABLE `modelos`
  ADD CONSTRAINT `modelos_ibfk_1` FOREIGN KEY (`idmateria`) REFERENCES `materias` (`idmateria`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `modelos_ibfk_2` FOREIGN KEY (`idservicos`) REFERENCES `servicos` (`idservico`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `modelos_ibfk_3` FOREIGN KEY (`produtoidf`) REFERENCES `familiaprodutos` (`idfproduto`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `modelos_ibfk_4` FOREIGN KEY (`idmolde`) REFERENCES `produtos` (`idproduto`);

--
-- Limitadores para a tabela `produtos`
--
ALTER TABLE `produtos`
  ADD CONSTRAINT `produtos_ibfk_2` FOREIGN KEY (`tipoproduto`) REFERENCES `tipoproduto` (`idtipoproduto`),
  ADD CONSTRAINT `produtos_ibfk_3` FOREIGN KEY (`familiaproduto`) REFERENCES `familiaprodutos` (`idfproduto`),
  ADD CONSTRAINT `produtos_ibfk_5` FOREIGN KEY (`idfornecedor`) REFERENCES `fornecedores` (`idfornecedor`);

--
-- Limitadores para a tabela `servicos`
--
ALTER TABLE `servicos`
  ADD CONSTRAINT `servicos_ibfk_1` FOREIGN KEY (`idunidade`) REFERENCES `unidades` (`IDUnidade`);

--
-- Limitadores para a tabela `stock`
--
ALTER TABLE `stock`
  ADD CONSTRAINT `stock_ibfk_1` FOREIGN KEY (`produtoid`) REFERENCES `produtos` (`idproduto`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
