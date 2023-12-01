String EscreveLista(int[] lista, int min, int max){
    string msg = "| ";
    for(int i = min; i<max; i++){
        int item = lista[i];
        msg+=$"{item} | ";
    }
    return msg;
}

String BinarySearch(int[] lista, int valor){
    Console.Clear();

    // Declaração das variáveis de limite do Array.
    // De início, começa por zero e vai até o último elemento.
    int min = 0;
    int max = lista.Length -1;

    int i=1;

    while(min<=max){
        Console.WriteLine($"PASSO {i}\n Lista a ser usada: "+EscreveLista(lista, min, max+1)+"\n");

        // Determina qual o índice da metade da lista ou de suas subdivisões.
        int meio = (min+max)/2;

        // Comparação efetiva: se o valor desejado for igual ao que se encontra no índice do meio, ele foi encontrado.
        // Se for menor que o do meio, sabe-se que a lista da direita (valores maiores) deve ser descartada.
        // Se for maior, então a lista esquerda (valores menores) será descartada.
        if(valor == lista[meio]){
            return $"O número desejado está na posição {++meio} da lista.";
        } else if(valor < lista[meio]){
            max = meio-1;
        } else if(valor > lista[meio]){
            min = meio+1;
        }

        i++;
        
    }
        // Se a lista passar pela iteração While e em nenhum momento cair no primeiro caso "if", signfica que o valor desejado não está presente na lista.
        return "O valor não foi encontrado na lista.";
}


int[] lista = {3, 7, 9, 15, 17, 24, 36, 38, 45};
Console.WriteLine(BinarySearch(lista, 45));

// 17, 36, 3, 45

// O código básico para o funcionamento do Binary Search é relativamente simples e ocupa menos de 20 linhas.
// String BinarySearch(int[] lista, int valor){
//     int min = 0;
//     int max = lista.Length -1;
//     while(min <= max){
//         int meio = (min+max)/2;
//         if(valor == lista[meio]){
//             return $"O número desejado está na posição {++meio} da lista.";
//         } else if(valor < lista[meio]){
//             max = meio-1;
//         } else if(valor > lista[meio]){
//             min = meio+1;
//         }
//     }
//     return "O valor não foi encontrado na lista.";
// }
// int[] lista = {3, 7, 9, 15, 17, 24, 36, 38, 45};
// Console.WriteLine(BinarySearch(lista, 7));