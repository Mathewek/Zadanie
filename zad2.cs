using System;
class Konwerter {
  static void Main() {
    Console.WriteLine("podaj co chcesz wykonac");
    Console.WriteLine("1.jeśli chcesz przeliczyć stopnie Celsjusza na Fahrenheity");
    Console.WriteLine("2.jeśli chce przeliczyć stopnie Fahrenheita na Celsjusze");
    Console.WriteLine("3.Opuszczenie programu");

    int dzialanie = int.Parse(Console.ReadLine());

    while (true)
    {
      if (dzialanie == 1) {
        Console.WriteLine("Podaj ile stopni Celcjusza");
        int C = int.Parse(Console.ReadLine());
        Console.WriteLine("Temperatura w skali Farenhajta");
        Console.WriteLine(C * 1.8 + 32);
       
        break;
      }
      else if (dzialanie == 2) {
        Console.WriteLine("Podaj ile stopni Farenhajta");
        int F  = int.Parse(Console.ReadLine());
        Console.WriteLine("Temperatura w skali Celsjusza");
        Console.WriteLine((F - 32) / 1.8);
        break;
}
    else if (dzialanie == 3) {
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
