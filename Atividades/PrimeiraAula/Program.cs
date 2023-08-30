int[] numbers; // cria novo vetor

numbers = new int[5]; //sinaliza que é um veor de cinco posições


numbers[0] = 9;
numbers[1] = -11;
numbers[2] = 5;
numbers[3] = 7;
numbers[4] = -4;

// numbers[5] = -4; fora dos limites = erro

int[] numbers2 = new int[] {9,-11,5,7,-4}; //atribui todos os valores numa mesma linha

int[] numbers3 = {9, -11, 5, 7, -4};

for(int i =0; i < numbers.Length; i++) {
    Console.WriteLine(numbers[i]);

}