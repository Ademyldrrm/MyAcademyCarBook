# Renta Car Projesi

Bu proje, araç kiralama işlemlerini yönetmek amacıyla geliştirilmiştir. .NET 6 kullanılarak oluşturulmuş ve SQL Server veritabanını içermektedir.

## Katmanlı Mimarisi

Projede, n katmanlı mimari kullanılmıştır. Her katmanın belirli bir sorumluluğu vardır:

- **Entity Layer:** Bu katmanda, uygulama içinde kullanılan entity sınıfları bulunmaktadır. Veritabanındaki tabloları temsil eder.

- **Data Access Layer:** Veritabanı işlemleri bu katmanda gerçekleştirilir. Entity Framework Code First yaklaşımı kullanılarak, veritabanı otomatik olarak oluşturulur ve güncellenir.

- **Business Layer:** İş kuralları bu katmanda uygulanır. Bu katman, veritabanı işlemlerini kullanarak iş mantığını yönetir.

- **Presentation Layer:** Bu katmanda, kullanıcı arayüzü ve yönlendirme işlemleri bulunur. Sayfalamak için PagedList, hata yönetimi için Fluent Validation kullanılmıştır.

## Kullanılan Kütüphaneler

- **Identity:** Kullanıcı kimlik doğrulama ve yetkilendirme işlemleri için kullanılmıştır.

- **PagedList:** Sayfalama işlemleri için kullanılmıştır.

- **Fluent Validation:** Hata yönetimi için kullanılmıştır.

## Özel Metotlar

Entity katmanında özel metotlar eklenmiştir. Bu metotlar, projenin spesifik ihtiyaçlarına yönelik işlemleri gerçekleştirir.

## Özellikler

- Kullanıcılar, istedikleri kriterlere göre araçları filtreleyebilir ve listeleyebilir.
- Kullanıcılar, araçlara yorum yapabilir ve düşüncelerini paylaşabilir.
- Admin paneli üzerinden tüm işlemler kontrol edilebilir.
- Kullanıcılar, iletişim sayfasından şirket hakkındaki düşüncelerini iletebilirler.

## Çalıştırma Adımları

1. Projeyi bilgisayarınıza klonlayın.
2. Visual Studio veya tercih ettiğiniz başka bir IDE kullanarak projeyi açın.
3. Veritabanını oluşturmak için Package Manager Console veya Terminal'i kullanarak migration'ları uygulayın (`dotnet ef database update`).
4. Projeyi çalıştırın ve tarayıcıda `http://localhost:5000` adresindeki uygulamayı görüntüleyin.

## Teknolojiler

- .NET 6
- Entity Framework
- SQL Server

## Geliştirici

Proje [Adem Yıldırım] tarafından geliştirilmiştir.


