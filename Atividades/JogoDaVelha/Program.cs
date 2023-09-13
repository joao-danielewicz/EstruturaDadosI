using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Definição de qual jogador iniciará a partida
        Random rnd = new Random();
        string jogador = "";
        int aux = rnd.Next(0,2);
        if(aux == 0){
            jogador = "O";
        }else{
            jogador = "X";
        }
        
        // Inicialização da variável de controle do Loop e da matriz multidimensional do jogo
        bool continuar = true;
        string[,] jogoDaVelha = { {" "," "," "},{" "," "," "},{" "," "," "} };
        
        
        while(continuar == true){
            // representação do jogo da velha
            for(int i=0; i<3; i++){
                Console.WriteLine();
                for(int j=0; j<3; j++){
                    Console.Write($"| {jogoDaVelha[i,j]} |");
                }   
            }
            Console.WriteLine();
        
            // Alternância de jogadores
            if(jogador.Equals("O")){
                jogador="X";
            }else{
                jogador="O";
            }
            
            
            
            while(1>0){
                // Preenchimento da grade do jogo
                Console.WriteLine($"Jogador {jogador}, indique a linha em que deseja jogar.");
                int linha = Convert.ToInt32(Console.ReadLine())-1;
                Console.WriteLine("Agora, informe a coluna desejada.");
                int coluna = Convert.ToInt32(Console.ReadLine())-1;
                
                // Verificação da disponibilidade da área desejada
                if(jogoDaVelha[linha, coluna].Equals(" ")){
                    jogoDaVelha[linha, coluna] = jogador;
                    break;
                }else{
                    Console.WriteLine("Esta posição já está ocupada. Por favor, tente novamente.");
                }
            }
        
            // Criação das variáveis de verificação: se forem preenchidas, há um vencedor
            String diagonalPrin = "";
            String diagonalSec = "";
            String line = "";
            String col = "";
            
            for(int i=0; i<3; i++){
                col="";
                for(int j=0; j<3; j++){
                        // preenche as linhas e colunas
                        line += jogoDaVelha[i,j];
                        col += jogoDaVelha[j,i];
                        // preenche as diagonais
                        if(i==j){
                            diagonalPrin+=jogoDaVelha[i,j];
                        }
                        if(i+j==2){
                            diagonalSec+=jogoDaVelha[i,j];
                        }
                    }
                // verifica qual dos símbolos preencheu as linhas ou colunas
                if(line.Equals("XXX") || line.Equals("OOO")){
                    continuar = false;
                }
                if(col.Equals("XXX") || col.Equals("OOO")){
                    continuar = false;
                }
            }
            // verifica qual dos símbolos preencheu as diagonais
            if(diagonalPrin.Equals("XXX") || diagonalPrin.Equals("OOO")){
                continuar = false;
            }
            if(diagonalSec.Equals("XXX") || diagonalSec.Equals("OOO")){
                continuar = false;
            }
        }
    
    // Anuncia o jogador vencedor
        Console.WriteLine($"O jogador {jogador} ganhou!");
        
    }
}