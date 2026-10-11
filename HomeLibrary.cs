class HomeLibrary
{
    public List<Book> Books = new List<Book>();

    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Книга «{book.Title}» добавлена");
    }

    public void RemoveBook(string title)
    {
        for (int i = 0; i < Books.Count; i++)
        {
            if (Books[i].Title == title)
            {
                Books.RemoveAt(i);
                Console.WriteLine($"Книга «{title}» удалена");
                return;
            }
        }
        Console.WriteLine($"Книга «{title}» не найдена");
    }

    public void FindByAuthor(string author)
    {
        Console.WriteLine($"Поиск по автору: {author}");
        bool found = false;
        for (int i = 0; i < Books.Count; i++)
        {
            if (Books[i].Author == author)
            {
                Books[i].Show();
                found = true;
            }
        }
        if (found == false)
        {
            Console.WriteLine("Ничего не найдено");
        }
    }

    public void FindByYear(int year)
    {
        Console.WriteLine($"Поиск по году издания: {year}");
        bool found = false;
        for (int i = 0; i < Books.Count; i++)
        {
            if (Books[i].Year == year)
            {
                Books[i].Show();
                found = true;
            }
        }
        if (found == false)
        {
            Console.WriteLine("Ничего не найдено");
        }
    }

    public void SortByTitle()
    {
        for (int i = 0; i < Books.Count - 1; i++)
        {
            for (int j = 0; j < Books.Count - 1 - i; j++)
            {
                if (string.Compare(Books[j].Title, Books[j + 1].Title) > 0)
                {
                    Book temp = Books[j];
                    Books[j] = Books[j + 1];
                    Books[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Книги отсортированы по названию");
    }

    public void SortByAuthor()
    {
        for (int i = 0; i < Books.Count - 1; i++)
        {
            for (int j = 0; j < Books.Count - 1 - i; j++)
            {
                if (string.Compare(Books[j].Author, Books[j + 1].Author) > 0)
                {
                    Book temp = Books[j];
                    Books[j] = Books[j + 1];
                    Books[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Книги отсортированы по автору");
    }

    public void SortByYear()
    {
        for (int i = 0; i < Books.Count - 1; i++)
        {
            for (int j = 0; j < Books.Count - 1 - i; j++)
            {
                if (Books[j].Year > Books[j + 1].Year)
                {
                    Book temp = Books[j];
                    Books[j] = Books[j + 1];
                    Books[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Книги отсортированы по году издания");
    }

    public void ShowAll()
    {
        Console.WriteLine($"Книг в библиотеке: {Books.Count}");
        for (int i = 0; i < Books.Count; i++)
        {
            Books[i].Show();
        }
    }
}
