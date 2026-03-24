int opcao, numero1, numero2, resultado;

do
{
    Console.Clear();
    Console.WriteLine("Selecione uma opção:");
    Console.WriteLine("1.Soma");
    Console.WriteLine("2.Subtração");
    Console.WriteLine("3.Divisão");
    Console.WriteLine("4.Multiplicação");
    Console.WriteLine("5.Encerrar");
    opcao = Convert.ToInt16(Console.ReadLine());

    if (opcao == 1) ;
    {
        Console.Clear();
        Console.WriteLine("Soma");
        Console.WriteLine("Insira o primeiro número:");
        numero1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Insira o segundo número");
        numero2 = Convert.ToInt16(Console.ReadLine());
        resultado = numero1 + numero2;
        Console.WriteLine("");
        Console.WriteLine("O resultado da soma é:" + resultado);
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
    }
    else if (opcao == 2) ;
    {
        Console.Clear();
        Console.WriteLine("Subtração");
        Console.WriteLine("Insira o primeiro número:");
        numero1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Insira o segundo número");
        numero2 = Convert.ToInt16(Console.ReadLine());
        resultado = numero1 - numero2;
        Console.WriteLine("");
        Console.WriteLine("O resultado da subtração é:") + resultado);
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
    }
    else if (opcao == 3) ;
    {
        Console.Clear();
        Console.WriteLine("Divisão");
        Console.WriteLine("Insira o primeiro número:");
        numero1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Insira o segundo número");
        numero2 = Convert.ToInt16(Console.ReadLine());
        resultado = numero1 / numero2;
        Console.WriteLine("");
        Console.WriteLine("O resultado da divisão é:" + resultado);
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
    }
    else if (opcao == 4) ;
    {
        Console.Clear();
        Console.WriteLine("Multiplicação");
        Console.WriteLine("Insira o primeiro número:");
        numero1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Insira o segundo número");
        numero2 = Convert.ToInt16(Console.ReadLine());
        resultado = numero1 * numero2;
        Console.WriteLine("");
        Console.WriteLine("O resultado da multiplicação é:" + resultado);
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
    }
    else if (opcao == 5) ;
    {
        Console.Clear();
        Console.WriteLine("Encerrando");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
    }
} while (opcao :=5);




