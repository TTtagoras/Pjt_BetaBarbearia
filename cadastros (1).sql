-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: 05-Maio-2022 às 11:27
-- Versão do servidor: 5.6.20-log
-- PHP Version: 5.4.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `cadastros`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE IF NOT EXISTS `clientes` (
`ID` int(11) NOT NULL,
  `PrimeiroNome` varchar(20) NOT NULL,
  `UltimoNome` varchar(20) NOT NULL,
  `Telefone` varchar(20) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Senha` varchar(20) NOT NULL
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=22 ;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`ID`, `PrimeiroNome`, `UltimoNome`, `Telefone`, `Email`, `Username`, `Senha`) VALUES
(10, 'er', 'er', '+55 (11) 1 1111-1111', 'dsf', 'qq', 'qq'),
(18, 'dd', 'dd', '+55 (11) 1 1111-1111', 'ddafsadfwqergqegaefgqergqergae', 'ww', 'ww'),
(12, 'fasdf', 'asdf', '+55 (11) 1 1111-1111', 'sh', 'sh', 'sh'),
(13, 'eue', 'sd', '+55 (44) 4 4444-4444', 'ad', 'ad', 'ad'),
(17, 'Asd', 'fhg', '+55 (54) 3 6474-7479', 'nc@gc', 'qwer', 'qwer'),
(15, 'wtgw', 'wrh', '+55 (44) 4 4444-4444', 'hey', 'eh', 'eh'),
(19, 'eue', 'sdfeWF', '+55 (44) 4 4444-4444', 'ad', 'Dg', 'ad'),
(20, 'er', 'er', '+55 (11) 1 1111-1111', 'dsf', 'ee', 'qq'),
(21, 'evandro', 'ribas', '+55 (47) 9 9278-2566', 'evandromagico@gmail.com', 'evandromagico', '123456');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarios`
--

CREATE TABLE IF NOT EXISTS `funcionarios` (
`ID` int(11) NOT NULL,
  `PrimeiroNome` varchar(20) NOT NULL,
  `UltimoNome` varchar(20) NOT NULL,
  `Telefone` varchar(20) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Senha` varchar(20) NOT NULL,
  `Endereco` varchar(50) NOT NULL,
  `NumeroDaCasa` varchar(5) NOT NULL,
  `CEP` varchar(20) NOT NULL
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Extraindo dados da tabela `funcionarios`
--

INSERT INTO `funcionarios` (`ID`, `PrimeiroNome`, `UltimoNome`, `Telefone`, `Email`, `Username`, `Senha`, `Endereco`, `NumeroDaCasa`, `CEP`) VALUES
(2, 'efs', 'sdf', '+55 (11) 1 1111-1111', 'bss', 'ag', 'dfg', 'afg', 'ddfg', 'ag');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clientes`
--
ALTER TABLE `clientes`
 ADD PRIMARY KEY (`ID`), ADD UNIQUE KEY `Username` (`Username`);

--
-- Indexes for table `funcionarios`
--
ALTER TABLE `funcionarios`
 ADD PRIMARY KEY (`ID`), ADD UNIQUE KEY `Username` (`Username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `clientes`
--
ALTER TABLE `clientes`
MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=22;
--
-- AUTO_INCREMENT for table `funcionarios`
--
ALTER TABLE `funcionarios`
MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
