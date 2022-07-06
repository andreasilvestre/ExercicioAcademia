using ConsoleApp_Entity;

using (var contexto = new ClienteContext())
{
    Console.WriteLine("Iniciando o programa!!"); //a primeira vez, vai criar o banco 
    var quantidade_pacientes = contexto.Clientes.Count();

    //contexto.Clientes.Add(new Cliente("Andrea", "andrea@ufn.edu.br"));

    //contexto.SaveChanges();

    Console.WriteLine("Feito " + quantidade_pacientes);

    Console.WriteLine("========================");
    foreach (var cliente in contexto.Clientes)
    {
        Console.WriteLine("Nome: " + cliente.Nome);
        Console.WriteLine("Email: " + cliente.Email);
        Console.WriteLine("Id: " + cliente.Id);
        Console.WriteLine("========================");

    }
}