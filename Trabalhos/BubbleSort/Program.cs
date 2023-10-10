int[] valores = new int[] {6,7,8,4,10};
int aux = 0;

foreach(int valor in valores){
        Console.Write($"{valor} | ");
    }
Console.WriteLine();

for(int i=0; i<(valores.GetLength(0)-1); i++){
    for(int j=0; j<(valores.GetLength(0)-1); j++){
        if(valores[j]>valores[j+1]){
            aux = valores[j];
            valores[j] = valores[j+1];
            valores[j+1] = aux;            
        
        }
    }
    foreach(int valor in valores){
        Console.Write($"{valor} | ");
    }
    Console.WriteLine();
}

foreach(int valor in valores){
    Console.Write($"{valor} | ");
}