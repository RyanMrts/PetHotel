string Espécie, Raça, Apelido, Idade, Pelagem;



Console.WriteLine("Olá, Bem-vindo ao Pet Hotel ! ");
Thread .Sleep(1000);
Console.WriteLine("Preencha o cadastro do seu pet: ");
Console.Write("Espécie: ");
Espécie = Console.ReadLine()!;
Console.Write("Raça: ");
Raça = Console.ReadLine()!;
Console.Write("Apelido: ");
Apelido = Console.ReadLine()!;
Console.Write("Idade: ");
Idade = Console.ReadLine()!;
Console.Write("Pelagem/Cor: ");
Pelagem = Console.ReadLine()!;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("+=========================================================+");
    Console.Write("|                       ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("Pet Hotel                         ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("|\n+=========================================================+\n");
    Console.Write("| ");
Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Espécie:"+Espécie);
    Console.Write("                       ");
    Console.Write("Raça: "+Raça);
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("\n+=========================================================+\n|");
    Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write(" Apelido: "+Apelido);
    Console.Write("                      ");
    Console.Write("Idade(Anos): "+Idade);
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("\n+=========================================================+\n|");
    Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("                  pelagem/Cor: "+Pelagem);
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("\n+=========================================================+\n");

Console.ResetColor();