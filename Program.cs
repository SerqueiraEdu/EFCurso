using EFCurso.Curso.Data;
using EFCurso.Curso.Domain;
using Microsoft.EntityFrameworkCore;
using static EFCurso.Curso.ValueObjects.TipoProduto;


// Inserindo um novo e único produto no banco de dados.
//var db = new ApplicationContext();

//InserirDadosUnico(db);
//InserirDadosEmMassa(db);

//static void InserirDadosUnico(ApplicationContext db)
//{
//    var produtos = new Produto()
//    {
//        CodigoBarras = "654321",
//        Descricao = "Produto Teste Dois",
//        Valor = "10.50",
//        TipoProduto = MercadoriaParaRevenda,
//        Ativo = true
//    };

//    //Formas de rastreio do entity framework para inserir um registro.
//    //As quatro formas abaixo fazem a mesma coisa. traqueiam o objeto produtos para inserção no banco de dados.
//    //Qualquer uma delas não afetam o desempenho de forma significativa, podendo ser usadas conforme a preferência do desenvolvedor.
//    db.Produtos.Add(produtos);
//    db.Set<Produto>().Add(produtos);
//    db.Entry<Produto>(produtos).State = EntityState.Added;
//    db.Add(produtos);

//    //Salva as alterações no banco de dados retornando o número de registros afetados.
//    var registro = db.SaveChanges();

//    Console.WriteLine("Produto inserido com sucesso!");
//    Console.WriteLine("Total inserido: " + registro);
//    Console.ReadKey();
//}

//static void InserirDadosEmMassa(ApplicationContext db)
//{
//    var produtos = new List<Produto>()
//    {
//        new Produto()
//        {
//            CodigoBarras = "123456",
//            Descricao = "Produto Teste Um",
//            Valor = "5.50",
//            TipoProduto = MercadoriaParaRevenda,
//            Ativo = true
//        },
//        new Produto()
//        {
//            CodigoBarras = "789012",
//            Descricao = "Produto Teste Dois",
//            Valor = "15.50",
//            TipoProduto = MercadoriaParaRevenda,
//            Ativo = true
//        },
//        new Produto()
//        {
//            CodigoBarras = "345678",
//            Descricao = "Produto Teste Tres",
//            Valor = "25.50",
//            TipoProduto = MercadoriaParaRevenda,
//            Ativo = true
//        }
//    };

//    //var produto = new Produto()
//    //{
//    //    CodigoBarras = "901234",
//    //    Descricao = "Produto Teste Quatro",
//    //    Valor = "35.50",
//    //    TipoProduto = MercadoriaParaRevenda,
//    //    Ativo = true
//    //};

//    //var cliente = new Cliente()
//    //{
//    //    Nome = "Cliente Teste",
//    //    CEP = "12345678",
//    //    Cidade = "Cidade Teste",
//    //    Estado = "ST",
//    //    Telefone = "11999999999"
//    //};


//    //Formas de rastreio do entity framework para inserir múltiplos registros.
//    //As quatro formas abaixo fazem a mesma coisa. traqueiam o objeto produtos para inserção no banco de dados.
//    //Qualquer uma delas não afetam o desempenho de forma significativa, podendo ser usadas conforme a preferência do desenvolvedor.
//    db.Produtos.AddRange(produtos);

//    //db.AddRange(produto, cliente);

//    //db.Set<Produto>().AddRange(produtos);
//    //foreach (var produto in produtos)
//    //{
//    //    db.Entry<Produto>(produto).State = EntityState.Added;
//    //}
//    //db.AddRange(produtos);

//    //Salva as alterações no banco de dados retornando o número de registros afetados.
//    var registro = db.SaveChanges();
//    Console.WriteLine("Produtos inseridos com sucesso!");
//    Console.WriteLine("Total inserido: " + registro);
//    Console.ReadKey();
//}

//consultando registros no banco de dados.
//var db = new ApplicationContext();

////var consultaPorSintaxe = from p in db.Produtos.Where(p => p.TipoProduto.Equals(MercadoriaParaRevenda)).ToList() select p;
//var consultaPorMetodo = db.Produtos.Where(p => p.TipoProduto.Equals(MercadoriaParaRevenda)).ToList();

//foreach (var item in consultaPorMetodo)
//{
//    Console.WriteLine($"Descrição: " + item.Descricao);
//}

//Console.ReadKey();

//db.Produtos.Where(p => p.Id > 0).ToList().ForEach(p =>
//{
//    Console.WriteLine($"Produto: {p.Descricao} - {p.Valor}");
//});

//var produto =db.Produtos.FirstOrDefault(p => p.Id == 10);
//if (produto != null)
//{
//    Console.WriteLine($"Produto encontrado: {produto.Descricao} - {produto.Valor}");
//    Console.ReadKey();
//}
//else
//{
//    Console.WriteLine("Produto não encontrado.");
//    Console.ReadKey();
//}

//Atualizando um registro no banco de dados.
var db = new ApplicationContext();

// o método find busca somente pelo id e um único Id
//var produto = db.Produtos.Find(1);

//if (produto != null) 
//    produto.Descricao = "teste";

//db.SaveChanges();
//Console.WriteLine("");


// Quando se usa o first é necessário o try catch pois se não existir o id ele nem chega a criar o objeto
// e lança a excessão InvalidOperationException
//try
//{
//    var produto = db.Produtos.First(p => p.Id == 10);
//    produto.Descricao = "Teste";
//    db.SaveChanges();
//}
//catch (InvalidOperationException)
//{
//    Console.WriteLine("Produto não encontrado!");
//    Console.ReadKey();
//}

//var produto = db.Produtos.FirstOrDefault(p => p.Id == 1);

//if (produto != null)
//{
//    produto.Descricao = "Teste";
//    db.SaveChanges();
//}

//Console.WriteLine("Atualizado!");
//Console.ReadKey();

//var produtos = db.Produtos.Where(p => p.Id == 1).ToList();

//if (produtos != null)
//{
//    foreach (var produto in produtos)
//    {
//        produto.Descricao = "Teste teste";
//        db.SaveChanges();
//    }
//}

//Console.WriteLine("Atualizado!");
//Console.ReadKey();


// Removendo registros
//var produto = db.Produtos.FirstOrDefault(p => p.Id == 1);
////db.Produtos.Remove(produto);
//db.Remove(produto);
//db.Entry(produto).State = EntityState.Deleted;

//db.SaveChanges();
//Console.WriteLine("Removido!!");