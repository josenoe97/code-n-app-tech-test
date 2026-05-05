//Escreva um código que receba um texto “gritado”, isto é, com muitas pontuações de exclamação e interrogação, e transforme em um texto mais normalizado.
//Exemplos abaixo: De "Como é???????" para "Como é?"; De "Não!!!!!!!!" para "Não!"; De "O que???!!!!! Não acredito!!!" para "O que?! Não acredito!"


using System.Security;

Console.Write("Digite uma palavra: ");
string textoGritado = "O que???!!!!! Não acredito!!!";

//string textoGritado = "O que???!!!";

Console.WriteLine(NormalizacaoTexto(textoGritado));


string NormalizacaoTexto(string texto)
{
    string resultado = "";

    for (int i = 0; i < texto.Length; i++)
    {
        if (texto[i] == '?' || texto[i] == '!')
        {
            string bloco = "";

            while (i < texto.Length && (texto[i] == '?' || texto[i] == '!'))  //verifica se a seguintes letras é interrogação ou exclamação
            {
                bloco += texto[i];
                i++;
            }

            i--; 

            bool temInterrogacao = bloco.Any(x => x == '?');
            bool temExclamacao = bloco.Any(x => x == '!');

            if (temInterrogacao) resultado += "?";
            if (temExclamacao) resultado += "!";
        }
        else
        {
            resultado += texto[i];
        }
    }

    return resultado;
}


