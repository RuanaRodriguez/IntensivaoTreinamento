using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {

        CriarVetorNome();
    }

    static void CriarVetorNome()
    {
        string[] nomes = new string[12];
        nomes[0] = "Ruana";
        nomes[1] = "Mateus";
        nomes[2] = "Sergio";
        nomes[3] = "Luciana";
        nomes[4] = "Amanda";
        nomes[5] = "Laura";
        nomes[6] = "Tiago";
        nomes[7] = "Jean";
        nomes[8] = "Marlei";
        nomes[9] = "Nicoly";
        nomes[10] = "Junior";
        nomes[11] = "Victor";


        Console.WriteLine($"Eu sou o(a) integrante do intesivão do sucesso e me chamo, " + nomes[0] + "!");
        if (nomes[0] == "Ruana")
        {
            Console.WriteLine("Meu nome completo é: " + nomes[0] + " Rodrigues" + "\r\n");
        }
        Console.WriteLine($"Eu sou o(a) integrante do intesivão do sucesso e me chamo, " + nomes[1] + "!");
        if (nomes[1] == "Mateus")
        {
            Console.WriteLine("Meu nome completo é: " + nomes[1] + " Lemos" + "\r\n");
        }
        Console.WriteLine($"Eu sou o(a) integrante do intesivão do sucesso e me chamo, " + nomes[2] + "!");
        if (nomes[2] == "Sergio")
        {
            Console.WriteLine("Meu nome completo é: " + nomes[2] + " Hideki" + "\r\n");
        }
        Console.WriteLine($"Eu sou o(a) integrante do intesivão do sucesso e me chamo, " + nomes[3] + "!");
        if (nomes[3] == "Luciana")
        {
            Console.WriteLine("Meu nome completo é: " + nomes[3] + " Isis" + "\r\n");
        }
        Console.WriteLine($"Eu sou o(a) integrante do intesivão do sucesso e me chamo, " + nomes[4] + "!");
        if (nomes[4] == "Amanda")
        {
            Console.WriteLine("Meu nome completo é: " + nomes[4] + " Leticia" + "\r\n");
        }
        Console.WriteLine($"Eu sou o(a) integrante do intesivão do sucesso e me chamo, " + nomes[5] + "!");
        if (nomes[5] == "Laura")
        {
            Console.WriteLine("Meu nome completo é: " + nomes[5] + " Montenegro" + "\r\n");
        }
        Console.WriteLine($"Eu sou o(a) integrante do intesivão do sucesso e me chamo, " + nomes[6] + "!");
        if (nomes[6] == "Tiago")
        {
            Console.WriteLine("Meu nome completo é: " + nomes[6] + " Freitas" + "\r\n");
        }
        Console.WriteLine($"Eu sou o(a) integrante do intesivão do sucesso e me chamo, " + nomes[7] + "!");
        if (nomes[7] == "Jean")
        {
            Console.WriteLine("Meu nome completo é: " + nomes[7] + " Jesus" + "\r\n");
        }
        Console.WriteLine($"Eu sou o(a) integrante do intesivão do sucesso e me chamo, " + nomes[8] + "!");
        if (nomes[8] == "Marlei")
        {
            Console.WriteLine("Meu nome completo é: " + nomes[8] + " Correia" + "\r\n");
        }
        Console.WriteLine($"Eu sou o(a) integrante do intesivão do sucesso e me chamo, " + nomes[9] + "!");
        if (nomes[9] == "Nicoly")
        {
            Console.WriteLine("Meu nome completo é: " + nomes[9] + " Kethylin" + "\r\n");
        }
        Console.WriteLine($"Eu sou o(a) integrante do intesivão do sucesso e me chamo, " + nomes[10] + "!");
        if (nomes[10] == "Junior")
        {
            Console.WriteLine("Meu nome completo é: " + nomes[10] + " Soac" + "\r\n");
        }
        Console.WriteLine($"Eu sou o(a) integrante do intesivão do sucesso e me chamo, " + nomes[11] + "!");
        if (nomes[11] == "Victor")
        {
            Console.WriteLine("Meu nome completo é: " + nomes[11] + " Pessoa" + "\r\n");
        }
    }
}
