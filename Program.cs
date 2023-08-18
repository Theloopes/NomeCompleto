string nome;
string sobrenome;

Console.WriteLine("Digite seu primeiro nome");
nome = Console.ReadLine() !;
Console.WriteLine("Digite seu sobrenome");
sobrenome = Console.ReadLine() !;

Console.Write(nome);
Console.Write(" ");
Console.WriteLine(sobrenome);
Thread.Sleep(500);

Console.WriteLine();

Console.Write(sobrenome.ToUpper());
Console.Write(", ");
Console.WriteLine(nome);

