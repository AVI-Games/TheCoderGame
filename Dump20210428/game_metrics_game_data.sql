-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: game_metrics
-- ------------------------------------------------------
-- Server version	8.0.21

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `game_data`
--

DROP TABLE IF EXISTS `game_data`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `game_data` (
  `idgameData` int NOT NULL AUTO_INCREMENT,
  `levelNumber` int NOT NULL,
  `resetsInLevel` int NOT NULL,
  `starsWon` int NOT NULL,
  `timeInLevel` int NOT NULL,
  PRIMARY KEY (`idgameData`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `game_data`
--

LOCK TABLES `game_data` WRITE;
/*!40000 ALTER TABLE `game_data` DISABLE KEYS */;
INSERT INTO `game_data` VALUES (1,1,1,3,23),(2,2,0,3,25),(3,3,0,0,14),(4,3,0,3,26),(5,4,0,1,11),(6,5,0,2,53),(7,6,0,1,5),(8,7,0,3,23),(9,1,1,3,26),(10,2,0,3,452),(11,1,0,3,18),(12,2,0,3,34),(13,1,1,3,55),(14,2,0,3,76),(15,3,0,3,224),(16,4,1,3,97),(17,5,0,3,86),(18,6,0,3,118),(19,7,0,3,74),(20,1,0,3,64),(21,2,0,3,39),(22,3,0,2,135),(23,4,1,2,108),(24,5,0,2,108),(25,6,0,1,35),(26,7,0,3,71),(27,1,0,3,66),(28,2,0,2,111),(29,3,0,1,64),(30,4,0,1,98),(31,5,0,3,172),(32,6,1,1,365),(33,1,1,3,55),(34,1,1,3,104);
/*!40000 ALTER TABLE `game_data` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-04-28 22:15:20
