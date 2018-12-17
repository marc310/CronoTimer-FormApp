-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 02-Out-2018 às 00:36
-- Versão do servidor: 10.1.34-MariaDB
-- PHP Version: 7.2.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbctimer`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE `clientes` (
  `clienteID` int(11) NOT NULL,
  `nome` varchar(25) NOT NULL,
  `telefone` varchar(20) DEFAULT NULL,
  `celular` varchar(20) DEFAULT NULL,
  `email` varchar(120) DEFAULT NULL,
  `precoHora` varchar(10) DEFAULT NULL,
  `ativo` tinyint(1) DEFAULT NULL COMMENT '1 é verdadeiro e 0 como falso',
  `DataCadastro` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`clienteID`, `nome`, `telefone`, `celular`, `email`, `precoHora`, `ativo`, `DataCadastro`) VALUES
(39, 'Marcio', '(21) 2265-5586', '(21) 3 2468-2625', 'contato@viasign.com.br', '15,62', 0, '2018-09-16 19:41:13'),
(40, 'André Knosel', '(21) 2633-4535', '(21) 9 8888-3532', 'impressao@aksign.com.br', '18,75', NULL, '2018-09-16 19:41:13'),
(41, 'zombie', '(  )     -', '(21) 2 6665-4666', 'zb@hotmail.com', '25,00', NULL, '2018-09-18 20:14:15');

-- --------------------------------------------------------

--
-- Estrutura da tabela `fatura`
--

CREATE TABLE `fatura` (
  `IDFat` int(11) NOT NULL,
  `clienteFatura` int(11) NOT NULL,
  `dataEmissao` date NOT NULL,
  `dataVencimento` date NOT NULL,
  `totalFatura` varchar(11) NOT NULL,
  `pago` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `itenspagamento`
--

CREATE TABLE `itenspagamento` (
  `IDItens` int(11) NOT NULL,
  `idFatura` int(11) NOT NULL,
  `valorPag` varchar(11) NOT NULL,
  `descricaoPag` varchar(140) DEFAULT NULL,
  `dataPagamento` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `itensparcial`
--

CREATE TABLE `itensparcial` (
  `IDItens` int(11) NOT NULL,
  `idTrabalho` int(11) NOT NULL,
  `parcial` time NOT NULL,
  `notaParcial` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `itenstrabalho`
--

CREATE TABLE `itenstrabalho` (
  `idTrabalho` int(11) NOT NULL,
  `nota` varchar(140) DEFAULT NULL,
  `data` varchar(15) NOT NULL,
  `inicio` varchar(14) NOT NULL,
  `final` varchar(14) NOT NULL,
  `projetoID` int(11) NOT NULL,
  `tarefas` int(11) NOT NULL,
  `horas` varchar(10) DEFAULT NULL,
  `horaInt` varchar(10) DEFAULT NULL,
  `rendimento` varchar(20) DEFAULT NULL,
  `faturado` tinyint(1) NOT NULL COMMENT '1 é verdadeiro e 0 como falso',
  `idFaturaItem` int(11) DEFAULT NULL COMMENT 'identificador com ID da fatura referente'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `itenstrabalho`
--

INSERT INTO `itenstrabalho` (`idTrabalho`, `nota`, `data`, `inicio`, `final`, `projetoID`, `tarefas`, `horas`, `horaInt`, `rendimento`, `faturado`, `idFaturaItem`) VALUES
(74, 'aham foi mermo', '21/09/2018', '22:49:14', '23:49:17', 9, 3, '01:00:03', '1,00', '18,77', 1, 0),
(79, 'foi mermo', '22/09/2018', '00:01:06', '01:01:13', 9, 4, '01:00:07', '1,00', '18,79', 1, 0),
(95, 'ih ta massa, partiu proximo passo', '22/09/2018', '01:43:23', '01:43:48', 9, 1, '00:00:25', '0,01', '0,13', 1, 0),
(101, 'novo teste de campo', '20/09/2018', '17:23:17', '21:23:22', 9, 1, '04:00:05', '4,00', '75,03', 0, 0),
(102, 'nova parte ae', '22/09/2018', '20:31:24', '21:31:29', 9, 1, '01:00:05', '1,00', '18,78', 0, 0),
(103, '', '30/09/2018', '20:32:31', '21:32:33', 9, 1, '01:00:02', '1,00', '18,76', 0, 0),
(105, 'vamo la', '30/09/2018', '20:35:13', '21:35:17', 9, 1, '01:00:04', '1,00', '18,77', 0, 0),
(115, 'agora foi muleeeek!', '30/09/2018', '21:20:13', '22:20:19', 12, 2, '01:00:06', '1,00', '25,04', 1, 0),
(118, '', '30/09/2018', '21:23:26', '22:23:31', 12, 2, '01:00:05', '1,00', '25,03', 1, 0),
(121, '', '20/09/2018', '12:28:00', '22:28:02', 12, 2, '10:00:02', '10,00', '250,01', 0, 0),
(123, '', '30/09/2018', '21:28:21', '22:28:26', 12, 2, '01:00:05', '1,00', '25,03', 0, 0),
(131, 'novo começo ', '30/09/2018', '11:57:23', '22:57:36', 12, 4, '02:00:13', '2,00', '50,09', 0, 0),
(135, 'teste 01, podendo ser alterado logo em seguida', '20/09/2018', '00:23:11', '00:23:57', 15, 2, '00:00:46', '0,01', '0,20', 0, 0),
(136, 'e tambem continuado, ótimo!', '01/09/2018', '00:24:22', '02:24:29', 15, 2, '02:00:07', '2,00', '31,27', 0, 0),
(137, 'iniciado e complicado mas nada disseminado', '01/10/2018', '00:20:19', '01:20:40', 13, 3, '01:00:21', '1,01', '18,86', 1, 0),
(138, '', '01/10/2018', '01:59:07', '03:59:13', 13, 3, '02:00:06', '2,00', '37,53', 0, 0),
(139, '', '01/10/2018', '04:00:12', '04:00:21', 14, 3, '00:00:09', '0,00', '0,06', 1, 0),
(140, '', '01/10/2018', '03:04:59', '05:05:05', 15, 4, '02:00:06', '2,00', '31,27', 0, 0),
(141, 'tecnicamente otimo', '01/10/2018', '01:22:39', '04:23:02', 15, 2, '03:00:23', '3,01', '46,96', 0, 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `projetos`
--

CREATE TABLE `projetos` (
  `idProj` int(11) NOT NULL,
  `nomeProj` varchar(25) NOT NULL,
  `descricaoProj` varchar(75) DEFAULT NULL,
  `precoProj` varchar(10) DEFAULT NULL,
  `clienteID` int(11) DEFAULT NULL,
  `nomeCliente` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `projetos`
--

INSERT INTO `projetos` (`idProj`, `nomeProj`, `descricaoProj`, `precoProj`, `clienteID`, `nomeCliente`) VALUES
(9, 'Loja 2A', 'E-Commerce de materiais Gráficos', '1800,00', 40, 'André Knosel'),
(12, 'Zumbizando', 'funciona mesmo', '250,00', 41, NULL),
(13, 'Adao', 'top', '325,50', 40, NULL),
(14, 'zumbizesco', 'zubizeração', '300,00', 41, NULL),
(15, 'Viasign', '', '250,00', 39, NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tarefas`
--

CREATE TABLE `tarefas` (
  `idTar` int(11) NOT NULL,
  `nomeTar` varchar(50) NOT NULL,
  `descricaoTar` varchar(140) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tarefas`
--

INSERT INTO `tarefas` (`idTar`, `nomeTar`, `descricaoTar`) VALUES
(1, 'Desenvolvimento', 'Criação de Soluções Específicas'),
(2, 'Layouts', 'Criação de Arte Final'),
(3, 'Website', 'Criação de Página Web'),
(4, 'Atualização de Software', 'S-GPro v 2.0.1');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`clienteID`);

--
-- Indexes for table `fatura`
--
ALTER TABLE `fatura`
  ADD PRIMARY KEY (`IDFat`),
  ADD KEY `fk_clienteF` (`clienteFatura`) USING BTREE;

--
-- Indexes for table `itenspagamento`
--
ALTER TABLE `itenspagamento`
  ADD PRIMARY KEY (`IDItens`),
  ADD KEY `fk_idFatura` (`idFatura`) USING BTREE;

--
-- Indexes for table `itensparcial`
--
ALTER TABLE `itensparcial`
  ADD PRIMARY KEY (`IDItens`),
  ADD KEY `fk_idTrabalho` (`idTrabalho`);

--
-- Indexes for table `itenstrabalho`
--
ALTER TABLE `itenstrabalho`
  ADD PRIMARY KEY (`idTrabalho`),
  ADD KEY `fk_projetos` (`projetoID`),
  ADD KEY `fk_idItemFatura` (`idFaturaItem`),
  ADD KEY `fk_tarefas` (`tarefas`);

--
-- Indexes for table `projetos`
--
ALTER TABLE `projetos`
  ADD PRIMARY KEY (`idProj`),
  ADD KEY `fk_clienteProj` (`clienteID`);

--
-- Indexes for table `tarefas`
--
ALTER TABLE `tarefas`
  ADD PRIMARY KEY (`idTar`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `clientes`
--
ALTER TABLE `clientes`
  MODIFY `clienteID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT for table `itenspagamento`
--
ALTER TABLE `itenspagamento`
  MODIFY `IDItens` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `itensparcial`
--
ALTER TABLE `itensparcial`
  MODIFY `IDItens` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `itenstrabalho`
--
ALTER TABLE `itenstrabalho`
  MODIFY `idTrabalho` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=142;

--
-- AUTO_INCREMENT for table `projetos`
--
ALTER TABLE `projetos`
  MODIFY `idProj` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `tarefas`
--
ALTER TABLE `tarefas`
  MODIFY `idTar` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `fatura`
--
ALTER TABLE `fatura`
  ADD CONSTRAINT `cfk_clienteF` FOREIGN KEY (`clienteFatura`) REFERENCES `clientes` (`clienteID`);

--
-- Limitadores para a tabela `itenspagamento`
--
ALTER TABLE `itenspagamento`
  ADD CONSTRAINT `cPag_fk_idFatura` FOREIGN KEY (`idFatura`) REFERENCES `fatura` (`IDFat`);

--
-- Limitadores para a tabela `itensparcial`
--
ALTER TABLE `itensparcial`
  ADD CONSTRAINT `cfk_idTrabalho` FOREIGN KEY (`idTrabalho`) REFERENCES `itenstrabalho` (`idTrabalho`);

--
-- Limitadores para a tabela `itenstrabalho`
--
ALTER TABLE `itenstrabalho`
  ADD CONSTRAINT `cfk_projetos` FOREIGN KEY (`projetoID`) REFERENCES `projetos` (`idProj`),
  ADD CONSTRAINT `cfk_tarefas` FOREIGN KEY (`tarefas`) REFERENCES `tarefas` (`idTar`);

--
-- Limitadores para a tabela `projetos`
--
ALTER TABLE `projetos`
  ADD CONSTRAINT `cfk_clienteProj` FOREIGN KEY (`clienteID`) REFERENCES `clientes` (`clienteID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
