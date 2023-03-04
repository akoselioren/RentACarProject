using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda";
    
        public static string CarAdded = "Araç eklendi";
        public static string CarDeleted = "Araç silindi";
        public static string CarUpdated = "Araç güncellendi";
        public static string CarNameInvalid = "Araç adı yada araç fiyatı geçersiz";
        public static string CarsListed="Araçların tümü listelendi";
        public static string CarByIdListed="Seçilen araç listelendi";
        public static string CarsBrandListed="Araçlar markalarına göre listelendi";
        public static string CarsColorListed="Araçlar renklerine göre listelendi";
        public static string CarDetailsListed="Seçilen aracın detayları listelendi";
        public static string CarCountOfBrandError="Bir Markanın en fazla 10 aracı olabilir.";
        public static string CarNameAlReadyExists="Eklenmek istenen araçdan 1 tane zaten var 2.sini eklemeyiniz.";
        public static string CarNameDescriptionMinLimit= "Dikkat Araba açıklaması minimum 2 karakter olmalıdır.!";
        public static string CarPriceMinLimit= "Dikkat Araba günlük fiyatı 0'dan büyük olmalıdır.!";
        public static string CarBrandSumClosed = "Araç Marka sayısı 15'i geçtigi için artık araç ekleyemiyoruz.";
    
      
        
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandsListed = "Markaların tümü listelendi";
        public static string BrandByIdListed = "Seçilen marka'ya ait tüm araçalar listelendi";
    
      
        
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorsListed = "Renklerin tümü listelendi";
        public static string ColorByIdListed = "Seçilen renkli araçlar listelendi";
        public static string ColorsBrandListed = "Araçlar markalarına göre listelendi";
   


        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UsersListed = "Kullanıcıların tümü listelendi";
        public static string UserByIdListed = "Seçilen kullanıcı listelendi";
   


        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomersListed = "Müşterilerin tümü listelendi";
        public static string CustomerByIdListed = "Seçilen müşteri listelendi";
    


        public static string RentalAdded = "Kiralama işlemi eklendi";
        public static string RentalDeleted = "Kiralama işlemi silindi";
        public static string RentalUpdated = "Kiralama işlemi güncellendi";
        public static string RentalInvalid = "Araç teslim alınmadığından dolayı kiralanamaz.!";
        public static string RentalsListed = "Kiralama işlemlerinin tümü listelendi";
        public static string RentalByIdListed = "Seçilen Kiralama işlemi listelendi";
    


        public static string CarImageAdded = "Araç'a resim eklendi";
        public static string CarImageDeleted = "Araç'ın resmi silindi";
        public static string CarImageUpdated = "Araç'ın resmi güncellendi";
        public static string CarImagesListed = "Araç resimlerinin tümü listelendi";
        public static string CarImageByIdListed = "Seçilen araç'ın resmi listelendi";
        public static string CarImageLimitExceded="Görsel limitini aştığınız için daha fazla görsel eklenemiyor.";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Erişim belirteci oluşturuldu";
    }


}
