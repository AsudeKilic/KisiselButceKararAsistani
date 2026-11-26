-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 26 Kas 2026, 19:03:40
-- Sunucu sürümü: 10.11.19-MariaDB
-- PHP Sürümü: 8.5.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `karar_asistani_db`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `giderler`
--

CREATE TABLE `giderler` (
  `GiderID` int(11) NOT NULL,
  `KullaniciID` int(11) NOT NULL,
  `GiderAdi` varchar(100) NOT NULL,
  `GiderTuru` varchar(30) NOT NULL,
  `Tutar` decimal(10,2) NOT NULL,
  `Tarih` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `hedefler`
--

CREATE TABLE `hedefler` (
  `HedefID` int(11) NOT NULL,
  `KullaniciID` int(11) NOT NULL,
  `HedefAdi` varchar(100) NOT NULL,
  `HedefTutar` decimal(10,2) NOT NULL,
  `BirikenTutar` decimal(10,2) NOT NULL DEFAULT 0.00,
  `HedefTarih` datetime NOT NULL,
  `Durum` varchar(30) NOT NULL DEFAULT 'Devam Ediyor'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `istekkarantinasi`
--

CREATE TABLE `istekkarantinasi` (
  `IstekID` int(11) NOT NULL,
  `KullaniciID` int(11) NOT NULL,
  `UrunAdi` varchar(100) NOT NULL,
  `Kategori` varchar(50) NOT NULL,
  `Fiyat` decimal(10,2) NOT NULL,
  `EmekKarsiligiSaat` decimal(10,2) NOT NULL,
  `EklenmeTarihi` datetime NOT NULL DEFAULT current_timestamp(),
  `KarantinaBitisTarihi` datetime NOT NULL,
  `Durum` varchar(30) NOT NULL DEFAULT 'Beklemede'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanicilar`
--

CREATE TABLE `kullanicilar` (
  `KullaniciID` int(11) NOT NULL,
  `KullaniciAdi` varchar(50) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Sifre` varchar(100) NOT NULL,
  `AylikNetMaas` decimal(10,2) NOT NULL,
  `GunlukCalismaSaati` decimal(4,2) NOT NULL,
  `SaatlikKazanc` decimal(10,2) NOT NULL,
  `Rol` varchar(20) NOT NULL DEFAULT 'Kullanici'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `kullanicilar`
--

INSERT INTO `kullanicilar` (`KullaniciID`, `KullaniciAdi`, `Email`, `Sifre`, `AylikNetMaas`, `GunlukCalismaSaati`, `SaatlikKazanc`, `Rol`) VALUES
(1, 'admin', 'admin@ornek.com', '1234', 0.00, 0.00, 0.00, 'Admin'),
(2, 'testuser', 'kullanici@ornek.com', '1234', 0.00, 0.00, 0.00, 'Kullanici');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `giderler`
--
ALTER TABLE `giderler`
  ADD PRIMARY KEY (`GiderID`),
  ADD KEY `KullaniciID` (`KullaniciID`);

--
-- Tablo için indeksler `hedefler`
--
ALTER TABLE `hedefler`
  ADD PRIMARY KEY (`HedefID`),
  ADD KEY `KullaniciID` (`KullaniciID`);

--
-- Tablo için indeksler `istekkarantinasi`
--
ALTER TABLE `istekkarantinasi`
  ADD PRIMARY KEY (`IstekID`),
  ADD KEY `KullaniciID` (`KullaniciID`);

--
-- Tablo için indeksler `kullanicilar`
--
ALTER TABLE `kullanicilar`
  ADD PRIMARY KEY (`KullaniciID`),
  ADD UNIQUE KEY `KullaniciAdi` (`KullaniciAdi`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `giderler`
--
ALTER TABLE `giderler`
  MODIFY `GiderID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Tablo için AUTO_INCREMENT değeri `hedefler`
--
ALTER TABLE `hedefler`
  MODIFY `HedefID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Tablo için AUTO_INCREMENT değeri `istekkarantinasi`
--
ALTER TABLE `istekkarantinasi`
  MODIFY `IstekID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Tablo için AUTO_INCREMENT değeri `kullanicilar`
--
ALTER TABLE `kullanicilar`
  MODIFY `KullaniciID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `giderler`
--
ALTER TABLE `giderler`
  ADD CONSTRAINT `giderler_ibfk_1` FOREIGN KEY (`KullaniciID`) REFERENCES `kullanicilar` (`KullaniciID`) ON DELETE CASCADE;

--
-- Tablo kısıtlamaları `hedefler`
--
ALTER TABLE `hedefler`
  ADD CONSTRAINT `hedefler_ibfk_1` FOREIGN KEY (`KullaniciID`) REFERENCES `kullanicilar` (`KullaniciID`) ON DELETE CASCADE;

--
-- Tablo kısıtlamaları `istekkarantinasi`
--
ALTER TABLE `istekkarantinasi`
  ADD CONSTRAINT `istekkarantinasi_ibfk_1` FOREIGN KEY (`KullaniciID`) REFERENCES `kullanicilar` (`KullaniciID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
