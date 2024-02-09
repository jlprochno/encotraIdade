using System.Security.Cryptography;

namespace encotraIdade;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, por gentileza digite seu Nome: ");
            string name = Console.ReadLine();
        Console.WriteLine("agora, digite o ano que você nasceu: ");
            int year = Convert.ToInt32(Console.ReadLine());

        int age = 2024 - year;

        Console.WriteLine(name + ", sua idade é aproximadamente: " + age + " anos.");
        

    }
}
