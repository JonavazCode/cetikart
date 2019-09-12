-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 11-09-2019 a las 22:15:40
-- Versión del servidor: 10.4.6-MariaDB
-- Versión de PHP: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `cetikart`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `email` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `nickname` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `user`
--

INSERT INTO `user` (`id`, `email`, `nickname`, `password`) VALUES
(1, 'jonavaz18@gmail.com', 'zokler', 'sunombretieneM'),
(3, 'asdfasdfasdf', 'asdf', '$2y$04$6a.JMOTgsgHJjbqjIe8X.OGgzgiIk2FpKQFwzJz5nBRyLw./8fND.'),
(6, 'jonavaz19@gmail.com', 'zoklerr', '$2y$04$wLvKaWrg83RkCfn/ijhDOOS3zXv45NLDr3qVyPRfiDnryjesnoUE6'),
(8, 'jonavaz10@gmail.com', 'Zoklerrr', '$2y$04$6CSDxwicqSbuu4OcAhVPK.57CN9LjvxvWaMdYla24YKEzthZNURgG'),
(9, 'jonavaz10', 'usuario1', '$2y$04$CJifUM2VsG7hg5HHv98e3uQ9jC5WbHB2i75fidCnQvMBgQG/DnBFW'),
(10, 'usuarioprueba@gmail.com', 'usuarioprueba', '$2y$04$3R3NPmWkh92yWvhjdcfpkuqbVVDxiGReTemiUygiNkjU0xKMj3B7e'),
(11, 'jonavaz18@gmail.commm', 'zoklerrrr', '$2y$04$JB7VBtsSSvRvJSTEWsASQuI7bU5gGkukfkKjja2urSl4ZrnWDSFPS');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nickname` (`nickname`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
