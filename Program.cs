using System;

namespace hw_1._03p2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter title of some book: ");
            Title firstT = new Title();
            firstT.title = Console.ReadLine();
            System.Console.Write("Enter author of this book: ");
            Author firstA = new Author();
            firstA.author = Console.ReadLine();
            System.Console.Write("Enter content of this book: ");
            Content firstC = new Content();
            firstC.content = Console.ReadLine();
            Book firstBook = new Book();
            firstBook.authorOfBook = firstA.author;
            firstBook.titleOfBook = firstT.title;
            firstBook.contentOfBook = firstC.content;
            System.Console.WriteLine("As I understand:");
            firstBook.Show();
        }
        
        class Author{
            public string author {get; set;}
            public void Show(){
                System.Console.WriteLine($"Author of book is {author}");
            }
        }
        class Title {
            public string title {get; set;}
            public void Show(){
                System.Console.WriteLine($"Title of book is {title}");
            }
        }
        class Content {
            public string content {get; set;}
            public void Show(){
                System.Console.WriteLine($"Content of book is {content}");
            }
        }
        class Book{
            public string authorOfBook {get; set;}
            public string titleOfBook{get; set;}
            public string contentOfBook{get; set;}
            public void Show(){
                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.WriteLine($"Title of book is {titleOfBook}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine($"Author of book is {authorOfBook}");
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"Content of book is {contentOfBook}");
            }
        }
    }
}
