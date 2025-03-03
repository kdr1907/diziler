class Program
{
    static void Main(string[] args)
    {
            //Dizi Tanımlama
        string[] renkler = new string[5];

        string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymun"};

        int[] dizi;
        dizi = new int[5];

        //Dizilere Değer Atama ve Erişim
        renkler[0] = "Mavi";

        dizi[3] = 10;

        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        // Döngülerle dizi kullanımı
        // Klavyeden girilen n tane sayının ortalamasını hesaplayan program

        Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
        int diziUzunlugu = int.Parse(Console.ReadLine());

        int[] sayıDizisi = new int[diziUzunlugu];

        for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.Write("Lütfen {0}. sayıyı giriniz: ",i+1);
            sayıDizisi[i] = int.Parse(Console.ReadLine());
        }

        int toplam = 0;
        foreach (var sayi in sayıDizisi)
        {
            toplam += sayi;
        }

        Console.WriteLine("Ortalama: " + toplam / diziUzunlugu);


        int[] sayiDizisi = {23, 12, 4, 86, 72, 3, 11, 17};



        //array methodları
        Console.WriteLine("**** Sırasız Dizi *****");
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        Console.WriteLine("**** Sıralı Dizi ****");
        Array.Sort(sayiDizisi);

        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        //Clear
        Console.WriteLine("**** Array Clear *******");

        // sayiDizisi elemanlarını kullanarak 2. index ten itibaren 2 tane elemanı 0'lar.
        Array.Clear(sayiDizisi, 2, 2);

        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        //Reverse
        Console.WriteLine("**** Array Reverse *");
        Array.Reverse(sayiDizisi);

        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        //IndexOf
        Console.WriteLine("**** Array IndexOf");
        Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

        //Resize
        Console.WriteLine("**** Array Resize *****");
        
        Array.Resize<int>(ref sayiDizisi, 9);
        sayiDizisi[8] = 99;
        
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
    }

}    