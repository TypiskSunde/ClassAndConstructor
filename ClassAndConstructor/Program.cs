using System;

namespace ClassAndConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lag en konsollapplikasjon med en klasse som heter TextPrinter. Klassen TextPrinter skal ha en public objektvariabel som heter Name.
            //Lag en constructor til klassen som tar inn et parameter string name. I constructoren kan du sette variabelen Name = name.
            //Denne klassen skal ha en metode PrintName som skriver ut Name til konsollen.
            //Lag også en metode PrintText() som looper igjennom en for-løkke 10 ganger og printer til konsollen “Runde nr” +nummeret den befinner seg på i løkken.
            //Lag en ny instans av TextPrinter i program.cs filen, og kall på PrintName() og PrintText() metodene.

            var textPrinter = new TextPrinter("Name");
            textPrinter.PrintName();
            textPrinter.PrintText();
        }
        
    }
}
