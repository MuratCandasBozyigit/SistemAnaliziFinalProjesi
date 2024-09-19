namespace Ogrenci
{
    public class Class1
    {
        public string OgrenciNo { get; set; }
        public string 
    }
}



//BİR AADET DAHA CODEFİRST PROJE DEVAMKE SARDI CODEFİRST APTAL GİBİ DB İLE UGRASMIYOZ DB İLE NASIL YAPILDIGINI UNUTACAĞIM UTANMASAM


//Okul sınıfı olsun o sınıftaki bilgileri ogrenci bilgisi getirirlikken  ve eklenirken seçilmesi zorunlu olsun aynı şekilde veli eklenmesi ogrencinin tc nosuna göre olsun yani ben veli sınfı oluşturacagım ama veli eklemeyeceğim ogrenci eklenirken veli ismi girilecek ve o isim kendi id si ile kendi tablosunda tutulacak ogrenciye sınıfta kalma geçme durmunu ekle ders ortalamalarını hesaplat sonra ders ortalamaların ortalamasını al eger 50 den kücük ise kalsın ogrenci
//

//Notlar ve ortalamaları için bir tablo olsun ogrenciTcNo ile o tablo calıssın database yorulmasın ve uygulama yavaş calışmasın ve daha az satır kod yazılması için direk sınıfın classLiblarynin içerisinde not1 not2 ... ile ort1 ort2 nasıl yapacaksan not sistemini murtazaacım ona göre düzenle unutma UNUTMAAAA drek ekrandaki yerine gelsin bu bilgi id ile halledersinkankss kendimle başkası gibi konuşmaya başladım MURAT CANDAŞ BOZYİĞİT BNE DELİRECEM neyse Aynı şekilde geçme kalma durumnuda burada ayarla notlar kitaplıgında ort1>=50 ise geçti değil ise kaldı yap ama yukarıyada not alacagım ogrencinin genel kalması için ise mesela tüm ortalaması 50 den küçük ise sınıf tekrarına düşür ogrenciyi sınıftakaldı= true olsun yani


//Is deleted kullan cünkü okuldan cıkan veya bitiren kişinin bilgisini tutmak en mantıklı olanı 




//dersler için kategorileme yap sayısal sozel gibi mesela bölüme göre yada yani bunun için şunları yapmamız lazım ayrı bir sınıfta bölüm ekleme işlemi yapılacak ve bölüm eklenirken en az 1 adet olmak üzere ders eklenmesi gerekecek buradaki eklenen dersler hem bu tabloda hemde kendi tblDersler tablosunda tutulacak 
//Dersler tablosunda dersin açıklaması bulunsun kendi adı ve ıd si bulunsun haftada kaç saat olduğunuda tutabilirsin istersen
//Hazır saati tutmuşken ogrencinin haftada kaç saat ders alabileceğini hesapla 45 saaatten fazla ders alamasın ogrenci haftalık yani şunu demek istiyorum aptal gibi şaşaırmayayım sonrasında ogrenci dersler eklenirken eger ekleeyen kişi yetkili kişi yani derslerin toplam saatini 45 ten fazla olursa hata alsın daha fazla ders ekelyemeszsiniz nedeni toplam saat 45 ten büyükolamaz vs .



//Gerekli Tablolar:

//BASEMODEL

//OGRENCİ
//=>OGRENCİ ADI SOYADI TCNO OGRENCİNO OKULU ALDIGI DERSLER VELİSİ KALMA GECME DURUMU ISDELETED ORTALAMA NOTU ensonekleALDIGI DERS SAATİ

//VELİ
//=>OGLUNUN ADI SOYADI KENDİ ADI SOYADI TEL NO SU 

//NOTLAR
//=>BRİNCİ SINAV İKİNCİ SINAV ORTALAMA GENEL ORTALAMA GENEL ORTALAMAYI DATABASeDE TUT TC NO YA BAGLI OLSUN X TCNONUN GENEL ORTALAMASINI OGRENCİDE GET SET YAP ORADA GECME KALMA DURUMUNU YAZDIR

//OKUL
//=>OKudugu okulun adı şehri semti var ise özelliği

//BÖLÜM-DERSLER
//=>BÖLÜM ADI BÖLÜM AÇIKLAMASI BÖLÜMLE İLGİLİ DERSLER 


//DERS SAAATİ BUNU TABLO YAPMASANDA OLABİLİR Bİ DÜŞÜN EN SON EKLERSİN BUNU ZATEN O KADAR MÜHİM DEĞİL 