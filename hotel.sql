-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Дек 16 2015 г., 17:28
-- Версия сервера: 5.5.25
-- Версия PHP: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `hotel`
--

-- --------------------------------------------------------

--
-- Структура таблицы `authorize`
--

CREATE TABLE IF NOT EXISTS `authorize` (
  `ID` int(10) NOT NULL,
  `PASS` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `authorize`
--

INSERT INTO `authorize` (`ID`, `PASS`) VALUES
(1, '123987'),
(2, '666666'),
(3, 'zxcv'),
(4, '12345'),
(5, 'qwerty');

-- --------------------------------------------------------

--
-- Структура таблицы `bills`
--

CREATE TABLE IF NOT EXISTS `bills` (
  `ID` int(10) NOT NULL,
  `Payment_amount` int(10) NOT NULL,
  `Bank_name` varchar(30) NOT NULL,
  `Date_of_leaving` varchar(40) NOT NULL,
  `Custom_ID` int(10) NOT NULL,
  `Paid` varchar(5) NOT NULL,
  UNIQUE KEY `ID` (`ID`),
  KEY `Paid/No` (`Paid`),
  KEY `Paid/No_2` (`Paid`),
  KEY `Custom_ID` (`Custom_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `bills`
--

INSERT INTO `bills` (`ID`, `Payment_amount`, `Bank_name`, `Date_of_leaving`, `Custom_ID`, `Paid`) VALUES
(1, 310, 'Альфа-Банк', '2015-11-25', 1, '+'),
(2, 815, 'Приват Банк', '2015-11-30', 2, '+'),
(3, 210, 'Приват Банк', '2015-10-30', 3, '+');

-- --------------------------------------------------------

--
-- Структура таблицы `clients`
--

CREATE TABLE IF NOT EXISTS `clients` (
  `Passport_number` int(10) NOT NULL,
  `Full_name` varchar(60) NOT NULL,
  `Phone_number` int(20) NOT NULL,
  `Date_of_settlement` varchar(40) NOT NULL,
  `Pledge` varchar(15) NOT NULL,
  `In_Hotel` varchar(5) NOT NULL,
  `Number_ID` int(10) NOT NULL,
  UNIQUE KEY `Passport_number` (`Passport_number`),
  KEY `Number_ID` (`Number_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `clients`
--

INSERT INTO `clients` (`Passport_number`, `Full_name`, `Phone_number`, `Date_of_settlement`, `Pledge`, `In_Hotel`, `Number_ID`) VALUES
(123421, 'вуцву', 235233, '10.12.2015 15:04:27', '32ыв32', '+', 65),
(1234567, 'Демяненко Иван Сергеевич	', 4363432, '2015-11-25', '1000$	', '-', 54),
(2134295, 'Евсеев Артем Сергеевич	', 324234325, '2015-11-20', '1000$	', '+', 54),
(2354621, 'Степаненко Василий Семенович	', 2147483647, '2015-10-23', 'Паспорт', '-', 89),
(3459212, 'Семенов Артем Иванович	', 23432432, '2015-11-24', '400$	', '+', 80),
(6541234, 'Ященко Юрий Викторович	', 23423526, '2015-11-28', '500$	', '+', 89),
(8976512, 'Петров Антон Максимович	', 325325632, '2015-11-15', '500$	', '-', 80),
(32432432, 'Сергиенко Иван Иванович', 43265432, '2015-11-25', '100$', '+', 102);

-- --------------------------------------------------------

--
-- Структура таблицы `custom`
--

CREATE TABLE IF NOT EXISTS `custom` (
  `Number_of_custom` int(10) NOT NULL,
  `Comfort` varchar(30) NOT NULL,
  `Roominess` varchar(30) NOT NULL,
  `Price` int(10) NOT NULL,
  `Additional_services` varchar(150) NOT NULL,
  `Client_ID` int(10) NOT NULL,
  UNIQUE KEY `Number_of_custom` (`Number_of_custom`),
  KEY `Client_ID` (`Client_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `custom`
--

INSERT INTO `custom` (`Number_of_custom`, `Comfort`, `Roominess`, `Price`, `Additional_services`, `Client_ID`) VALUES
(1, 'Стандарт', '1-местний	', 30, 'Ужин в номер (+10$)	', 8976512),
(2, 'Президент-класс', '2-х местний', 150, 'Шампанское(+30$), дополнительное обслуживание(+15$), ужин и завтрак в номер (+20$)	', 1234567),
(3, 'Стандарт', '2-х местний', 35, '-', 2354621),
(4, 'Стандарт', '1-местний	', 30, 'Завтрак в номер (+10$)', 3459212),
(5, 'Стандарт', '2-х местний', 30, '-', 6541234),
(6, 'Президент-класс', '2-х местний', 150, 'Завтрак в номер x2 (+20$)	', 2134295),
(7, 'Полулюкс', '3-х местный ', 62, '-', 123421);

-- --------------------------------------------------------

--
-- Структура таблицы `hotel`
--

CREATE TABLE IF NOT EXISTS `hotel` (
  `Room_number` int(10) NOT NULL,
  `Comfort` varchar(50) NOT NULL,
  `Roominess` varchar(50) NOT NULL,
  `Price` int(20) NOT NULL,
  `Free` varchar(5) NOT NULL,
  UNIQUE KEY `Room_number` (`Room_number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `hotel`
--

INSERT INTO `hotel` (`Room_number`, `Comfort`, `Roominess`, `Price`, `Free`) VALUES
(15, 'Економ-класс', '1-местный', 22, '+'),
(23, 'Люкс', '4-х местный ', 141, '+'),
(54, 'Президент-класс', '2-х местный', 210, '-'),
(65, 'Полулюкс', '3-х местный ', 62, '-'),
(80, 'Стандарт', '1-местный', 44, '-'),
(89, 'Стандарт', '2-х местный', 50, '-'),
(102, 'Економ-класс', '2-х местный', 28, '+');

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `bills`
--
ALTER TABLE `bills`
  ADD CONSTRAINT `bills_ibfk_1` FOREIGN KEY (`Custom_ID`) REFERENCES `custom` (`Number_of_custom`);

--
-- Ограничения внешнего ключа таблицы `clients`
--
ALTER TABLE `clients`
  ADD CONSTRAINT `clients_ibfk_1` FOREIGN KEY (`Number_ID`) REFERENCES `hotel` (`Room_number`);

--
-- Ограничения внешнего ключа таблицы `custom`
--
ALTER TABLE `custom`
  ADD CONSTRAINT `custom_ibfk_1` FOREIGN KEY (`Client_ID`) REFERENCES `clients` (`Passport_number`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
