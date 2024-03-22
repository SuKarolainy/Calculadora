using System;
namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a operação desejada: + , - , * , / ");
            char op = Convert.ToChar(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+': 
                    result = num1 + num2; break;
                case '-':
                    result = num1 - num2; break;
                case '*':
                    result = num1 * num2; break;
                case '/':
                    result = num1 / num2; break;

            }

            Console.WriteLine($"O resultado é: {result} ");
        }
    }
}
