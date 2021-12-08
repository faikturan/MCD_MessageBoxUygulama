using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_MessageBoxUygulama
{
    public class sanalDatabase
    {
        /*
         * İçinde buluduğu sınıftan nesne oluşturulmadan veya hiç bir nesneye referans olmadan kullanılabilen üyeler static olarak nitelendirilir. Metotlar ve alanlar staticolarak tanımlanabilir.

            Bir Sınıf İçerisinde Bulunan Metotların Static Olarak Tanımlanması

            static olma durumunun en bilinen örneği Main() metodudur. Main(), herhangi bir nesne oluşturulmadan önce çağırılması gerektiği için static olarak tanımlanmıştır. Başka bir deyişle de bir nesne metodun üreteceği sonucu etkilemeyecek ise o metot static olarak tanımlanır. Static olarak tanımlanan bir metoda program çalıştığı sürece erişilir, böylece sadece bir metot ile birden çok nesne çağırılır. 
         */
        public static List<Musteri> musteriler { get; set; }

        static sanalDatabase()
        {
            musteriler = new List<Musteri>();
        }

    }
}
