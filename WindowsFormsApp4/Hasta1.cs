using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Hasta1
    {
        public string Adi;
        public int Ucret;
        public int DogumYili;
        public string Cinsiyet;

        public int Yas;
        public int IndirimUcrt;

        public void YasHesapla()
        {
            Yas = 2018 - DogumYili;
        }
        public void IndirimliUcretHesapla()
        {
            if (Yas > 65)
            {
                IndirimUcrt = 0;
            }
            else if (Cinsiyet == "Kadın")
            {
                IndirimUcrt = Ucret * 80 / 100;
            }
            else if (Yas < 15) 
            {
                IndirimUcrt = Ucret * 50 / 100;
            } 
            else
            {
                IndirimUcrt = Ucret;
            }
        }
           
            
    }
}
