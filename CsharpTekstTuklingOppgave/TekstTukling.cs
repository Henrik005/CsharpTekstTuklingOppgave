using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CsharpTekstTuklingOppgave
{
    internal class TekstTukling
    {
        
        private bool runAlterWords = false;
        private bool runReverseText = false;

        public void Run()
        {
            Console.WriteLine("What would you like to do:");
            Console.WriteLine("Alter Words?");
            Console.WriteLine("Reverse Text?");
            string input = Console.ReadLine();
            if (input == "Alter Words")
            {
                runAlterWords = true;
            }
            else if (input == "Reverse Text")
            {
                Console.Clear();
                Console.WriteLine("Write a text you wanna reverse");
                string text = Console.ReadLine();

                Console.WriteLine(ReverseText(text));
                Run();
            }

            AlterWords();
            
        }

        private void AlterWords()
        {
            while (runAlterWords == true)
            {
                string input = Console.ReadLine();
                string output = input.Replace('e', 'a');
                Console.WriteLine($"{output}");

                if (input == "Stop")
                {
                    runAlterWords = false;
                }
            }

        }
       
        private string ReverseText(string text)
        {

            var newText = "";
            for (int i = text.Length -1; i >= 0; i--)
            {
                newText += text[i];
            }

            return newText;


        }
    }
}
