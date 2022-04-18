using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKapsulleme
{
    class Ogrenci
    {
        /*  
         İŞE PUBLİC TÜRÜNDEN DEĞİŞKEN TANIMLAYARAK BAŞLADIM
         BU TANIMLAYIP DEĞER ATADIĞIM DEĞİŞKENİ PROGRAM.CS ÜZERİNDEN WRITELINLE SORUNSUZ YAZDIRDIM
         ANCAK PUBLİC STRİNG TURUNDEN OLAN BU DEĞİŞKENİMİ PRİVATE YAPTIGIM ANDA ERİŞİMİM ENGELLENDİ
         AMA KULLANDIGIM IKI METODLA BEN BU DEĞİŞKENİME ULAŞMAYI BAŞARDIM 
         YANI KAPSÜLLEME YAPTIM
         */


        private string isim;

        //BAHSETTİĞİM IKI METODU OLUŞTURUYRUM 
        // SET DEĞER ATAMAK 
        //GET İSE BU DEĞERİ ALMAK İÇİN KULLANDIĞIM METODLAR OLUYOR

        public void setIsim(string _isim)
        {   
            //isim karmaşası olmaması adına _ simgesini kullandım
            isim = _isim;
        }


        public string getIsim()
        {
            //değerimi döndürdüm 
            return isim;

        }



    }
}
