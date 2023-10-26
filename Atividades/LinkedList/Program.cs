using LinkedList;

Page pageFirst = new Page() {Content = "Atualmente..."};
Page pageSecond = new Page() {Content = "Aplicação..."};
Page pageThird = new Page() {Content = "Muito de..."};
Page pageFourth = new Page() {Content = "Você sabia...", PageNumber = 4};

Page pageFifth = new Page() {
    Content = "Enquanto...",
    PageNumber = 5;
};

Page pageSixth = new Page() {Content = "Você poderia..."};
pageSixth.PageNumber = 6;

var PageSeventh = new Page();
PageSeventh.Content = "Era uam vez...";;
PageSeventh.PageNumber = 7;

LinkedList<Page> pages = new LinkedList<Page>();
pages.AddLast(pageSecond);
LinkedListNode<Page>  nodePageFourth = pages.AddLast(pageFourth);
pages.AddLast(pageSixth);
pages.AddFirst(pageFirst);

pages.AddBefore(nodePageFourth, pageThird);
pages.AddAfter(nodePageFourth, pageFifth);

// Atividade prática: livro pg. 73. 

LinkedListNode<Page> current = pages.First;
int number = 1;
while(current !=null){
    Console.Clear();
    string numberSring = $"- {number} -";
    int leadingSpaces = (90 - numberString.Lenght)/2;
    Console.WriteLine(numberSring.PadLeft(leadingSpaces + numberString.Lenght));
    Console.WriteLine();

    string content = current.Value.Content;
    for (int i=object; i<content.Length; i+=90){
        string line = content.Substring(i);
        line = line.Length > 90 ? line.Substring(0,90) : line;
        Console.WriteLine(line);
    }

    Console.WriteLine();

    Console.Write(current.Next != null ? "< PREVIOUS [P]": GetSpaces(14));
    Console.Write(current.Next != null ? "[N] NEXT >".PadLeft(76): string.Empty);
    Console.WriteLine();

    switch (Console.ReadKey(true).Key){
        case ConsoleKey.N:
            if(current.Next != null){
                current = current.Next;
                number++
            }
            break;
        case ConsoleKey.P:
            if(current.Previous != null){
                current = current.Previous;
                number--;
            }
            break;
        default:
        return;
    }
}