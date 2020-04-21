using System;
using System.Collections.Generic;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> BookList = new List<Book>();

            Console.WriteLine("Welcome to ABC Library System!\n" +
                "1: Add Book\n" +
                "2: Borrow Book\n" +
                "3: Return Book\n" +
                "4: Display List\n" +
                "5: Exit\n" +
                "============================");

            string name;
            string code;
            string author;
            int quantity;
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\nPlease Select an Option");
                int option = Convert.ToInt32(Console.ReadLine());
                
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Book Name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Book Code: ");
                        code = Console.ReadLine();
                        Console.WriteLine("Author Name: ");
                        author = Console.ReadLine();
                        Console.WriteLine("Book Stock: ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        BookList.Add(new Book(name, code, author, quantity));
                        Console.WriteLine("Successfully Book Added in Library!");
                        break;

                    case 2:
                        Console.WriteLine("Book Code: ");
                        code = Console.ReadLine();
                        Console.WriteLine("Borrow Book Quantity: ");
                        quantity = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < BookList.Count; i++)
                        {
                            if (BookList[i].BookCode == code)
                            {
                                if (BookList[i].BookStock >= quantity)
                                {
                                    Console.WriteLine("Successfully Book Borrowed from Library");
                                    BookList[i].BookStock -= quantity;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry Given Quantity is not Available on Stock");
                                }

                                break;
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Book Code: ");
                        code = Console.ReadLine();
                        Console.WriteLine("Return Book Quantity: ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < BookList.Count; i++)
                        {
                            if (BookList[i].BookCode == code)
                            {
                                BookList[i].BookStock += quantity;
                                Console.WriteLine("Successfully Book Returned to library");
                                break;
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Code____Name____Author____Remaining Stock");
                        foreach (var item in BookList)
                        {
                            Console.WriteLine(item.BookCode + "____" + item.BookName + "____" + item.BookAuthor + "____" + item.BookStock);
                        }
                        break;
                    case 5:
                        flag = false;
                        Console.WriteLine("Thank You for using ABC Library System.");
                        break;
                }
            }
        }
    }
}
