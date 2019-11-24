using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
    static void Main(string[] args)
    {
        while (true)
        {
            
        
        Console.WriteLine("Podaj wartość BRUTTO");
        double brutto ;
        double vat ;
        double netto;
        double podatek;

        if (!double.TryParse(Console.ReadLine(),out brutto))
        {
            Console.WriteLine("błędna wartość");
            return ;
        }
         
        //Console.WriteLine(brutto);
        Console.WriteLine("Podaj wartość VAT");
        if (!double.TryParse(Console.ReadLine(),out vat))
        {
            Console.WriteLine("błędna wartość");
            return ;
        }
        //Console.WriteLine(vat);
        netto = Math.Round(brutto / (1 + (vat / 100)),2);
        podatek = Math.Round(brutto - netto,2) ;
        Console.WriteLine("Podstawa opodatkowania netto wynosi: " + netto);
        Console.WriteLine("Podatek VAT wynosi: " + podatek);
        Console.WriteLine(" ");
        Console.WriteLine("Aby kontynuować przyciśnij przycisk \"ENTER \", by wyjść z programu przyciśnij \" ESC \"");
        if (Console.ReadKey().Key == ConsoleKey.Escape)
            return ;
        }
    }
    }
}