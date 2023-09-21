using System.Collections;
using System;

Stack pilha = new Stack(); 

bool continuar = true;

while(continuar == true){
	Console.WriteLine("Por favor, selecione uma opção.");
	Console.WriteLine("1 - Inserir String no topo da pilha");
	Console.WriteLine("2 - Remover String do topo da pilha");
	Console.WriteLine("3 - Verificar qual String está no topo da pilha");
	Console.WriteLine("4 - Verificar se a pilha está vazia");
	Console.WriteLine("5 - Imprimir todo o conteúdo da pilha");
	
	int opcao = Convert.ToInt32(Console.ReadLine());

	switch(opcao){
		case 1:
			Console.WriteLine("Digite qual a String a ser inserida.");
			pilha.Push(Console.ReadLine());
			break;
		case 2:
			try{
				
				Console.WriteLine($"A String '{pilha.Peek()}' foi removida do topo da pilha.");
			}catch(Exception e){
				Console.WriteLine("Nenhuma String foi removida pois a pilha está vazia.");
			}
			break;
		case 3:
			Console.WriteLine($"A String no topo da pilha é: {pilha.Peek()}");
			break;
		case 4:
			try{	
				pilha.Push(pilha.Peek());
				Console.WriteLine($"A pilha não está vazia.");
			}catch(Exception e){
				Console.WriteLine("A pilha está vazia.");
			}
			break;
		case 5:
			try{	
				pilha.Push(pilha.Peek());
				foreach(string elemento in pilha){
					Console.WriteLine(elemento);
				}
			}catch(Exception e){
				Console.WriteLine("Não há nenhum elemento na pilha para ser impresso na tela.");
			}
			break;
		default:
			Console.WriteLine("Opção inválida. Por favor, tente novamente.");
			break;
	}
}
