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

    }
}
