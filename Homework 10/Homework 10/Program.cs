
using System;
using System.Numerics;

namespace Homework_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook ntb1 = new Notebook
            {
                Name = "Asus",
                RAM = 16,
                Storage = 512,
                Price = 2500,
            };

            Notebook ntb2 = new Notebook
            {
                Name = "MacBook",
                RAM = 8,
                Storage = 256,
                Price = 3000,
            };

            Phone phn1 = new Phone
            {
                Name = "Xiaomi",
                SimCount = 2,
                Price = 600,
                Camera=48,
            };

            Phone phn2 = new Phone
            {
                Name = "Iphone",
                SimCount = 1,
                Price = 3000,
                Camera=24,
            };

            Product[] arr = { phn1, phn2, ntb1, ntb2 };
            string opt;
            do
            {
                Console.WriteLine("\n---------------------- MENU ----------------------\n");
                Console.WriteLine("1. Butun mehsullara baxx");
                Console.WriteLine("2. Notebooklara bax");
                Console.WriteLine("3. Telefonlara bax");
                Console.WriteLine("4. Notebooklarin sayina bax");
                Console.WriteLine("5. Telefonlarin sayina bax");
                Console.WriteLine("6. Notebooklarin ortalama qiymetine bax");
                Console.WriteLine("7. Telefonlarin ortalama qiymetine bax");
                Console.WriteLine("0. Prosesi bitir");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        FindAllProducts(arr);
                        break;
                    case "2":
                        FindNotebooks(arr);
                        break;
                    case "3":
                        FindPhones(arr);
                        break;
                    case "4":
                        NotebooksCount(arr);
                        break;
                    case "5":
                        PhonesCount(arr);
                        break;
                    case "6":
                        NotebooksAvrPrice(arr);
                        break;
                    case "7":
                        PhonesAvrPrice(arr);
                        break;
                    case "0":
                        Console.WriteLine("Proses bitdi");
                        return;
                    default:
                        Console.WriteLine("\nSeciminiz yanlisdir");
                        break;
                }
            } while (opt!="0");
        }

        static void FindAllProducts(Product[] arr)
        {
            Console.WriteLine("\n---------------------- PRODUCTS ----------------------\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Product name: {arr[i].Name} Product price: {arr[i].Price}");
            }
        }

        static void FindNotebooks(Product[] arr)
        {
            Console.WriteLine("\n---------------------- NOTEBOOKS ----------------------\n");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Notebook)
                {
                    var ntb = arr[i] as Notebook;
                    Console.WriteLine($"Notebook name: {arr[i].Name} Notebook price: {arr[i].Price} Notebook RAM: {ntb.RAM}");
                }
            }
        }

        static void FindPhones(Product[] arr)
        {
            Console.WriteLine("\n---------------------- PHONES ----------------------\n");
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Phone)
                {
                    var phn = arr[i] as Phone;
                    Console.WriteLine($"Phone name: {arr[i].Name} Phone price: {arr[i].Price} Phone camera: {phn.Camera} Phone simcount: {phn.SimCount}");
                }
            }
        }

        static void NotebooksCount(Product[] arr)
        {
            int counter = 0;
            Console.WriteLine("\n---------------------- NOTEBOOKS COUNT ----------------------\n");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Notebook)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Notebook count: {counter}");
        }

        static void PhonesCount(Product[] arr)
        {
            int counter = 0;
            Console.WriteLine("\n---------------------- PHONES COUNT ----------------------\n");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Phone)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Phone count: {counter}");
        }

        static void NotebooksAvrPrice(Product[] arr)
        {
            Console.WriteLine("\n---------------------- NOTEBOOKS AVERAGE PRICE ----------------------\n");
            int count = 0;
            int sum = 0;
            int avr = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Notebook)
                {
                    count++;
                    sum += arr[i].Price;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Notebook yoxdur");
            }
            else
            {
                avr = sum / count;
            }

            Console.WriteLine($"Notebooks average price: {avr}");
        }

        static void PhonesAvrPrice(Product[] arr)
        {
            Console.WriteLine("\n---------------------- PHONES AVERAGE PRICE ----------------------\n");
            int count = 0;
            int sum = 0;
            int avr = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Phone)
                {
                    count++;
                    sum += arr[i].Price;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Phone yoxdur");
            }
            else
            {
                avr = sum / count;
            }

            Console.WriteLine($"Phones average price: {avr}");
        }
    }
}
