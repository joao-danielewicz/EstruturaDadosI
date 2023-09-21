using System.Collections;

// Criar Hashtable 
Hashtable openWith = new Hashtable();


try{
    openWith.Add("Nome" , "João");
    openWith.Add("txt" , "notepad.exe");
    openWith.Add("bmp" , "paint.exe");
    openWith.Add("dib" , "paint.exe");
    openWith.Add("epub" , "wordpad.exe");
    openWith.Add("rtf" , "notepad++.exe");

}
catch(ArgumentException aex){
    Console.WriteLine("Um item com esta chave já foi adicionado na HashTable");
    Console.WriteLine($"Detalhes do erro: {aex.Message}");
}
catch (Exception ex){
    Console.WriteLine("Erro genérico");
    throw ex;
}
 
// Acessando o conteúdo da tabela Hash.
Console.WriteLine("Na chave = \"rtf\" é {0}", openWith["rtf"]);

// Alterando o coneúdo da tabela Hash
openWith["rtf"] = "winword.exe";
Console.WriteLine("Na chave = \"rtf\" é {0}",
    openWith["rtf"]
);

// Testar se chave existe na tabela Hash.
if(!openWith.ContainsKey("ht")){
    openWith.Add("ht", "hypertrm.exe");
    Console.WriteLine("Chave ht adicionada.");
}

// Percorrendo o Hash com foreach
Console.WriteLine();
foreach(DictionaryEntry de in openWith){
    Console.WriteLine(
        "Key = {0} --- Value = {1}",
        de.Key,
        de.Value
    );
}

// Obtendo apenas os valores do Hash.
ICollection valueCol = openWith.Values;
Console.WriteLine();
foreach(string s in valueCol){
    Console.WriteLine("Value = {0}", s);
}

// Obtendo apenas as chaves do Hash.
ICollection valueKey = openWith.Keys;
Console.WriteLine();
foreach(string k in valueKey){
    Console.WriteLine("Key = {0}", k);
}

// Remover registro do Hash
Console.WriteLine("Removendo (\"doc\")");
openWith.Remove("doc");
if(!openWith.ContainsKey("doc")){
    Console.WriteLine("Chave \"doc\" foi removida.");
}




Console.WriteLine("Programa ainda em execução");