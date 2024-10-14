Console.WriteLine("Bem-Vindo ao Estacionamento");
Console.WriteLine("Digite o preço inicial: ");
int precoInit = Convert.ToInt32 (Console.ReadLine ()); 
Console.WriteLine ("Agora digite o preco por hora: ");
int precoPh = Convert.ToInt32 (Console.ReadLine ());
Console.Clear ();
Console.WriteLine ("O que desejas?");
string opcao = null;
string placa;

List<string> Veiculos = new List<string>();
while (opcao != "4"){
Console.WriteLine ("1 - Cadastrar veiculo\n 2 - Remover veiculo\n 3 - Listar veiculos\n 4 - Encerrar servico");
opcao = Console.ReadLine ();

switch (opcao)
{
    case "1" :
    Console.WriteLine ("Digite a placa do veiculo: ");
    placa = Console.ReadLine ();
    Veiculos.Add (placa);
    Console.WriteLine ("Veiculo Cadastrado");
    Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
    Console.Clear ();
    break;
    
    case "2" :
    Console.WriteLine ("Digite a placa do veiculo a ser removido: ");
    placa = Console.ReadLine ();
    Veiculos.Remove (placa);
    Console.WriteLine ("Veiculo Removido\n Digite a quantidade de horas que ele permaneceu estacionado: ");
    int horas = Convert.ToInt32 (Console.ReadLine());
    int precoT = precoInit + precoPh * horas;
    Console.WriteLine ($"Veiculo removido\n Preco total de horas estacionadas: R${precoT},00");
    Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
    Console.Clear ();
  
    break;

    case "3" :
    foreach (string veiculo in Veiculos){
        Console.WriteLine (veiculo);  
    }
    Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear ();
    break;

    case "4" :
    Console.WriteLine ("Sistema Encerrado");
    break;

    default: 
    break;
}
}
