using LinQ_Join;

public class Program
{
    public static void Main(string[] args)
    {
        List<Author> authors = new List<Author>();
        authors.Add(new Author { AuthorId = 1, Name = "Tove Ditlevsen" });
        authors.Add(new Author { AuthorId = 2, Name = "Vigdis Hjorth" });
        authors.Add(new Author { AuthorId = 3, Name = "Domenico Starnone" });
        authors.Add(new Author { AuthorId = 4, Name = "Jon Fosse" });

        List<Book> books = new List<Book>();
        books.Add(new Book { BookId = 1, Title = "Çocukluk", AuthorId = 1 });
        books.Add(new Book { BookId = 2, Title = "Gençlik", AuthorId = 1 });
        books.Add(new Book { BookId = 3, Title = "Bağımlılık", AuthorId = 1 });
        books.Add(new Book { BookId = 4, Title = "Miras", AuthorId = 2 });
        books.Add(new Book { BookId = 5, Title = "Postane Günlükleri", AuthorId = 2 });
        books.Add(new Book { BookId = 6, Title = "Annem Öldü Mü", AuthorId = 2 });
        books.Add(new Book { BookId = 7, Title = "Şaka", AuthorId = 3 });
        books.Add(new Book { BookId = 8, Title = "Bağlar", AuthorId = 3 });
        books.Add(new Book { BookId = 9, Title = "Sabahtan Akşama", AuthorId = 4 });
        books.Add(new Book { BookId = 10, Title = "Üçleme", AuthorId = 4 });


        var Library = authors.Join(books,
                                   author => author.AuthorId,
                                   book => book.AuthorId,
                                   (author, book) => new
                                   {
                                       AuthorName = author.Name,
                                       BookTitle = book.Title,
                                   }
                                   );

        foreach ( var author in Library)
        {
            Console.WriteLine($"Yazarın adı: {author.AuthorName}, Kitap adı: {author.BookTitle}");
        }











        
        
        
        
    

    }

}
