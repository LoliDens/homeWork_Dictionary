using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Экспансия", "территориальное, географическое или иное расширение зоны обитания, или зоны влияния отдельного государства, народа, культуры или биологического вида.");
            dictionary.Add("Ангст", "сильные переживания, физические, но чаще духовные страдания персонажа.");
            dictionary.Add("Наитие", "вдохновение, как бы внушенное какой-то высшей силой.");
            dictionary.Add("Соитие", "половой акт, совокупление.");

            FaindWordInDictionary(dictionary);
        }

        static void FaindWordInDictionary(Dictionary<string, string> dictionary) 
        {
            Console.Write("Введите слово заначение которого вы хотите найти: ");
            string userInput = Console.ReadLine();
            bool isWordHave = false;

            foreach (var word in dictionary) 
            {
                if (word.Key.ToLower() == userInput.ToLower()) 
                {
                    Console.WriteLine($"{word.Key} - {word.Value}");
                    isWordHave = true;
                    break;
                }
            }

            if (isWordHave == false) 
            {
                Console.WriteLine("Введенное вами слово не найдено");
            }

            Console.ReadKey();
        }
    }
}
