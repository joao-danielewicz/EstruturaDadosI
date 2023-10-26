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

