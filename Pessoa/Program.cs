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

pessoa.Cadastrar(nome_digitado, cpf_digitado, telefone_digitado, email_digitado, endereco_digitado);

Console.WriteLine("Pessoa = " + pessoa.nome + " | " + pessoa.cpf + " | " + pessoa.telefone + " | \n" +
    pessoa.email + " | " + pessoa.endereco);

pessoa.Dormir();
Console.WriteLine("Está dormindo? " + pessoa.estaDormindo);

//pessoa.Comer();
//Console.WriteLine("Está comendo? " + pessoa.estaComendo);

pessoa.Estudar();
Console.WriteLine("O que a pessoa está fazendo???  Estudando??? " + pessoa.estaEstudando);

int opcao;
Console.WriteLine("O que a pessoa está fazendo agora??????");
Console.WriteLine("1 - Dormindo?");
Console.WriteLine("2 - Comendo?");
Console.WriteLine("3 - Trabalhando?");
Console.WriteLine("4 - Estudando?");
Console.WriteLine("5 - Exercitando?");
Console.WriteLine("Opção: ");
opcao = int.Parse(Console.ReadLine());

pessoa.Fazer(opcao);
Console.WriteLine("A pessoa está....... " + pessoa.estaFazendo);

Console.WriteLine("FIM PRIMEIRO TESTE \n");

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
    public bool estaDormindo;
    public bool estaComendo;
    public bool estaTrabalhando;
    public bool estaEstudando;

    public string estaFazendo;
    //prop tab tab - atalho atributo
    //public int MyProperty { get; set; }

    //ctor - atalho construtor
    //public Pessoa()
    //{

    //}

    public void Cadastrar(string nome, string cpf, string telefone, string email, string encdereco)
    {
        this.nome = nome.ToUpper();
        this.cpf = cpf.ToUpper();
        this.telefone = telefone;
        this.email = email.ToUpper();
        this.endereco = encdereco.ToUpper();

    }

    public string Fazer(int opcao)
    {
        switch (opcao)
        {
            case 1:
                estaFazendo = "Dormindo";
                break;
            case 2:
                estaFazendo = "Comendo";
                break;
            case 3:
                estaFazendo = "Trabalhando";
                break;
            case 4:
                estaFazendo = "Estudando";
                break;
            case 5:
                estaFazendo = "Exercitando";
                break;
            default:
                break;
        }
        return estaFazendo;
    }
    public void Dormir()
    {
        estaDormindo = true;
    }

    public bool Comer()
    {
        estaComendo = true;
        return estaComendo;
    }

    public void Acordar()
    {
        estaDormindo = false;
    }

    public void Trabalhar()
    {
        estaDormindo = false;
        estaComendo = false;
        estaEstudando = false;

        estaTrabalhando = true;
    }

    public void Estudar()
    { 
        estaComendo = false;
        estaDormindo = false;
        estaTrabalhando = false;

        estaEstudando=true;
    }

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
