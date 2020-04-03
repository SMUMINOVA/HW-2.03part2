using System;

namespace hw_1._03p2
{
    class Program
    {
        static void Main(string[] args)
        {

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
            public void ShowAuthor(){
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine($"Author of book is {authorOfBook}");
            }
            public void ShowTitle(){
                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.WriteLine($"Title of book is {titleOfBook}");
            }
            public void ShowContent(){
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"Content of book is {contentOfBook}");
            }
        }
    }
}
