using calculadora_cli.Models;

Calculadora calculadora = new Calculadora();


bool sair = false;

while (!sair)
{
    Console.WriteLine("Qual operação deseja Realizar?");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Potência");
    Console.WriteLine("6 - Sair");
    string opcao = Console.ReadLine();

    Console.Clear();

    Console.Write("Informe o primeiro número: ");
    string primeiroItem = Console.ReadLine();
    Console.Write("Informe o segundo número: ");
    string segundoItem = Console.ReadLine();

    double primeiroNumero = Convert.ToDouble(primeiroItem);
    double segundoNumero = Convert.ToDouble(segundoItem);

    Console.Clear();


    switch (opcao)
    {
        case "1":
            calculadora.Somar(primeiroNumero, segundoNumero);
            break;
        case "2":
            calculadora.Subtrair(primeiroNumero, segundoNumero);
            break;
        case "3":
            calculadora.Multiplicar(primeiroNumero, segundoNumero);
            break;
        case "4":
            calculadora.Dividir(primeiroNumero, segundoNumero);
            break;
        case "5":
            calculadora.Potencia(primeiroNumero, segundoNumero);
            break;
        case "6":
            sair = true;
            break;
        default:
            break;
    }
}