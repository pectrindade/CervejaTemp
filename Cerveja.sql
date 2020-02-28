-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           5.5.30 - MySQL Community Server (GPL)
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              10.1.0.5464
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Copiando estrutura para tabela cerveja.adjunto
CREATE TABLE IF NOT EXISTS `adjunto` (
  `CODADJUNTO` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(200) DEFAULT NULL,
  `QUANTIDADE` float DEFAULT NULL,
  `VALOR` float DEFAULT NULL,
  `DATAFAB` datetime DEFAULT NULL,
  `DATAVENC` datetime DEFAULT NULL,
  `DATAENTRADA` datetime DEFAULT NULL,
  `EBC` varchar(200) DEFAULT NULL,
  `OBS` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`CODADJUNTO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- Copiando dados para a tabela cerveja.adjunto: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `adjunto` DISABLE KEYS */;
/*!40000 ALTER TABLE `adjunto` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.brassagem
CREATE TABLE IF NOT EXISTS `brassagem` (
  `CODBRASSAGEM` int(11) NOT NULL AUTO_INCREMENT,
  `CODUSUARIO` int(11) DEFAULT NULL,
  `CODRECEITA` int(11) DEFAULT NULL,
  `DATAINICIAL` datetime DEFAULT NULL,
  `DATAFINAL` datetime DEFAULT NULL,
  `OBS` varchar(200) DEFAULT NULL,
  `STATUSBRASSAGEM` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`CODBRASSAGEM`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cerveja.brassagem: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `brassagem` DISABLE KEYS */;
/*!40000 ALTER TABLE `brassagem` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.equipamento
CREATE TABLE IF NOT EXISTS `equipamento` (
  `CODEQUIPAMENTO` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(50) DEFAULT NULL,
  `DESCRICAO` varchar(50) DEFAULT NULL,
  `OBSEQUIPAMENTO` varchar(50) DEFAULT NULL,
  `QUANTIDADE` int(11) DEFAULT NULL,
  PRIMARY KEY (`CODEQUIPAMENTO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cerveja.equipamento: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `equipamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `equipamento` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.fermentacao
CREATE TABLE IF NOT EXISTS `fermentacao` (
  `CODFERMENTACAO` int(11) NOT NULL AUTO_INCREMENT,
  `CODRECEITA` int(11) DEFAULT NULL,
  `GRAVIDADEFINAL` int(11) DEFAULT NULL,
  PRIMARY KEY (`CODFERMENTACAO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cerveja.fermentacao: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `fermentacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `fermentacao` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.fermentacaorampa
CREATE TABLE IF NOT EXISTS `fermentacaorampa` (
  `CODFERMENTACAORAMPA` int(11) NOT NULL AUTO_INCREMENT,
  `CODFERMENTACAO` int(11) NOT NULL DEFAULT '0',
  `NOME` varchar(50) DEFAULT NULL,
  `TEMPERATURA` int(11) DEFAULT NULL,
  `TEMPO` int(11) DEFAULT NULL,
  PRIMARY KEY (`CODFERMENTACAORAMPA`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- Copiando dados para a tabela cerveja.fermentacaorampa: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `fermentacaorampa` DISABLE KEYS */;
/*!40000 ALTER TABLE `fermentacaorampa` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.fermentacao_item
CREATE TABLE IF NOT EXISTS `fermentacao_item` (
  `CODFERMENTACAO` int(11) NOT NULL DEFAULT '0',
  `CODFERMENTO` int(11) DEFAULT NULL,
  `QUANTIDADE` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cerveja.fermentacao_item: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `fermentacao_item` DISABLE KEYS */;
/*!40000 ALTER TABLE `fermentacao_item` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.fermento
CREATE TABLE IF NOT EXISTS `fermento` (
  `CODFERMENTO` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(255) DEFAULT NULL,
  `ESTILOFERMENTO` varchar(100) DEFAULT NULL,
  `VENCIMENTO` datetime DEFAULT NULL,
  `QUANTIDADEESTOQUE` float DEFAULT NULL,
  PRIMARY KEY (`CODFERMENTO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cerveja.fermento: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `fermento` DISABLE KEYS */;
/*!40000 ALTER TABLE `fermento` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.fervura
CREATE TABLE IF NOT EXISTS `fervura` (
  `CODFERVURA` int(11) NOT NULL AUTO_INCREMENT,
  `CODRECEITA` int(11) DEFAULT NULL,
  `TEMPOFERVURA` int(11) DEFAULT NULL,
  `GRAVIDADEORIGINAL` int(11) DEFAULT NULL,
  PRIMARY KEY (`CODFERVURA`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cerveja.fervura: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `fervura` DISABLE KEYS */;
/*!40000 ALTER TABLE `fervura` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.fervura_adjunto
CREATE TABLE IF NOT EXISTS `fervura_adjunto` (
  `CODFERVURA` int(11) DEFAULT NULL,
  `CODADJUNTO` int(11) DEFAULT NULL,
  `QUANTIDADE` float DEFAULT NULL,
  `TEMPO` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- Copiando dados para a tabela cerveja.fervura_adjunto: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `fervura_adjunto` DISABLE KEYS */;
/*!40000 ALTER TABLE `fervura_adjunto` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.fervura_lupulo
CREATE TABLE IF NOT EXISTS `fervura_lupulo` (
  `CODFERVURA` int(11) DEFAULT NULL,
  `CODLUPULO` int(11) DEFAULT NULL,
  `QUANTIDADE` float DEFAULT NULL,
  `TEMPO` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- Copiando dados para a tabela cerveja.fervura_lupulo: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `fervura_lupulo` DISABLE KEYS */;
/*!40000 ALTER TABLE `fervura_lupulo` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.lupulo
CREATE TABLE IF NOT EXISTS `lupulo` (
  `CODLUPULO` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(200) DEFAULT NULL,
  `TIPOLUPULO` varchar(100) DEFAULT NULL,
  `ALFAACIDO` float DEFAULT NULL,
  `VENCIMENTO` datetime DEFAULT NULL,
  `QUANTIDADEESTOQUE` float DEFAULT NULL,
  PRIMARY KEY (`CODLUPULO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cerveja.lupulo: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `lupulo` DISABLE KEYS */;
/*!40000 ALTER TABLE `lupulo` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.malte
CREATE TABLE IF NOT EXISTS `malte` (
  `CODMALTE` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(200) DEFAULT NULL,
  `QUANTIDADE` float DEFAULT NULL,
  `VALOR` float DEFAULT NULL,
  `DATAFAB` datetime DEFAULT NULL,
  `DATAVENC` datetime DEFAULT NULL,
  `DATAENTRADA` datetime DEFAULT NULL,
  `EBC` varchar(200) DEFAULT NULL,
  `OBS` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`CODMALTE`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cerveja.malte: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `malte` DISABLE KEYS */;
INSERT INTO `malte` (`CODMALTE`, `NOME`, `QUANTIDADE`, `VALOR`, `DATAFAB`, `DATAVENC`, `DATAENTRADA`, `EBC`, `OBS`) VALUES
	(1, 'a', NULL, NULL, NULL, NULL, NULL, NULL, NULL);
/*!40000 ALTER TABLE `malte` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.maturacao
CREATE TABLE IF NOT EXISTS `maturacao` (
  `CODMATURACAO` int(11) NOT NULL AUTO_INCREMENT,
  `CODRECEITA` int(11) DEFAULT NULL,
  PRIMARY KEY (`CODMATURACAO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cerveja.maturacao: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `maturacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `maturacao` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.maturacaorampa
CREATE TABLE IF NOT EXISTS `maturacaorampa` (
  `CODRAMPAMATURACAO` int(11) NOT NULL AUTO_INCREMENT,
  `CODMATURACAO` int(11) DEFAULT NULL,
  `NOME` varchar(50) DEFAULT NULL,
  `TEMPO` int(11) DEFAULT NULL,
  `TEMPERATURA` int(20) DEFAULT NULL,
  PRIMARY KEY (`CODRAMPAMATURACAO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cerveja.maturacaorampa: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `maturacaorampa` DISABLE KEYS */;
/*!40000 ALTER TABLE `maturacaorampa` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.mostura
CREATE TABLE IF NOT EXISTS `mostura` (
  `CODMOSTURA` int(11) NOT NULL AUTO_INCREMENT,
  `CODRECEITA` int(11) DEFAULT NULL,
  `AGUAMOSTURA` float DEFAULT NULL,
  `AGUALAVAGEM` float DEFAULT NULL,
  `GRAVIDADEESPECIFICA` int(11) DEFAULT NULL,
  PRIMARY KEY (`CODMOSTURA`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cerveja.mostura: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `mostura` DISABLE KEYS */;
/*!40000 ALTER TABLE `mostura` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.mosturarampa
CREATE TABLE IF NOT EXISTS `mosturarampa` (
  `CODRAMPAMOSTURA` int(11) NOT NULL AUTO_INCREMENT,
  `CODMOSTURA` int(11) DEFAULT NULL,
  `NOME` varchar(50) DEFAULT NULL,
  `TEMPO` int(11) DEFAULT NULL,
  `TEMPERATURA` int(11) DEFAULT NULL,
  PRIMARY KEY (`CODRAMPAMOSTURA`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cerveja.mosturarampa: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `mosturarampa` DISABLE KEYS */;
/*!40000 ALTER TABLE `mosturarampa` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.receita
CREATE TABLE IF NOT EXISTS `receita` (
  `CODRECEITA` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(100) DEFAULT NULL,
  `DECRICAO` varchar(500) DEFAULT NULL,
  `CERVEJEIRO` varchar(150) DEFAULT NULL,
  `ESTILO` varchar(50) DEFAULT NULL,
  `TIPOBRASSAGEM` int(11) DEFAULT NULL,
  PRIMARY KEY (`CODRECEITA`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cerveja.receita: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `receita` DISABLE KEYS */;
/*!40000 ALTER TABLE `receita` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.receita_adjunto
CREATE TABLE IF NOT EXISTS `receita_adjunto` (
  `CODRECEITA` int(11) DEFAULT NULL,
  `CODADJUNTO` int(11) DEFAULT NULL,
  `QUANTIDADE` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- Copiando dados para a tabela cerveja.receita_adjunto: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `receita_adjunto` DISABLE KEYS */;
/*!40000 ALTER TABLE `receita_adjunto` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.receita_fermento
CREATE TABLE IF NOT EXISTS `receita_fermento` (
  `CODRECEITA` int(11) DEFAULT NULL,
  `CODFERMENTO` int(11) DEFAULT NULL,
  `QUANTIDADE` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- Copiando dados para a tabela cerveja.receita_fermento: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `receita_fermento` DISABLE KEYS */;
/*!40000 ALTER TABLE `receita_fermento` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.receita_lupulo
CREATE TABLE IF NOT EXISTS `receita_lupulo` (
  `CODRECEITA` int(11) DEFAULT NULL,
  `CODLUPULO` int(11) DEFAULT NULL,
  `QUANTIDADE` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- Copiando dados para a tabela cerveja.receita_lupulo: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `receita_lupulo` DISABLE KEYS */;
/*!40000 ALTER TABLE `receita_lupulo` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.receita_malte
CREATE TABLE IF NOT EXISTS `receita_malte` (
  `CODRECEITA` int(11) DEFAULT NULL,
  `CODMALTE` int(11) DEFAULT NULL,
  `QUANTIDADE` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cerveja.receita_malte: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `receita_malte` DISABLE KEYS */;
/*!40000 ALTER TABLE `receita_malte` ENABLE KEYS */;

-- Copiando estrutura para tabela cerveja.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `CODUSUARIO` int(11) NOT NULL AUTO_INCREMENT,
  `LOGIN` varchar(20) DEFAULT NULL,
  `SENHA` varchar(20) DEFAULT NULL,
  `NOME` varchar(50) DEFAULT NULL,
  `TELEFONE` int(11) DEFAULT NULL,
  `EMAIL` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`CODUSUARIO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela cerveja.usuario: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
