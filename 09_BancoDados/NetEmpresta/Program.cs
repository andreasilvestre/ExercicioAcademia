NetEmpresta possui ao redor de 200.000 filmes (filmes, documentários, animes, ..), cujo empréstimo deve ser controlado.

Cada filme possui um número. 
Para cada filme, é necessário saber seu título e sua categoria (comédia, drama, aventura, ...).
Cada filme recebe um identificador próprio. 

Os clientes podem desejar encontrar os filmes estrelados pelo seu ator predileto. 

Por isso, é necessário manter a informação dos atores que estrelam em cada filme. 
Nem todo filme possui estrelas. Para cada ator os clientes às vezes desejam saber o nome real,
bem como a data de nascimento.

A NetEmpresa possui muitos clientes cadastrados. 
Somente clientes cadastrados podem alugar filmes. 
Para cada cliente é necessário saber seu pré-nome e seu sobrenome, seu telefone e seu endereço. 
Além disso, cada cliente recebe um número de associado.
Finalmente, desejamos saber que filmes cada cliente tem alugados. 
Um cliente pode ter vários empréstimos em um instante no tempo. 

Nota: são mantidos registros históricos de aluguéis.

A partir desse relato construa:
- modelo lógico

Indicando entidades, atributos, relacionamentos, cardinalidades


public class Categoria
{
    int codCategoria;
    string nome;
}
public class Filme {
    int codFilme;
    string titulo;
    Categoria categoria;
}

public class Artista {  // ou estrelas???
    int codArtista;
    string nome;
    string nomeReal;
    DateTime dataNascimento;

}

public class FilmeArtista { // nxn
    Filme filme;
    Artista artista;    
}

public class Cliente {
    int codAssociado;
    string preNome;
    string sobrenome;
    string rua;
    int numero;
    string complemento;
    string bairro;
    int cep;
    string cidade;
    int telefone;
}

public class Aluguel { //n filmes x n clientes
    Cliente cliente;
    Filme filme;
    DateTime dataHoraAluguel;
}