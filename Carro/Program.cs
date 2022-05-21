
//Crie uma classe Carro com os atributos: modelo, marca, cor e placa. Crie um método
//para definir os atributos, outro método para ligar o carro e outro método para desligar o carro.

Carro c = new Carro();

c.ligar();
c.defineAtributos();
Console.WriteLine("Marca: " + c.marca);
Console.WriteLine("Modelo: " + c.modelo);
Console.WriteLine("Cor: " + c.cor);
Console.WriteLine("Placa: " + c.placa);
c.desligar();

class Carro
{
    public string modelo;
    public string marca;
    public string cor;
    public string placa;

    public bool ligado;

    public void defineAtributos()
    {
        modelo = "gol";
        marca = "Volks";
        cor = "prata";
        placa = "dae-7484";
    }

    public void ligar()
    {
        Console.WriteLine("Carro ligado");
        ligado = true;
    }

    public void desligar()
    {
        Console.WriteLine("Carro desligado");
        ligado = false;
    }
}


/*
 * •Escreva uma classe Pessoa contendo todos os 
 * atributos de uma pessoa. Faça métodos para apresentar os dados.
 */

class Pessoa
{
    public string nome;
    public string cpf;
    public double telefone;
    public string email;
    public string endereco;

    public string x()
    { }
}