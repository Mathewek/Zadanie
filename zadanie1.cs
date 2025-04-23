
using System;
class Kalkulator {
  static void Main() {
    Console.WriteLine("podaj numer działania matematycznego które chcesz wykonac");
    Console.WriteLine("1.Dzielenie");
    Console.WriteLine("2.Mnozenie");
    Console.WriteLine("3.Dodawanie");
    Console.WriteLine("4.Odjemowanie");
    Console.WriteLine("5.Opuszczenie programu");

    int dzialanie = int.Parse(Console.ReadLine());

    while (true)
    {
      if (dzialanie == 1) {
        Console.WriteLine("Wybrano dzielenie");
        Console.WriteLine("Podaj pierwsza liczbe");
        int l1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj druga liczbe");
        int l2 = int.Parse(Console.ReadLine());
         Console.WriteLine("wynik:");
        Console.WriteLine(l1/l2);
        
        
        break;
      }
      else if (dzialanie == 2) {
        Console.WriteLine("Wybrano mnozenie");
        Console.WriteLine("Podaj pierwsza liczbe");
        int l1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj druga liczbe");
        int l2 = int.Parse(Console.ReadLine());
         Console.WriteLine("wynik:");
        Console.WriteLine(l1*l2);
        break;
      }
      else if (dzialanie == 3) {
        Console.WriteLine("Wybrano Dodawanie");
        Console.WriteLine("Podaj pierwsza liczbe");
        int l1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj druga liczbe");
        int l2 = int.Parse(Console.ReadLine());
         Console.WriteLine("wynik:");
        Console.WriteLine(l1+l2);
        break;
      }
      else if (dzialanie == 4) {
        Console.WriteLine("Wybrano odejmowanie");
        Console.WriteLine("Podaj pierwsza liczbe");
        int l1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj druga liczbe");
        int l2 = int.Parse(Console.ReadLine());
         Console.WriteLine("wynik:");
        Console.WriteLine(l1-l2);
        break;
      }
      else if (dzialanie == 5) {
        Console.WriteLine("Opuszczono program");
        break;
      }
      else {
        Console.WriteLine("zły wybor sprubuj ponownie");
        dzialanie = int.Parse(Console.ReadLine());
      }
    }
  }
}
