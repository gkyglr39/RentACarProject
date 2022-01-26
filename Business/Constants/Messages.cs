using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string NoDataFound { get; set; } = "Data bulunamadı";

        public static string SuccessToAdd { get; set; } = "Ekleme Başarılı";

        public static string DataLoaded { get; set; } = "Data yüklendi";

        public static string SuccessToUpdate { get; set; } = "Güncelleme başarılı";

        public static string SuccessToRemove { get; set; } = "Silme başarılı";
        public static string CarNameNotValid { get; set; } = "Araba ismi en az 2 karakter olmalıdır";
        public static string CarIsAlreadyRented { get; set; } = "Araba zaten kiralanmış durumda";
        public static string UserNotFound { get; set; } = "Kullanıcı Bulunamadı";
        public static string PasswordError { get; set; } = "Parola Hatalı";

        public static string DailyPriceCouldNotPlusNumber = "Günlük araba fiyatı eksi bir değer içeremez";

        public static string UserRegistered = "Kullanıcı kayıt edildi";

        public static string AccessTokenCreated = "AccessToken başarıyla oluşturuldu";

        public static string AuthorizeDenied = "Yetkiniz yok";

        public static string UserAlreadyExist { get; set; } = "Kullanıcı zaten mevcut";

        internal static string SuccessToLogin { get; set; } = "Giriş başarılı";
    }
}
