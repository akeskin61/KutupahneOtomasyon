# KutupahneOtomasyon

# Proje Nasıl Kullanılır #
Bu uygulama kütüphane sisteminde kullanılmak üzere yazılmıştır, kütüphanedeki kitap ekleme, üye ekleme, ödünç verme, ödünç alma işlevlerini otomatize eden bir uygulamadır. Bu sayede kütüphane sistemleri başarılı bir şekilde otomatize edilir, veri kaybından ve zaman israfından kurtulunur.
 
 2 tip kullanıcı senaryosu vardır bunlardan ilki öğrenci senaryosudur

# Öğrenci Senaryosu #

Kitap kiralamak isteyen öğrenciler kendi kişisel verilerini sisteme yüklerler, bu veriler, tckn, ad, soyad, doğum tarihi gibi bilgilerdir. Daha sonra kitap kiralamak istediklerinde, veritabanından ilgili öğrenci listelenir atama işlemi için kitap alış tarih ve kitap teslim tarih girilir, kitap alış sebebi girilir(ödev, tez, okuma vs..) daha sonra kitap atama işlemi tamamlanır.

Bu işlem tamamlandıktan sonra ilgili kitaptan kütüphanede başka stok yoksa bu kitap kütüphanede artık mevcut olamdığı için başka bir öğrenciye atanamaz.

# Yönetici Senaryosu #

Yönetici ise sisteme öğrenci girişi  ve kitap girişi yapmakla görevlidir aynı zamanda zamanında teslim edilmeyen kitapları ve bu kitabı alan öğrencileri listeler ve ilgili işlemleri yapar.
 
 
 # Proje Kurulumu #
"akeskin61" isimli github hesabının içinden KutupahneOtomasyon adlı respository'deki, "Veritabanı"  ve "Setup ve Exe" klasörlerinin
içeriği bilgisayara download edilmelidir, 
## Veritabanı Kurulumu ##
İnen veritabanı dosyalarından kutuphane.mdf  ve kutuphane.log dosyaları, Sql serverdan ilgili dizine import edilmelidir. 
Bunu yapmak için databases klasörüne sağ tıklanır daha sonra Attach Databases seçeneğine tıklanır gerekli mdf klasörü seçilir ve
import işlemi tamamlanmış olur.

## Proje Setup ##
Githubdan aldığımız setup ve exe klasörünün içindeki, Kutuphane Uygulama adındaki, Windows installer uzantılı dosyaya tıklanır
daha sonra kurulum sihirbazı açılır ve kurulum tamamlanmış olur. Masa üstüne simge oluşturulur ve kullanıcı uygulamayı kullanabilir.
