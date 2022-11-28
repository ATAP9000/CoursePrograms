using Entities;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = Book.Books();
            List<Author> authors = Author.Authors();
            var result = books.Join(authors,
                                    book => book.AuthorId,
                                    author => author.AuthorId,
                                    (book, author) => new
                                    {
                                        author = author.Name,
                                        title = book.Title,
                                        publicationdate = book.PublicationDate,
                                        sales = book.Sales
                                    });
            var booksBySale = result.OrderByDescending(book => book.sales).ToList();
            Console.WriteLine("Top 3 de libros mas vendidos:");
            booksBySale.Take(3).ToList().ForEach(result => Console.WriteLine(result.title));
            Console.WriteLine("\nLos 3 libros menos vendidos:");
            booksBySale.TakeLast(3).ToList().ForEach(result => Console.WriteLine(result.title));
            Console.WriteLine("\nAutor con mas libros:");
            Console.WriteLine(result.GroupBy(x => x.author, (key, values) => new { author = key, High = values.Count() }).OrderByDescending(x => x.High).ToList().First().author);
            Console.WriteLine("\nAutores y cuantos libros han publicado:");
            result.GroupBy(x => x.author, (key, values) => new { author = key, High = values.Count() }).OrderByDescending(x => x.High).ToList().ForEach(y => Console.WriteLine("Autor:{0} ({1} Libros)", y.author, y.High));
            Console.WriteLine("\nLibros publicados hace menos de 50 años:");
            result.Where(book => book.publicationdate >= (DateTime.Now.Year - 50)).ToList().ForEach(newbook => Console.WriteLine(newbook.title));
            Console.WriteLine("\nEl libro mas viejo es:");
            var booksByAge = result.OrderByDescending(book => book.publicationdate).ToList();
            booksByAge.TakeLast(1).ToList().ForEach(result => Console.WriteLine(result.title));
            Console.WriteLine("\nLibros que comienzan con \"El\":");
            result.Where(book => book.title.StartsWith("El")).ToList().ForEach(y => Console.WriteLine(y.title));
        }
    }
}