using System;

class Srednia {
    static void Main() {
        Console.WriteLine("Podaj ile ocen chcesz wpisać");
        int io = int.Parse(Console.ReadLine());  
        
        int so = 0;  

        for (int i = 1; i <= io; i++) {
            while(true){
            Console.WriteLine("Podaj ocenę nr " + i);
            int o = int.Parse(Console.ReadLine());
            if(o<=6 && o>=1){
               Console.WriteLine("dodano ocene"); 
               so += o; 
               break;
            }
            else{
                Console.WriteLine("podano złą wartosc"); 
                Console.WriteLine("sprobuj ponownie"); 
            }
            }    
        }
        

        double srednia = (double)so / io;
        Console.WriteLine("Średnia ocen: " + srednia.ToString("F2"));
        
        if (srednia < 3.5) {
            Console.WriteLine("Uczeń nie zdał");
        } else {
            Console.WriteLine("Uczeń zdał");
        }
    }
}
