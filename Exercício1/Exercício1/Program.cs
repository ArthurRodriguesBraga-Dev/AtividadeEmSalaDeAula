﻿int Valor1, Valor2, resultado;
Char operacao;
Console.WriteLine("Olá! Bem vindo a calculadora.");
Console.Write("Digite o primeiro valor: ");
Valor1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite os símbolos das operações como: + (soma) - (subtração) * (multiplicação) / (divisão) : ");
operacao = Convert.ToChar(Console.ReadLine());
Console.Write("Digite o segundo valor: ");
Valor2 = Convert.ToInt32(Console.ReadLine());

if (operacao == '+')
{
    resultado = Valor1 + Valor2;
    Console.WriteLine($"O resultado dessa operação foi:{resultado}");
}
else if (operacao == '-')
{
    resultado = Valor1 - Valor2;
    Console.WriteLine($"O resultado dessa operação foi:{resultado}");
}
else if (operacao == '*')
{
    resultado = Valor1 * Valor2;
    Console.WriteLine($"O resultado dessa operação foi:{resultado}");
}
else if (operacao == '/')
{
    resultado = Valor1 / Valor2;
    Console.WriteLine($"O resultado dessa operação foi:{resultado}");
}
else
{
    Console.WriteLine("Algo deu de errado, reinicie o programa e tente novamente");
}