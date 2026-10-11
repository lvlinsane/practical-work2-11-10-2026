HomeLibrary library = new HomeLibrary();

library.AddBook(new Book("Война и мир", "Толстой", 1869));
library.AddBook(new Book("Анна Каренина", "Толстой", 1877));
library.AddBook(new Book("Преступление и наказание", "Достоевский", 1866));
library.AddBook(new Book("Мастер и Маргарита", "Булгаков", 1967));
library.AddBook(new Book("Собачье сердце", "Булгаков", 1925));
library.AddBook(new Book("Идиот", "Достоевский", 1869));

Console.WriteLine();
library.ShowAll();

Console.WriteLine();
library.FindByAuthor("Булгаков");
Console.WriteLine();
library.FindByYear(1869);
Console.WriteLine();
library.FindByAuthor("Пушкин");

Console.WriteLine();
library.SortByYear();
library.ShowAll();

Console.WriteLine();
library.SortByAuthor();
library.ShowAll();

Console.WriteLine();
library.SortByTitle();
library.ShowAll();

Console.WriteLine();
library.RemoveBook("Идиот");
library.RemoveBook("Евгений Онегин");

Console.WriteLine();
library.ShowAll();
