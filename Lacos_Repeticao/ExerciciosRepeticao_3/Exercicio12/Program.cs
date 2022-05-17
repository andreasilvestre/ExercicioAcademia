Console.WriteLine("EXERCICIO12" +
"\n 12: Apresentar o total da soma dos cem primeiros números inteiros.\n");

int somaInteiro = 0; 

// de 1 a 100
for (int i = 1; i <= 100; i++)
{
    somaInteiro = somaInteiro + i;
}

Console.WriteLine("A soma total dos cem primeiros números inteiros é: " + somaInteiro); //soma = 5050
