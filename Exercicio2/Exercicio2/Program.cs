int idade;
Console.WriteLine("Olá aqui iremos verificar a sua idade");
Console.Write("Digite sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

if (idade <= 17)
{
    Console.WriteLine("Você é menor de idade");
}
else if (idade >= 18 && idade < 60)
{
    Console.WriteLine("Você é adulto");
}
else if (idade >= 60)
{
    Console.WriteLine("Você é idoso");
}
Console.ReadKey();