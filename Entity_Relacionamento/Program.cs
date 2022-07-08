using Entity_Relacionamento;

Modelo modelo = new Modelo("XLX");
modelo.Salvar();

var listaModelos = Modelo.Todos();

foreach (var item in listaModelos)
{
    Console.WriteLine(item.Id);
    Console.WriteLine(item.Nome);
}

Veiculo veiculo = new Veiculo() { Nome = "Honda Civic", Modelo = listaModelos.First(), Ano = 2011 };
veiculo.Salvar();

var listaVeiculos = Veiculo.Todos();

foreach (var item in listaVeiculos)
{
    Console.WriteLine(item.Id);
    Console.WriteLine(item.Nome);
    Console.WriteLine(item.Modelo.Nome);
}