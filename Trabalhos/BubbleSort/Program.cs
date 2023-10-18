Console.Clear();
int[] valores = new int[] {5,1,4,2,8};
int aux;

Console.Write("Matriz desordenada:       | ");
foreach(int valor in valores){
        Console.Write($"{valor} | ");
}
Console.WriteLine("\n");

// Loop exterior: usado para percorrer todos os itens do vetor e flutuá-los até o topo.
// Loop interior: usado para comparar o elemento da vez com o seu superior, até que este ocupe a maior posição possível.

// Condicional: se o item sendo comparado for menor que aquele que está acima, nada é feito. Caso contrário,
// ele será guardado numa variável auxiliar, seu espaço original será ocupado por seu superior (que é menor),
// e ele passará a ocupar a posição original + 1 (que antes pertencia ao número menor).
int mudança = 0;
for(int i=0; i<valores.GetLength(0); i++){
    for(int j=0; j<(valores.GetLength(0)-1); j++){
        if(valores[j]>valores[j+1]){
            aux = valores[j];
            valores[j] = valores[j+1];
            valores[j+1] = aux;            

            mudança++;

            Console.Write($"Iteração {i+1}:               | ");
            foreach(int valor in valores){
                Console.Write($"{valor} | ");
            }
            Console.WriteLine();    
        }

        if(mudança==0){
            break;
        }
    }
    Console.Write($"Iteração {i+1} completa:      | ");
    foreach(int valor in valores){
        Console.Write($"{valor} | ");
    }
    Console.WriteLine("\n");
}

Console.Write("Matriz ordenada:          | ");
foreach(int valor in valores){
    Console.Write($"{valor} | ");
}


// O algoritmo de ordenação por bolha é simples. Abaixo, está apresentado sem nenhum método de impressão, e ocupa apenas onze linhas.
// int[] valores = new int[];
// int aux;
// for(int i=0; i<(valores.GetLength(0)-1); i++){
//     for(int j=0; j<(valores.GetLength(0)-1); j++){
//         if(valores[j]>valores[j+1]){
//             aux = valores[j];
//             valores[j] = valores[j+1];
//             valores[j+1] = aux;            
//         }
//     }
// }

// Entretanto, pode acabar ocupando mais memória do que deve visto que continua comparando elementos mesmo quando o vetor já está ordenado.
// A solução é criar uma variável que nos indica se uma mudança foi feita: a partir do momento que não houver nenhuma, os números estarão ordenados.
// int[] valores = new int[];
// int aux;
// int mudança = 0;
// for(int i=0; i<valores.GetLength(0); i++){
//     for(int j=0; j<(valores.GetLength(0)-1); j++){
//         if(valores[j]>valores[j+1]){
//             aux = valores[j];
//             valores[j] = valores[j+1];
//             valores[j+1] = aux;            
//             mudança++;
//         if(mudança==0){
//             break;
//         }
//     }