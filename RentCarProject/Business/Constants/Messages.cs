using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added="Eklendi";
        public static string NameInvalid = "İsim Geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string Listed = "Listelendi";
        public static string Deleted = "Silindi";
        public static string Updated = "Güncellendi";
        public static string Error = "Error";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string PasswordError = "Şifre yanlış";

        public static string SuccessfulLogin = "Sisteme giriş başarılı";

        public static string UserAlreadyExist = "Kullanıcı mevcut";

        public static string UserRegistered = "Kullanıcı oluşturuldu";

        public static string AccessTokenCreated = "Access Token oluşturuldu";
    }
}
