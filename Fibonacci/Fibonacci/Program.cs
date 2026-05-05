//Escreva um código que gere os X primeiros elementos da sequência de Fibonacci, onde X é a quantidade de elementos gerados.
//A sequência de Fibonacci é construída de forma que cada elemento seja sempre a soma dos dois elementos anteriores, conforme exemplos abaixo: 
//Quando X = 3 o resultado é 0, 1, 1; Quando X = 5 o resultado é 0, 1, 1, 2, 3; Quando X = 7 o resultado é 0, 1, 1, 2, 3, 5, 8


Console.Write("Digite a quantidade de elementos: ");
int x = int.Parse(Console.ReadLine());

GerarFibonacci(x);

void GerarFibonacci(int quantidade)
{
    if(quantidade < 0)
        Console.Write("Não pode quantidade menor que zero");

    // parametros iniciais
    int a = 0; // representa o x = 1
    int b = 1; // representa o x = 2

    for (int i = 0; i < quantidade; i++)
    {
        Console.Write(a);

        if (i < quantidade - 1)
            Console.Write(", ");

        int proximo = a + b;
        a = b;
        b = proximo;
    }
}
