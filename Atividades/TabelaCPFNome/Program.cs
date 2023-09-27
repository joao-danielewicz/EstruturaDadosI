// Adicionar, verificar se há conflitos, listar todos 

using System.Collections;

Hashtable cpfNome = new Hashtable();
bool sair = false;


while(sair == false){
    Console.Clear();

    Console.WriteLine("Por favor, selecione uma opção.");
	Console.WriteLine("1 - Inserir novo par CPF-Nome");
	Console.WriteLine("2 - Listar todos os pares CPF-Nome");
	Console.WriteLine("3 - Sair");

    String opcao = Console.ReadLine()!;
    switch(opcao){
        case "1":
            Console.WriteLine("Digite o CPF: ");
            string CPF = Console.ReadLine()!;
            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine()!;

            try{
                cpfNome.Add(CPF, nome);
            }catch(ArgumentException aex){
                Console.WriteLine("Erro: este CPF já está sendo utilizado. Por favor, tente novamente.");
                Console.WriteLine($"Mensagem: {aex.Message}");
                Thread.Sleep(2500);
            }

            break;
        case "2":
            Console.WriteLine("CPF            ---    NOME");
            foreach(DictionaryEntry item in cpfNome){
                Console.WriteLine("{0}    ---    {1}", item.Key, item.Value);
            }
            Thread.Sleep(2500);
            break;
        case "3":
            sair = true;
            break;
        default:
            Console.WriteLine("Opção inválida. Por favor, tente novamente.");
            Thread.Sleep(2500);
            break;
    }
}

