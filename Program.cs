string nome;


Console.WriteLine("Qual é o seu nome? ");
nome = Console.ReadLine()!;


Console.WriteLine("Qual é o seu sobrenome? ");
string sobrenome = Console.ReadLine()!;

Console.WriteLine($"Olá, {nome} {sobrenome}!");
Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");