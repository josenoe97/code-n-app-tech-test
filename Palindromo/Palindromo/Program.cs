using System.Diagnostics.Contracts;

Console.Write("Digite uma palavra: ");
string palindromo = Console.ReadLine().ToLower();

if (IsPalindromo(palindromo))
    Console.WriteLine("É palindromo!");
else
    Console.WriteLine("Não é palindromo.");

bool IsPalindromo(string palindromo)
{
    string palindromoLimpo = "";

    if (string.IsNullOrWhiteSpace(palindromo))
        return false;
    

    foreach (char c in palindromo)// limpa texto sem o Trim()
    {
        if (c != ' ')
            palindromoLimpo += c;
    }

    int inicio = 0;
    int fim = palindromoLimpo.Length - 1;

    while (inicio < fim) // verifica se texto sem espaço e toLower é palindromo
    {
        if (palindromoLimpo[inicio] != palindromoLimpo[fim])
            return false;

        inicio++;
        fim--;
    }

    return true;
}