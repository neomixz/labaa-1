using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace labaa_2._1
{
    class Task1
    {
        static void Main(string[] args)
        {
            //Заданий файл з текстом англійською мовою. Виділити всі різні слова.
            //Слова, що відрізняються тільки регістром літер, вважати однаковими.

            string path = @"D:\programing\labaa 2.1\writing.txt";
            string text;

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    text = sr.ReadLine();
                }

                List<string> list = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                List<string> list1 = new List<string>();
                int n;
                for (int i = 0; i < list.Count; i++)
                {
                    n = 0;
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[i].ToLower() == list[j].ToLower() && i != j)
                        {
                            n += 1;
                        };
                    }
                    if (n == 0)
                    {
                        list1.Add(list[i]);
                    }
                }
                Console.Write("Your sentence : ");
                Console.WriteLine(string.Join(" ", list));
                Console.WriteLine("\n");

                Console.Write("Edited sentence : ");
                for (int i = 0; i < list.Count; i++)
                {
                    n = 0;
                    for (int j = 0; j < list1.Count; j++)
                    {
                        if (list[i] == list1[j])
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(list[i]);
                            Console.ResetColor();
                            Console.Write(" ");
                            n += 1;
                            break;
                        };
                    }
                    if (n != 1)
                        Console.Write(list[i] + " ");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Write any text in 'writing'!");
            }

        }
    }
}
