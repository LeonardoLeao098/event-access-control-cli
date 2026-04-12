Console.WriteLine("Bem-vindo ao Rock in SP!");
Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine()!);

Console.WriteLine("Você possui ingresso? Responsa com 's' para sim ou 'n' para não: ");
string ingresso = Console.ReadLine()!;

Console.WriteLine("Você é VIP? Responda com 's' para sim e com 'n' para não: ");
string vip = Console.ReadLine()!;

if (idade >= 18 && (ingresso == "s" || vip == "s"))
{
    Console.WriteLine("Pode entrar!");
}
else if (idade >= 18)
{
    Console.WriteLine("Não pode passar! Vai comprar um ingresso!");
}
else if (idade < 18 && (ingresso == "s" || vip == "s"))
{
    Console.WriteLine("Não pode passar! Só acompanhado dos pais!");
}
else
{
    Console.WriteLine("Não pode passar! Não tem idade nem ingresso!");
}