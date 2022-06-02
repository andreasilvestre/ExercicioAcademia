//#4 Exercicio04
//Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas
//as direções. Dessa forma, crie um programa em C# que represente
//uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso, faça uma classe que contenha
//os atributos (privados) posição x, posição y (do asteroide em
//um plano cartesiano), tamanho do asteroide(1 a 10), velocidade do asteroide(1 a 5) e energia(1 a 5).
//Para esses atributos privados, gerar os métodos de acesso
//(propriedades getter e setter). Além disso, implementar 3 construtores (sobrecarga): um vazio, outro
//passando todos os parâmetros de um objeto tipo Asteroide, e um 
//terceiro que constrói um asteroide com posição x e posição y. 
//O programa principal (main) deve conter a lista de Asteroides, preenchida pelo usuário.
//Nesse programa principal, construir um método de classe que exiba todos os
//asteróides da lista.

// n asteroides (posicaox, poiscaao_y)
// uma nave de ataque

using Exercicio04;
List<Asteroide> listaAsteroides = new List<Asteroide>();
/// <summary>
/// guarda a resposta do usuário se deseja inserir mais asteroides = s/n
/// </summary>
string inserir = "S"; //s/n
int posicaox;
int posicaoy;
int tamanho;
int velocidade;
int energia;

//listaAsteroides.Add(new Asteroide(1,1,4,5,4));   
do
{
    Console.Clear();
    Console.WriteLine("Posição X:");
    posicaox = int.Parse(Console.ReadLine());

    Console.WriteLine("Posição Y:");
    posicaoy = int.Parse(Console.ReadLine());

    Console.WriteLine("Tamanho: [1 a 10]:");
    tamanho = int.Parse(Console.ReadLine());

    Console.WriteLine("Velocidade: [1 a 5]");
    velocidade = int.Parse(Console.ReadLine());

    Console.WriteLine("Energia: [1 a 5]");
    energia = int.Parse(Console.ReadLine()); Console.ReadLine();

    listaAsteroides.Add(new Asteroide(posicaox, posicaoy, tamanho, velocidade, energia));

    Console.WriteLine("Deseja inserir mais asteroides? [S/N]");
    inserir = Console.ReadLine().ToUpper();
} while (inserir == "S");

Asteroide.mostrarLista(listaAsteroides);

Console.WriteLine("Pegar lista cpom retorno: ");
foreach (Asteroide i in Asteroide.pegaLista(listaAsteroides))
{
    Console.WriteLine(i.Posicao_x + "x" + i.Posicao_y + " | " + i.Tamanho + " | " + i.Velocidade + " | " + i.Energia);
}
