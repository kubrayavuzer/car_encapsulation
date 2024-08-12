using car_encapsulation;

public class Program
{
    public static void Main()
    {
        // Geçerli Kapı Sayısı ile Araba Nesnesi Oluşturma
        araba araba1 = new araba("xx", "y", "Siyah", 4);
        araba1.ArabaBilgileriniGoster();

        // Geçersiz Kapı Sayısı ile Araba Nesnesi Oluşturma
        araba araba2 = new araba("a", "b", "Siyah", 2);
        araba2.ArabaBilgileriniGoster();
    }
}