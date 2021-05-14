using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi. ";
        public static string ProductNameInvalid = "Ürün ismi geçersiz. ";
        public static string MaintenanceTime = "Sistem bakımdadır.";
        public static string ProductListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = " Girilen ürün kategoriye eklenebilecek maksimum ürünü aşıyor.";
        public static string ProductNameAlreadyExists = "Aynı isimde bir başka ürün bulunmaktadır.";
        public static string CategoryLimitExceded = " Kategori sayısı maximum 15 olmalı ";
        public static string AuthorizationDenied = " Bu işlemi yapabilmeniz için yetkiniz bulunmamaktadır.";
        public static string UserRegistered = " Üye olma işlemi tamamlandı.";
        public static string UserNotFound = "Böyle bir kullanıcı bulunamadı.";
        public static string PasswordError = " Girilen şifre hatalıdır.";
        public static string SuccessfulLogin = " Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = " Token oluşturuldu .";
    }
}
