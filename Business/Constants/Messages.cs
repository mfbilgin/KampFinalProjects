using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string MaintenanceTime ="Sistem bakımda";
        public static string ProductsListed ="Ürünler listelendi";
        public static string ProductCountLimited = "Bir kategoride en fazla 10 adet ürün olabilir.";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductNameError = "Aynı isimde bir ürün zaten var";
        public static string CategoryCountLimitedExceded = "Kategori sayısı 15'i aştığı için ürün eklenemez";
    }
}
