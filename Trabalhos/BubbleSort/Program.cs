Console.Clear();
int[] valores = new int[] {5,1,4,2,8};
int aux;

Console.Write("Matriz desordenada:       ");
foreach(int valor in valores){
        Console.Write($"{valor} | ");
    }
Console.WriteLine("\n");

for(int i=0; i<(valores.GetLength(0)-1); i++){
    for(int j=0; j<(valores.GetLength(0)-1); j++){
        if(valores[j]>valores[j+1]){
            aux = valores[j];
            valores[j] = valores[j+1];
            valores[j+1] = aux;            

            Console.Write($"Iteração {i+1}:               ");
            foreach(int valor in valores){
                Console.Write($"{valor} | ");
            }
            Console.WriteLine();    
        }
    }
    Console.Write($"Iteração {i+1} completa:      ");
    foreach(int valor in valores){
        Console.Write($"{valor} | ");
    }
    Console.WriteLine("\n");
}

Console.Write("Matriz ordenada:          ");
foreach(int valor in valores){
    Console.Write($"{valor} | ");
}



// for(int i=0; i<(valores.GetLength(0)-1); i++){
//     for(int j=0; j<(valores.GetLength(0)-1); j++){
//         if(valores[j]>valores[j+1]){
//             aux = valores[j];
//             valores[j] = valores[j+1];
//             valores[j+1] = aux;            
//         }
//     }
// }