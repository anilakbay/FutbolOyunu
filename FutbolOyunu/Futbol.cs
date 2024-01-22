using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolOyunu
{
    internal class Futbol
    {
        public Random RastgeleSayi = new Random();
        protected string AdSoyad;
        protected int FormaNo;
        protected int Hiz;
        protected int Dayaniklik;
        protected int Pas;
        protected int Sut;
        protected int Yetenek;
        protected int Kararlik;
        protected int DogalForm;
        protected int Sans;
        public Futbol(string AdSoyad, int FormaNo)
        {
            Hiz = RastgeleSayi.Next(50, 100);
            Dayaniklik = RastgeleSayi.Next(50, 100);
            Pas = RastgeleSayi.Next(50, 100);
            Sut = RastgeleSayi.Next(50, 100);
            Yetenek = RastgeleSayi.Next(50, 100);
            Kararlik = RastgeleSayi.Next(50, 100);
            DogalForm = RastgeleSayi.Next(50, 100);
            Sans = RastgeleSayi.Next(50, 100);
        }
        public Futbol()
        {
            
        }
        public virtual Boolean Pasver()
        {
            int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.3 + Dayaniklik * 0.1 + DogalForm * 0.1 + Sans * 0.2);
            if (PasSkor > 60)
                return true;
            else
                return false;
        }
        public virtual Golvurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.3 + Sut * 0.2 + Kararlik * 0.1 + DogalForm * 0.1 + Hiz * 0.1 + Sans * 0.2);
            if (GolSkor > 70)
                return true;
            else
                return false;
        }
    }
    class Defans : Futbol
    {
        private int PozisyonAlma;
        private int Kafa;
        private int Sicrama;
        public Defans(string AdSoyad, int FormaNo)
        {
            this.AdSoyad = AdSoyad;
            this.FormaNo = FormaNo;
            Hiz = RastgeleSayi.Next(50, 90);
            Dayaniklik = RastgeleSayi.Next(50, 90);
            Pas = RastgeleSayi.Next(50, 90);
            Sut = RastgeleSayi.Next(50, 90);
            Yetenek = RastgeleSayi.Next(50, 90);
            Kararlik = RastgeleSayi.Next(50, 90);
            DogalForm = RastgeleSayi.Next(50, 90);
            Sans = RastgeleSayi.Next(50, 90);
            PozisyonAlma = RastgeleSayi.Next(50, 90);
            Kafa = RastgeleSayi.Next(50, 90);
            Sicrama = RastgeleSayi.Next(50, 90);
        }
        public override Boolean Pasver()
        {
            int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.3 + Dayaniklik * 0.1 + DogalForm * 0.1 + Sans * 0.2);
            if (PasSkor > 60)
                return true;
            else
                return false;
        }
        public virtual Golvurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.3 + Sut * 0.2 + Kararlik * 0.1 + DogalForm * 0.1 + Hiz * 0.1 + Sans * 0.2);
            if (GolSkor > 70)
                return true;
            else
                return false;
        }
    }
    class OrtaSaha : Futbol
    {
        private int UzunTop;
        private int IlkDokunus;
        private int Uretkenlik;
        private int TopSurme;
        private int OzelYetenek;
        public OrtaSaha(string AdSoyad, int FormaNo)
        {
            this.AdSoyad = AdSoyad;
            this.FormaNo = FormaNo;
            Hiz = RastgeleSayi.Next(60, 100);
            Dayaniklik = RastgeleSayi.Next(60, 100);
            Pas = RastgeleSayi.Next(60, 100);
            Sut = RastgeleSayi.Next(60, 100);
            Yetenek = RastgeleSayi.Next(60, 100);
            Kararlik = RastgeleSayi.Next(60, 100);
            DogalForm = RastgeleSayi.Next(60, 90);
            Sans = RastgeleSayi.Next(60, 100);           
        }
        public override Boolean Pasver()
        {
            int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayaniklik * 0.1 + DogalForm * 0.1 + UzunTop * 0.1 + TopSurme * 0.1 + Sans * 0.2);
            if (PasSkor > 60)
                return true;
            else
                return false;
        }
        public virtual Golvurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.3 + Sut * 0.2 + Kararlik * 0.1 + DogalForm * 0.1 + Hiz * 0.1 + Sans * 0.2);
            if (GolSkor > 70)
                return true;
            else
                return false;
        }
    }
    class Forvet : Futbol
    {
        private int Bitircilik;
        private int IlkDokunus;
        private int Kafa;
        private int OzelYetenek;
        private int Sogukkanlilik;
        public Forvet(string AdSoyad, int FormaNo)
        {
            this.AdSoyad = AdSoyad;
            this.FormaNo = FormaNo;
            Hiz = RastgeleSayi.Next(70, 100);
            Dayaniklik = RastgeleSayi.Next(70, 100);
            Pas = RastgeleSayi.Next(70, 100);
            Sut = RastgeleSayi.Next(70, 100);
            Yetenek = RastgeleSayi.Next(70, 100);
            Kararlik = RastgeleSayi.Next(70, 100);
            DogalForm = RastgeleSayi.Next(70, 90);
            Sans = RastgeleSayi.Next(70, 100);
            Bitircilik = RastgeleSayi.Next(70, 100);
            IlkDokunus = RastgeleSayi.Next(70, 100);
            Kafa = RastgeleSayi.Next(70, 100);
            OzelYetenek = RastgeleSayi.Next(70, 100);
            Sogukkanlilik = RastgeleSayi.Next(70, 100);
        }
        public override Boolean Pasver()
        {
            int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayaniklik * 0.1 + DogalForm * 0.1 + Sans * 0.1);
            if (PasSkor > 60)
                return true;
            else
                return false;
        }
        public virtual Golvurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.3 + Sut * 0.2 + Kararlik * 0.1 + DogalForm * 0.1 + Hiz * 0.1 + Sans * 0.2);
            if (GolSkor > 70)
                return true;
            else
                return false;
        }
    }
}
