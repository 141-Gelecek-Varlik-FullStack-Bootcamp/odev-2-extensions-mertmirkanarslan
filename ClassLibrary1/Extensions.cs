using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace ClassLibrary1
{
    //extension'lar statik olmalı. bu nedenle extension class'ini public static olarak tanimliyoruz
    public static class Extensions
    {
        //extension metodu da statik olmali. ayrica this type_name variable_name yapisi kullaniyoruz.
        public static string KisSaatiUygulamasi(this DateTime dateTime)
        {
            //kis saati uygulamasında saatler 1 saat geriye alinir.
            return dateTime.AddHours(-1).ToLongTimeString();
        }

        //reflection ile tipleri alma
        public static string GetDisplayName(this Enum userType)
        {
            //console app'te bulunan UserTypes enum'inin tipini reflection ile almak icin using ile reflection, linq, kullanilacak data annotationlar eklendi.
            var result = userType.GetType().GetMember(userType.ToString()).First().GetCustomAttributes<DisplayAttribute>().First().Name;
            return result;
        }
    }
}
