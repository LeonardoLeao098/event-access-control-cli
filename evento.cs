Console.WriteLine("Bem-vindo ao Rock in SP!");
Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine()!);

Console.WriteLine("Você possui ingresso? Responda com 's' para sim ou 'n' para não: ");
string ingresso = Console.ReadLine()!.ToLower();

switch (ingresso)
{
    case "s":
        Console.WriteLine("Ingresso válido!");
        break;
    case "n":
        Console.WriteLine("Sem ingresso.");
        break;
    default:
        Console.WriteLine("Opção inválida.");
        return;
}

Console.WriteLine("Você é VIP? Responda com 's' para sim e com 'n' para não: ");
string vip = Console.ReadLine()!.ToLower();

switch (vip)
{
    case "s":
        Console.WriteLine("Acesso VIP detectado!");
        break;
    case "n":
        Console.WriteLine("Acesso comum.");
        break;
    default:
        Console.WriteLine("Resposta inválida.");
        return;
}

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
    Console.WriteLine("Mas não pode passar! Só acompanhado dos pais!");
}
else
{
    Console.WriteLine("Não pode passar! Não tem idade nem ingresso!");
}