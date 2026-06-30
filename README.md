# PortfolioProjectNigth

PortfolioProjectNigth, kisisel web sitesi ve admin yonetim panelinden olusan ASP.NET MVC projesidir. Ziyaretciler portfolyo, yetenek, deneyim, egitim, hizmet ve iletisim alanlarini gorur; admin paneli bu icerikleri CRUD ekranlariyla yonetir.

## Ozellikler

- Kisisel tanitim ve portfolyo vitrini
- Hakkimda, yetenek, deneyim, egitim ve hizmet bolumleri
- Referans/testimonial alanlari
- Iletisim formu ve mesaj kutusu
- Admin girisi ve yonetim paneli
- Icerik CRUD ekranlari
- Istatistik ve grafik ekranlari
- Entity Framework DB First yapisi

## Teknolojiler

- ASP.NET MVC 5
- .NET Framework 4.7.2
- Entity Framework 6.2
- SQL Server
- Razor Views
- Bootstrap
- JavaScript
- Chart.js

## Proje Yapisi

```text
PortfolioProjectNigth/
├── PortfolioProjectNigth.sln
└── PortfolioProjectNigth/
    ├── Controllers/     # Admin ve public controllerlar
    ├── Models/          # EF modelleri ve domain siniflari
    ├── Views/           # Razor sayfalari
    ├── App_Start/       # Route, bundle ve filter ayarlari
    ├── Content/         # Stil dosyalari
    └── Scripts/         # JavaScript dosyalari
```

## Kurulum

1. Visual Studio ile `PortfolioProjectNigth.sln` dosyasini acin.
2. NuGet paketlerini restore edin.
3. `Web.config` icindeki SQL Server connection string degerini kendi veritabaniniza gore guncelleyin.
4. EF DB First modeli kullanildigi icin veritabaninin hazir oldugundan emin olun.
5. IIS Express ile projeyi calistirin.

## Gelistirme Notlari

Admin panelinde yeni bir icerik tipi eklemek icin model, controller ve ilgili Razor view dosyalari birlikte eklenmelidir. Grafik ve istatistik ekranlarinda sorgu maliyetine dikkat edilmesi onerilir.
