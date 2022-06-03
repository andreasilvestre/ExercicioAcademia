//Modelagem Lógica do Sistema de Vendas

//Cliente(codCliente, nome, rua, numero, complemento, cep, cidade, estado, fone)

//Vendedor(codVendedor, nome, fone, senha)

//Prateleira(codPrateleira, localizacao)

//Produto(codProduto, codigoBarras, descricao, codPrateleira)
//    codPrateleira referencia Prateleira

//Venda(dataNotafiscal, numeroNotaFiscal, codProduto, codVendedor, codCliente)
//    codProduto referencia Produto
//    codVendedor referencia Vendedor
//    codCliente referencia Cliente


//Entidade = classe
//Atributo/Coluna se for uma chave estrangeira, no diagrama fica subentendido
//Relacionamento indica quem visita quem (chave primária visita outra entidade  
//                                        como chave estrangeira)
//    -Uma chave estrangeira deve ser uma chave primária na sua entidade/classe
//    de origem
//Cardinalidade: mostra como se dará a visita (quem terá a chave estrangeira)


public class Cliente 
{
    int codCliente;
    string nome;
    string rua;
    int numero;
    string complemento;
    int cep;
    string cidade;
    string estado;
    int fone;

    public Cliente()
    {

    }

    public int CodCliente { get => codCliente; set => codCliente = value; }
    public string Nome { get => nome; set => nome = value; }
    public string Rua { get => rua; set => rua = value; }
    public int Numero { get => numero; set => numero = value; }
    public string Complemento { get => complemento; set => complemento = value; }
    public int Cep { get => cep; set => cep = value; }
    public string Cidade { get => cidade; set => cidade = value; }
    public string Estado { get => estado; set => estado = value; }
    public int Fone { get => fone; set => fone = value; }
}

public class Vendedor
{
    int codVendedor;
    string nome;
    int fone;
    string senha;

    public Vendedor()
    {

    }

    public int CodVendedor { get => codVendedor; set => codVendedor = value; }
    public string Nome { get => nome; set => nome = value; }
    public int Fone { get => fone; set => fone = value; }
    public string Senha { get => senha; set => senha = value; }
}

public class Prateleira  //n produtos
{
    int codPrateleira;
    string localizacao;

    public Prateleira()
    {

    }

    public int CodPrateleira { get => codPrateleira; set => codPrateleira = value; }
    public string Localizacao { get => localizacao; set => localizacao = value; }
}

public class Produto
{
    int codProduto;
    int CodigoBarras;
    string descricao;
    Prateleira prateleira;

    public Produto()
    {

    }

    public int CodProduto { get => codProduto; set => codProduto = value; }
    public int CodigoBarras1 { get => CodigoBarras; set => CodigoBarras = value; }
    public string Descricao { get => descricao; set => descricao = value; }
    public Prateleira Prateleira { get => prateleira; set => prateleira = value; }
}

public class Venda 
{
    int numeroNotaFiscal; //chave primária
    DateTime dataNotaFiscal;
    Produto produto;
    Vendedor vendedor;
    Cliente cliente;

    public Venda()
    {

    }

    public int NumeroNotaFiscal { get => numeroNotaFiscal; set => numeroNotaFiscal = value; }
    public DateTime DataNotaFiscal { get => dataNotaFiscal; set => dataNotaFiscal = value; }
    public Produto Produto { get => produto; set => produto = value; }
    public Vendedor Vendedor { get => vendedor; set => vendedor = value; }
    public Cliente Cliente { get => cliente; set => cliente = value; }
}

