# Kişisel Bütçe ve Karar Asistanı (Personal Budget \& Decision Assistant)

**İstanbul Gelişim Üniversitesi – Meslek Yüksekokulu – Bilgisayar Programcılığı**  
**Ders:** BLP 251 Görsel Programlama I (2026–2027 Güz Dönemi Final Projesi)

## Proje Hakkında

**Kişisel Bütçe ve Karar Asistanı**, kullanıcıların aylık net gelir ve zorunlu sabit giderlerini yönetmelerini, satın almak istedikleri ürünleri kendi saatlik emek değerleriyle karşılaştırarak **3, 7, 14 veya 30 günlük** esnek soğuma karantinasına almalarını ve tasarruf hedeflerini takip etmelerini sağlayan **C# Windows Forms** masaüstü uygulamasıdır.

Uygulama, **Nesne Tabanlı Programlama (OOP)** ilkelerine ve **MVC (Model–View–Controller)** tasarım desenine uygun olarak geliştirilmiş olup veritabanı katmanında **MySQL** kullanmaktadır.

\---

## Temel Özellikler

* **MVC Mimarisi:** `Models`, `Views`, `Controllers` ve `Database` katmanlarıyla ayrıştırılmış modüler yapı.
* **Kimlik Doğrulama ve SMTP E-Posta Entegrasyonu:**

  * Kayıt esnasında otomatik saatlik emek kazancı hesabı (`AylikNetMaas / (GunlukCalismaSaati \* 22)`).
  * `System.Net.Mail` (Gmail SMTP, Port 587, SSL/TLS 1.2) ile 6 haneli e-posta doğrulama kodu gönderimi (`FormDogrulama`).
  * E-posta doğrulamalı şifre sıfırlama modülü (`FormSifremiUnuttum`).
* **Dinamik Kontrol Paneli (Dashboard):** Aylık net maaş, saatlik emek değeri, toplam zorunlu gider, kalan bütçe, karantinadaki tutar, net tasarruf özeti ve son karar hareketleri listesi.
* **Zorunlu Gider Yönetimi (`Giderler`):** Aylık sabit giderler için tam CRUD (Ekleme, Listeleme, Güncelleme, Silme) işlemleri.
* **Esnek Soğuma Karantinası (`IstekKarantinasi`):** Dürtüsel harcamaları önlemek için ürün fiyatının saatlik emek karşılığını hesaplama, **3, 7, 14 veya 30 günlük** bekleme süresi tanımlama ve karar durumu güncelleme (`Beklemede`, `Vazgeçildi`, `Satın Alındı`).
* **Tasarruf Hedefleri (`Hedefler`):** Hedef tutar ve birikim takibi, otomatik tamamlanma yüzdesi hesabı.
* **Rol Bazlı Yetkilendirme (RBAC) ve Yönetim Paneli (`FormAdmin`):** `Admin` ve `Kullanici` rolleri; yöneticilere özel kullanıcı listeleme, ekleme, rol/bilgi güncelleme ve silme ekranı.
* **Hata Yönetimi ve Güvenlik:** SQL Injection koruması için parametreli sorgular (`@parametre`), `try-catch` blokları, `SmtpException` yakalama ve `TryParse` giriş doğrulamaları.

\---

## Test Giriş Bilgileri (Demo Hesaplar)

Veritabanı yedeği (`karar\_asistani\_db.sql`) içe aktarıldıktan sonra uygulamayı doğrudan test etmek için aşağıdaki hazır hesapları kullanabilirsiniz:

|Rol|Kullanıcı Adı|Şifre|E-Posta|Erişim Yetkisi|
|-|-|-|-|-|
|**Yönetici (Admin)**|`admin`|`1234`|`admin@ornek.com`|Tüm modüller + Kullanıcı Yönetimi (Admin Paneli)|
|**Standart Kullanıcı**|`testuser`|`1234`|`kullanici@ornek.com`|Bütçe, Gider, Karantina ve Hedef modülleri|

\---

## Kullanılan Teknolojiler ve Bağımlılıklar

* **Programlama Dili:** C# (.NET Framework 4.7.2 / 4.8)
* **Arayüz Teknolojisi:** Windows Forms (WinForms)
* **Veritabanı:** MySQL (XAMPP / phpMyAdmin)
* **NuGet / Kütüphane Bağımlılıkları:** `MySql.Data` (`MySql.Data.MySqlClient`), `System.Net.Mail`

\---

## Kurulum ve Çalıştırma Adımları

### 1\. Veritabanı Kurulumu (XAMPP / MySQL)

1. **XAMPP Control Panel** üzerinden **Apache** ve **MySQL** servislerini başlatın.
2. Tarayıcıdan `http://localhost/phpmyadmin` adresine girin.
3. Sol menüden **Yeni (New)** seçeneğine tıklayarak **`karar\_asistani\_db`** adında yeni bir veritabanı oluşturun (`utf8mb4\_turkish\_ci`).
4. Oluşturduğunuz `karar\_asistani\_db` veritabanını seçip üst sekmeden **İçe Aktar (Import)** bölümüne geçin ve ana dizinde yer alan **`karar\_asistani\_db.sql`** dosyasını seçerek içe aktarın.

### 2\. Uygulama Yapılandırması ve Çalıştırma

1. Ana klasördeki **`KisiselButceIstekIhtiyac.slnx`** çözüm dosyasını Visual Studio ile açın.
2. Veritabanı bağlantı ayarlarını kontrol etmek için `Database/DbConnection.cs` dosyasını inceleyin (Varsayılan: `Server=localhost;Database=karar\_asistani\_db;Uid=root;Pwd=;`).
3. E-posta gönderim özelliğini canlı test etmek isterseniz `Controllers/UserController.cs` dosyasındaki `DogrulamaKoduGonder` metoduna kendi Gmail adresinizi ve 16 haneli Google Uygulama Şifrenizi girin.
4. Visual Studio'da **Build > Rebuild Solution** işlemini yapıp **Start (F5)** tuşuna basarak uygulamayı başlatın.

\---

## Proje Klasör Yapısı

```text
KisiselButceKararAsistani/
├── KisiselButceIstekIhtiyac/
│   ├── Controllers/
│   │   ├── AdminController.cs
│   │   ├── GiderController.cs
│   │   ├── HedefController.cs
│   │   ├── IstekController.cs
│   │   └── UserController.cs
│   ├── Database/
│   │   └── DbConnection.cs
│   ├── Models/
│   │   ├── Gider.cs
│   │   ├── Hedef.cs
│   │   ├── Istek.cs
│   │   └── User.cs
│   └── Views/
│       ├── FormAdmin.cs
│       ├── FormAna.cs
│       ├── FormDogrulama.cs
│       ├── FormGiris.cs
│       ├── FormHedef.cs
│       ├── FormKarantina.cs
│       ├── FormKayit.cs
│       ├── FormSifremiUnuttum.cs
│       ├── FormYeniIstek.cs
│       └── FormZorunluGider.cs
├── karar\_asistani\_db.sql
├── KisiselButceIstekIhtiyac.slnx
├── .gitignore
└── README.md
```

\---

## Proje Ekibi ve Bağlantılar

* **GitHub Depo Bağlantısı:** `https://github.com/AsudeKilic/KisiselButceKararAsistani`
* **Grup Üyeleri:**

  * `Asude Kılıç`
  * `Irmak Çetiner`
  * `Sudenaz Görmez`