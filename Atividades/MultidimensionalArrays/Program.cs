int[,] biNumbers = new int[5,2];

int[,,] triNumbers = new int[5,4,3];

// Valores pré definidos
int[,] loadedBiNumbers = new int[,]
{
    {  1,  2, 3},
    {  4,    5, -6},
    {101, 45, -9}
};

for(int i=0; i<loadedBiNumbers.GetLength(0); i++){
    for(int j=0; j<loadedBiNumbers.GetLength(1); j++){
        // Console.Write($"[{loadedBiNumbers[i,j]}]");
        Console.Write("{0,4}", $"{loadedBiNumbers[i,j]}");
    }   
    Console.WriteLine();
}


// Usuário digita os valores
int[,] userLoadedBiNumbers = new int[3,3];

for(int i=0; i<userLoadedBiNumbers.GetLength(0); i++){
    for(int j=0; j<userLoadedBiNumbers.GetLength(1); j++){
        Console.Write($"Digite um número inteiro para a linha {i+1} e a coluna {j+1} do vetor: ");
        userLoadedBiNumbers[i,j] = Convert.ToInt32(Console.ReadLine());
    }   
    Console.WriteLine();
}

for(int i=0; i<userLoadedBiNumbers.GetLength(0); i++){
    for(int j=0; j<userLoadedBiNumbers.GetLength(1); j++){
        // Console.Write($"[{userLoadedBiNumbers[i,j]}]");
        Console.Write("{0,4}", $"{userLoadedBiNumbers[i,j]}");
    }   
    Console.WriteLine();
}


// Usuário digita os valores, restrição de 0 ou 1 e indica a casa da matriz a ser preenchida
