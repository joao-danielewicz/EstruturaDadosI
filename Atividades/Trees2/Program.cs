public class TreeNode<T>{
    public T Data { get; set; }
    public TreeNode<T> Parent { get; set; }
    public List<TreeNode<T>> Children { get; set; }
    public int GetHeight(){
        int height = 1;
        TreeNode<T> current = this;
        while (current.Parent != null){
            height++;
            current = current.Parent;
        }
        return height;
    }
}

public class Tree<T>{
    public TreeNode<T> Root { get; set; }
}

public class Pessoa{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public Pessoa(){}
    public Pessoa(int id, string nome, string cargo)
    {
        Id = id;
        Nome = nome;
        Cargo = cargo;
    }
}


public class Program{
    static void Main(){
        Tree<Pessoa> empresa = new Tree<Pessoa>();

        empresa.Root = new TreeNode<Pessoa>(){
            Data = new Pessoa(5, "João", "Chefe"),
            Parent = null
        };

        empresa.Root.Children = new List<TreeNode<Pessoa>>(){
            new TreeNode<Pessoa>(){
                Data = new Pessoa(7, "Christian", "Designer Chefe"),
                Parent = empresa.Root
            },
            new TreeNode<Pessoa>(){
                Data = new Pessoa(13, "Bianca", "Designer Chefe"),
                Parent = empresa.Root
            },
            new TreeNode<Pessoa>(){
                Data = new Pessoa(18, "Ana Laura", "Designer Chefe"),
                Parent = empresa.Root
            }
        };

        Console.WriteLine($"{empresa.Root.Data.Nome} - {empresa.Root.Data.Cargo}\n-----------\n");
        for(int i=0; i<empresa.Root.Children.Count; i++){
            Console.WriteLine($"{empresa.Root.Children[i].Data.Nome} - {empresa.Root.Children[i].Data.Cargo}");
        }
    }
}