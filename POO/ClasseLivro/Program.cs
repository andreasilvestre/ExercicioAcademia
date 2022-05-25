// See https://aka.ms/new-console-template for more information
using ClasseLivro;

Console.WriteLine("Construindo uma classe para Livro");

string titulo;
string autor;
int paginas;
int ano;
int edicao;

Console.WriteLine("Digite o titulo");
titulo = Console.ReadLine();

Console.WriteLine("Digite o autor");
autor = Console.ReadLine();

Console.WriteLine("Digite a qtde de páginas");
paginas = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o ano");
ano = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a adição");
edicao = int.Parse(Console.ReadLine());

Livro livro = new Livro(titulo,autor,paginas,ano,edicao);

livro.apresentarInfoLivro();