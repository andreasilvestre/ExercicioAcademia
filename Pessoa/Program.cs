/*
 * •Escreva uma classe Pessoa contendo todos os 
 * atributos de uma pessoa. Faça métodos para apresentar os dados.
 */

string nome_digitado;
string cpf_digitado;
string telefone_digitado;
string email_digitado;
string endereco_digitado;


Console.WriteLine("Digite um nome: ");
nome_digitado = Console.ReadLine();

Console.WriteLine("Digite o cpf: ");
cpf_digitado = Console.ReadLine();

Console.WriteLine("Digite o email: ");
email_digitado = Console.ReadLine();

Console.WriteLine("Digite o telefone: ");
telefone_digitado = Console.ReadLine();

Console.WriteLine("Digite o endereço: ");
endereco_digitado = Console.ReadLine();



Pessoa pessoa = new Pessoa();
//pessoa.nome = nome_digitado; ==>  passa direto valor para o atributo
//F12 vai para o metodo

pessoa.Nome(nome_digitado);
pessoa.CPF(cpf_digitado);   
//pessoa.Telefone(telefone_digitado);
//pessoa.Email(email_digitado);
//pessoa.Endereco(endereco_digitado);

Console.WriteLine("\n Os métodos estão apresentando os seguintes dados: ");
Console.WriteLine("Pessoa: " + pessoa.nome);
Console.WriteLine("CPF: " + pessoa.cpf);
Console.WriteLine("Telefone: " + pessoa.Telefone(telefone_digitado));
Console.WriteLine("Email: " + pessoa.Email(email_digitado));
Console.WriteLine("Endereco:" + pessoa.Endereco(endereco_digitado));

class Pessoa
{
    public string nome;
    public string cpf;
    public string telefone;
    public string email;
    public string endereco;

    //prop tab tab - atalho atributo
    //public int MyProperty { get; set; }

    //ctor - atalho construtor
    //public Pessoa()
    //{

    //}

    //método para apresentar dados
    public string Nome(string nm)
    {
     //nome = nm.ToUpper(); or
     this.nome = nm.ToUpper();
     return nome;
    }
    public string CPF(string cpf)
    {
        this.cpf = cpf.ToUpper();
        return cpf;
    }
    public string Telefone(string tel)
    {
        telefone = tel.ToUpper();   
        return telefone;
    }
    public string Email(string email)
    {
        email = email.ToLower();  
        return email;
    }
    public string Endereco(string end)
    {
        endereco = end.ToUpper();
        return endereco;
    }
}
