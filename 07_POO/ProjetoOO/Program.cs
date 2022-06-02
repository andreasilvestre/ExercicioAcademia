// See https://aka.ms/new-console-template for more information


//Lampada l = new Lampada();
//l.Ligar();
//l.potencia = 9;
Console.WriteLine("Ligado= " + l.ligado + " Potencia= " + l.potencia);
l.desligar();
Console.WriteLine("Ligado= " + l.ligado + " Potencia= " + l.potencia);
double n;
n = l.potencia;
Console.WriteLine("A potencia da lampada cadastrada é: " + n);
Console.WriteLine("Retorno da função estaLigada: " + l.estaligada());
l.Ligar();
l.desligar();
if (l.estaligada())
{
Console.WriteLine("Lampada ligada.");
}
else
{
Console.WriteLine("Lampada desligada");
}

public class Lampada
{
    public bool ligado;
    public double potencia;

    //public, private, protected
    public void Ligar()
    {
        Console.WriteLine("A lampada está sendo ligada");
        ligado = true;
    }
    public void desligar()
    {
        Console.WriteLine("A lampada está sendo desligada");
        ligado = false;
    }
    public double retornaPotencia()
    {
        return potencia;
    }

    public bool estaligada()
    {
        return ligado;
    }
}

