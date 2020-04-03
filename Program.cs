using System;

namespace hw_1._03p2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter title of some book: ");
            Book first = new Book();
            first.titleOfBook.title = Console.ReadLine();
            System.Console.Write("Enter author of this book: ");
            first.authorOfBook.author = Console.ReadLine();
            System.Console.Write("Enter content of this book: ");
            first.contentOfBook.content = Console.ReadLine();
            System.Console.WriteLine("As I understand:");
            first.titleOfBook.Show();
            first.authorOfBook.Show();
            first.contentOfBook.Show();
        }
        
        class Author{
            public string author {get; set;}
            public void Show(){
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine($"Author of book is {author}");
            }
        }
        class Title {
            public string title {get; set;}
            public void Show(){
                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.WriteLine($"Title of book is {title}");
            }
        }
        class Content {
            public string content {get; set;}
            public void Show(){
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"Content of book is {content}");
            }
        }
        class Book{
            public Author authorOfBook = new Author();
            public Title titleOfBook = new Title();
            public Content contentOfBook = new Content();
        }
    }
}
