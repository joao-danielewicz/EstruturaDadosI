// 1 - Criar projeto Console Exe01
// 2 - Crie um vetor de inteiros com 10 posições
// 3 - Carregue valores no vetor e exiba-o desordenado
// 4 - Escreva um algoritmo em C# para ordenar os valores 
// 5 - Imprima os valores ordenados

// Criar o vetor
int[] valores;
valores = new int[10];

// Preencher com valores digitados pelo usuário
for(int i=0; i<10; i++){
    Console.WriteLine("Digite o valor da posição "+(i+1)+" do vetor.");
    valores[i] = Convert.ToInt32(Console.ReadLine());
}

// Escrever o vetor desordenado
Console.WriteLine("Vetor desordenado:");
for(int i=0; i<10; i++){
    Console.WriteLine(valores[i]);
}

// Ordenar
int aux = 0;
for(int i=0; i<10; i++){
    for(int j=0; j<10; j++){
        if(valores[i]<valores[j]){
            aux = valores[i];
            valores[i] = valores[j];
            valores[j] = aux;
        }
    }
}

// Apresentar o vetor ordenado ao usuário
Console.WriteLine("Vetor ordenado:");
for(int i=0; i<10; i++){
    Console.WriteLine(valores[i]);
}





