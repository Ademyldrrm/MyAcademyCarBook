
![Ekran görüntüsü 2023-12-29 201634](https://github.com/Ademyldrrm/MyAcademyCarBook/assets/92265631/28b01349-aa57-4029-a739-7d27b9ceeceb)
![Ekran görüntüsü 2023-12-29 202110](https://github.com/Ademyldrrm/MyAcademyCarBook/assets/92265631/d36b8a17-4d01-4d22-b556-8fff4da1c5da)
![Ekran görüntüsü 2023-12-29 202011](https://github.com/Ademyldrrm/MyAcademyCarBook/assets/92265631/facd47e1-7244-41a4-b270-9fa27ad5b7b0)
![Ekran görüntüsü 2023-12-29 201650](https://github.com/Ademyldrrm/MyAcademyCarBook/assets/92265631/a9ad0b81-1ad5-4e43-bbfd-2f4ca4184635)
![Ekran görüntüsü 2023-12-29 201752](https://github.com/Ademyldrrm/MyAcademyCarBook/assets/92265631/24e74b8f-22d6-4614-b44e-c3c4f7a48178)
![Ekran görüntüsü 2023-12-29 201811](https://github.com/Ademyldrrm/MyAcademyCarBook/assets/92265631/9ff03d38-d286-4915-b7a9-83366e4eea13)
![Ekran görüntüsü 2023-12-29 202142](https://github.com/Ademyldrrm/MyAcademyCarBook/assets/92265631/be1717f9-0f77-4ec6-b98f-3c461b5eda75)
![Ekran görüntüsü 2023-12-29 202203](https://github.com/Ademyldrrm/MyAcademyCarBook/assets/92265631/5240f9b6-dfc3-4244-9c98-2a2f9753a9af)
![Ekran görüntüsü 2023-12-29 202212](https://github.com/Ademyldrrm/MyAcademyCarBook/assets/92265631/d5eae520-c66c-42a1-9f55-fb09b9f8ca81)
![Ekran görüntüsü 2023-12-29 201338](https://github.com/Ademyldrrm/MyAcademyCarBook/assets/92265631/d74ec638-883a-43e2-b24a-9c323a8fd7fe)
![Ekran görüntüsü 2023-12-29 201504](https://github.com/Ademyldrrm/MyAcademyCarBook/assets/92265631/d205f5ef-79a2-4ad4-95aa-1b7ddc180265)
![Ekran görüntüsü 2023-12-29 201517](https://github.com/Ademyldrrm/MyAcademyCarBook/assets/92265631/daa81716-1d9a-4cf3-8a23-b0b639476177)
![Ekran görüntüsü 2023-12-29 201546](https://github.com/Ademyldrrm/MyAcademyCarBook/assets/92265631/ba757daf-7aac-4d02-9fa8-be8d2f825c5f)


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

DataAccess katmanında özel metotlar eklenmiştir. Bu metotlar, projenin spesifik ihtiyaçlarına yönelik işlemleri gerçekleştirir.

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


