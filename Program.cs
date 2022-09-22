using  dotnet.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" + 
                    "Digite o valo inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o valor por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opcao");
    Console.WriteLine("1 - Cadastrar veiculo");
    Console.WriteLine("2 - Listar veiculos");
    Console.WriteLine("3 - Remover veiculos");
    Console.WriteLine("4 - Encerrar");

    switch(Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;
        
        case "2":
            es.ListarVeiculos();
            break;
        
        case "3":
            es.RemoverVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;
        
        default:
            Console.WriteLine("opcao invalida");
            break;
    }
    Console.ReadLine();

}

Console.WriteLine("O programa se encerrou");




























// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("MG");
// listaString.Add("CE");
// listaString.Add("RJ");


// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("MG");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");


// Console.WriteLine("Percorrendo a lista com o For");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posicao {contador} - {listaString[contador]}");

// }

// Console.WriteLine("Percorrendo a lista com FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.Write($"Posicao N {contadorForeach} - {item}");
//     contadorForeach++;
// }



























// int [] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;


// int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);

// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


// Console.WriteLine("Percorrendo arrray com FOR");
// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posicao N {contador} - {arrayInteiros[contador]}");

// }
















//Console.WriteLine("Percorrendo array com FOREACH");

// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posicao N {contadorForeach} - {arrayInteiros[contadorForeach]}");
//     contadorForeach++;
// }




// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opcao");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadasttar cliente");
//             break;
        
//         case "2":
//             Console.WriteLine("Buscar cliente");
//             break;
        
//         case "3":
//             Console.WriteLine("Apagar cliente ");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             break;
        
//         default:
//             Console.WriteLine("opcao invalida");
//             break;
//     }

// }


















// int soma =  0, numero = 0;


// do
// {
//     Console.WriteLine("Digite um numero(0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;


// }while(numero != 0);

// Console.WriteLine($"Toral da soma dos numero digitados e: {soma}");


















// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador} Execuçao: {numero} X {contador} = {numero * contador}");
//     contador++;

//     if(contador == 6)
//     {
//         break;
//     }
// }






















// int numero = 5;


// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} X {contador} = {numero * contador}");

// }















// Calculadora calc = new Calculadora();

// calc.Somar(10 , 30);
// calc.Divisao(10, 2);
// calc.Multiplicar(10, 2);
// calc.Subtrair(5, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Tangente(30);
// calc.Coseno(30);

// calc.RaizQuadrada(9);

// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("inrementadop a 10");
// numero = numero + 5;

// Console.WriteLine(numero);






















// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada");
// }
// else
// {
//     Console.WriteLine("Nao possui autorizaçao");
// }



// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();


// switch (letra)
// {

//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":

//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Nao e vogal");
//         break;
// }










// if(letra == "a" ||
//    letra == "e" ||
//    letra == "i" ||
//    letra == "o" ||
//    letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Nao e uma vogal"); 
// }









// else if(letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if(letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if(letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if(letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Nao e uma vogal");
// }











// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque : {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"E possivel realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda invalida");
// }

// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada");                                                                   
// }
// else
// {
//     Console.WriteLine("Desculpe, Nao temos a quantidade desejada.");
// }



// string a = "15-";

// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Conversao realizada com sucesso");




// int a = 5;
// double b = a;
// int a = 5;
// long b = a;

// Console.WriteLine(b);




// int inteiro = 5;
// string  a = inteiro.ToString();

// Console.WriteLine(a);





// int a = Convert.ToInt32(null);
//int a = int.Parse("5");

// Console.WriteLine(a);



// int a = 10;
// int b = 20;

// int c = a + b;

// c = c + 5;

// Console.WriteLine(c);






// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));



// // string apresentacao = "Ola, seja bem vindo.";

// // int quantidade = 1;

// // double altura = 1.80; 

// // decimal preco = 1.80M;

// // bool condicao = true;

// // Console.WriteLine(apresentacao);
// // Console.WriteLine("Valor da variavel quantidade :" + quantidade);
// // Console.WriteLine("Valor da variavel altura :" + altura.ToString("0.00"));
// // Console.WriteLine("Valor da variavel preço :" + preco);
// // Console.WriteLine("Valor da variavel condiçao :" + condicao);



// //Pessoa pessoa1 = new Pessoa();

// //pessoa1.Nome = "Buta";
// //pessoa1.Idade = 25;
// pessoa1.Apresentar();


