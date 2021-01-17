using System;
using System.Text;

namespace PIII_Kol3
{
    class Program
    {
            string UsuwaczXML(string tekst)
            {
            //StringBuilder.Remove(13, 4);
            return tekst;
            }
        static void Main(string[] args)
        {
            var data = new DateTime(2021,1,17);
            double wplata = 3000;
            
            void ObliczSubskrybcje(DateTime data, double wplata)
            {
                int iloscMiesiecy = int.Parse(Math.Floor(wplata / 34.99).ToString());
                double reszta = wplata - (iloscMiesiecy * 34.99);
                var pozostalailoscmiesiecy = data.AddMonths(iloscMiesiecy);
                Console.WriteLine(reszta);
                Console.WriteLine($"zostalo {iloscMiesiecy} miesiecy");
            }
            ObliczSubskrybcje(data, wplata);
            
            string text = "jakis tekst <XML>";
            if (text.Contains("<") & text.Contains(">"))
            {
                //UsuwaczXML(text);
            }

        }
    }
}
