
int numero = 1;
List<int> listaNumero = new List<int>();

while (numero != 0)
{
    Console.WriteLine("Digite um número:  [Para sair 0]");
    numero = int.Parse(Console.ReadLine());
    if (!numero.Equals(0))
    {
        listaNumero.Add(numero);
    }
    
}

Console.Clear();

//foreach (int i in listaNumero)
for (int i = 0; i < listaNumero.Count; i++)
{
    Console.WriteLine(i + " = " + listaNumero[i]);
}

MediaAritmetica calcula_media = new MediaAritmetica();
calcula_media.Calcular(listaNumero);
Console.WriteLine("A média é: " + calcula_media.media.ToString("F"));

class MediaAritmetica
{
    public double media=0;
    
    public double Calcular(List<int> listaNumero)
    {
        for (int i = 0; i < listaNumero.Count; i++)
        {
            media = media + listaNumero[i];
        }
        media = media / listaNumero.Count;
        return media;
    }
}