# _bank_machine_Simulation
Bu proje, temel bankacılık işlemlerini (para yatırma, para çekme, bakiye sorgulama) gerçekleştiren interaktif bir konsol uygulamasıdır. Kullanıcının işlem yaptığı saate göre selamlama yapan dinamik bir yapıya sahiptir.

-->Özellikler
Dinamik Selamlama: Sisteme giriş yapılan saate göre "Günaydın", "Tünaydın" veya "İyi Akşamlar" mesajı verir.

Rastgele Bakiye: Her oturumda Random sınıfı kullanılarak 0 ile 1.000.000 TL arasında başlangıç bakiyesi atanır.

Akıllı Para Çekme: Bakiye yetersiz olduğunda kullanıcıya alternatif seçenekler (Tekrar deneme, ana menü, kart iade) sunan iç içe geçmiş karar yapıları (Nested Switch & If-Else) içerir.

Hata Kontrolü: Bakiyeden fazla para çekme girişimlerini denetler.

-->Kullanılan Yapılar
Proje geliştirilirken şu C# yeteneklerinden faydalanılmıştır:

DateTime.Now ile zaman kontrolü.

Switch-Case ve Nested Switch yapıları.

Random sınıfı ile veri üretimi.

Değişken yönetimi ve aritmetik operatörler.

-->Nasıl Çalıştırılır?
Bilgisayarınızda .NET SDK yüklü olduğundan emin olun.

Projeyi indirin ve Visual Studio ile açın.

F5 tuşuna basarak uygulamayı başlatın.
