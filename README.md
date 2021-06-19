
![github-small](https://github.com/Emrehan-Aydin/Borsa-projesi/blob/master/logo.png?raw=true)
# Borsa Projesi

* Projemizin içeriği, Borsa yönetim sistemi similasyonu diyebiliriz. Günümüz borsa sistemlerin temel yapısını kurup ve alım satım emirlerinin yönetilmesi için küçük bir algoritmadan oluşmakta.
Yerel bir Database içerisinde çalışan bir program geliştirdik.

## Projemiz Back-End yapısı 

 * Projemiz .NetCore Mimarisi ile tasarlandı ve katmanlı mimari prensiplerinden yararlanılarak oluşturulmuştur.

## Projemiz bünyesinde bulundurduğumuz seneryolar ;
* Sisteme Kayıt Olabilme.
* Sisteme ( Kullanıcı - Yönetici ) Giriş Yapabilme.
* Sisteme Bakiye (Farklı birimler desteklemektedir.) Eklemek.
* Sisteme Ürün Ekleme.
* Ürün Alım ve Satım Emri Verebilmek.
* Alım ve Satım Emirlerini Geri Alabilmek.
* Ürün ve Bakiye Onay Sistemi (Yönetici izni gerektir.)

## Kullanıcı Arayüzü
   Program içerisindeki tüm arayüz görüntüleri ve işlevlerine bakalım.

  ### Giriş Formu
    Programı ilk çalıştırdığımızda karşılaşacağımız form

![image](https://user-images.githubusercontent.com/78824631/118274450-d2a11700-b4cd-11eb-9f80-63aadf1a912f.png)


  ### Kayıt Ol Formu
     Kullanıcılar bu form üzerinden gerekli bilgileri girerek kayıt olabilecekler. 

![image](https://user-images.githubusercontent.com/78824631/118274576-f82e2080-b4cd-11eb-8a28-551c85b98a67.png)

  ### Kullanıcı Anasayfa Formu
     Kullanıcı olarak giriş yaptığımızda karşılaşacağımız form. Buradan Kullanıcılar Tüm metotlara erişebilmektedir.
     (Alım Emri, Satım Emri , Bakiye Ekleme, Ürün Ekleme...)

![image](https://user-images.githubusercontent.com/78824631/122639303-c11ce180-d101-11eb-8702-a0a0e9d2bc82.png)

  ### Bakiye Ekleme Formu
     Sistem TL üzerinden çalışmaktadır. 
     Seçilen herhangi bir birim WEB üzerinden anlık birim fiyatını TL olarak çevirir ve bakiye ekleme İsteği gönderebilir.

![image](https://user-images.githubusercontent.com/78824631/122639341-f7f2f780-d101-11eb-8604-a575750eaa3b.png)

  ### Ürün Ekleme Formu
     Kullanıcı kendi stoğuna seçimlerini yapıp miktar belirterek İstek gönderebilir.

![image](https://user-images.githubusercontent.com/78824631/118274989-80acc100-b4ce-11eb-856e-f3684c9e4eed.png)

  ### İşlemde Olan Ürün Alım ve Satım Emir Formu
     Kullanıcılar Alım ve Satım Emirlerini geri çekebilmektedir.
     Listede yazan Stok bilgisi Kadar Ürün geri ALınabilmektedir.

![image](https://user-images.githubusercontent.com/78824631/118275459-1ba59b00-b4cf-11eb-8364-2876e5170c7c.png)
  
  ### Kullanıcı Rapor Formu
     Kullanıcılar Alım ve Satım Geçmişlerini Zamana, İşleme (Alım,Satım veya her ikisi) olarak filtreleyip
     Önizleyebilirler ve PDF olarak çıktı alabilirler.

![image](https://user-images.githubusercontent.com/78824631/122639364-21138800-d102-11eb-88ed-bd3f5f2ffd18.png)
  ### Admin Anasayfa Formu
     Sol Taraftaki Menüyü Kullanarak İstenilen Bilgileri Listeyebilirler.

![image](https://user-images.githubusercontent.com/78824631/118275926-b900cf00-b4cf-11eb-8a56-a2bafc051df9.png)

  ### Admin Bakiye Onay Sayfası
     İlgili Satırın Herhangi bir Elamanına Tıklayarak Onayla Butonuna Tıklayarak Onaylayabilirler.
Örn. Listenin Seçili 1. Satırı.

![image](https://user-images.githubusercontent.com/78824631/118276543-725fa480-b4d0-11eb-9700-9dc00192fd01.png)

  ### Admin Ürün Onay Sayfası
     İlgili Satırın Herhangi bir Elamanına Tıklayarak Onayla Butonuna Tıklayarak Onaylayabilirler.
Örn. Listenin Seçili 1. Satırı.

![image](https://user-images.githubusercontent.com/78824631/118276922-e26e2a80-b4d0-11eb-9142-b63d827c2de8.png)
