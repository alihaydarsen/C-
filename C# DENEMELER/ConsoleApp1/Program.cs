// // İlk olarak ekrana yazı yazdırma ******
//  Console.WriteLine("merhaba dünya");





// //  // veri tipleri******
//   int sayı=30;
//   double sayı2=20.5;
//   char cinsiyet ='E';
//   String isim ="ali";
//  Boolean varMi =true;






//         // veri tipi dönüşümü***** 
//          Console.WriteLine("1.sayıyı girin");
//          int sayı1 = Convert.ToInt32(Console.ReadLine());
//          Console.WriteLine("2.sayıyı girin");
//          int sayı2 = Convert.ToInt32(Console.ReadLine());
//          int toplam = sayı1 + sayı2;
//          Console.WriteLine("girdiginiz sayıların toplamı "+toplam);





//         //diziler*****
         
//           int[] array = new int[5];
//  string[] haftaGünleri = ["paz", "sal", "çar", "per", "cum", "cmt", "paz"];

//  Console.WriteLine(haftaGünleri[0]);
//  Console.WriteLine(haftaGünleri[1]);
//  Console.WriteLine(haftaGünleri[2]);
//  Console.WriteLine(haftaGünleri[3]);
//  Console.WriteLine(haftaGünleri[4]);
//  Console.WriteLine(haftaGünleri[5]);
//  Console.WriteLine(haftaGünleri[6]);



// // if-else*****
//   int saat = 22;
//        if (saat < 10) 
//        {/         Console.WriteLine("günaydın");
//        } 
//        else if (saat < 20)        {
//          Console.WriteLine("iyi günler.");
//        } 
//        else 
//        {
//          Console.WriteLine("iyi akşamlar");
//        }

// // switch-case*****
//  Console.WriteLine("lütfen bir sayı giriniz:");
//  int sayı=Convert.ToInt32(Console.ReadLine());

//  switch (sayı) 
//  {
//    case 1:
//      Console.WriteLine("pazaertesi");
//      break;
//    case 2:
//      Console.WriteLine("salı");
//      break;
//   case 3:
//      Console.WriteLine("çarşamba");
//     break;
//    case 4:
//      Console.WriteLine("perşembe");
//      break;
//    case 5:
//      Console.WriteLine("cuma");
//      break;
//    case 6:
//      Console.WriteLine("cumartesi");
//      break;
//    case 7:
//      Console.WriteLine("pazar");
//      break;
//  }


// //while******
//     int i = 0;
//  while (i < 5) 
//  {
//   Console.WriteLine(i);
//    i++;
//  }



// //for******
//  for (int i = 0; i <= 10; i = i + 2) 
//  {
//    Console.WriteLine(i);
//  }




// //foreach*****
//  string[] araba = {"Volvo", "BMW", "Ford", "Mazda"};
//  foreach (string i in araba) 
//  {
//    Console.WriteLine(i);
//  }

// //metod*****
//  static void fonk() 
//  {
//    Console.WriteLine("merhaba");
//  }

//  static void Main(string[] args)
//  {
//    fonk();
//    fonk();
//    fonk();
//  }


// // return değerler(fonksiyon)***
//  static int dene(int x, int y) 
//  {
//    return x + y;
//  }

//  static void Main(string[] args)
//  {
//    Console.WriteLine(dene(5, 3));
//  }

// // Outputs 8 (5 + 3)

// // sınıf*****

//  class Araba
//  {
//    string renk;
//    int hız;

//    static void Main(string[] args)
//   {
//      Araba myObj = new Araba();
//     myObj.renk = "kırmızı";
//      myObj.hız= 200;
//      Console.WriteLine(myObj.renk);
//      Console.WriteLine(myObj.hız);
//    }
//    // main metodunu çalıştırırsak bize çıktı olarak 
//    kırmızı
//    200
//    verecektir
//  }


// //Constructors***
//  class Araba
//  {
//    public string model;
//    public string renk;
//    public int yıl;


// //   public Araba(string modelAdı, string modelRenk, int modelYı)
// //   {
// //     model = modelAdı;
// //     renk = modelRenk;
// //     yıl = modelYı;
// //   }

// //   static void Main(string[] args)
// //   {
// //     Araba Ford = new Araba("Mustang", "kırmızı", 1969);
// //     Console.WriteLine(Ford.renk + " " + Ford.yıl+ " " + Ford.model);
// //   }
// // }

// // çıktı kırmızı 1969 Mustang



// // kalıtım******
// class Vehicle  
// {
//   public string brand = "Ford";  
//   public void honk()            
//   {                    
//     Console.WriteLine("süper");
//   }
// }

// class Car : Vehicle  
// {
//   public string modelName = "Mustang";  
// }

// class Program
// {
//   static void Main(string[] args)
//   {
  
//     Car myCar = new Car();

   
//     myCar.honk();

    
//     Console.WriteLine(myCar.brand + " " + myCar.modelName);
//   }
// }
// çıktı olarak süper ve ford mustang vercektir.

