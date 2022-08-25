// Make a new console application (remember the -f net5.0 flag 
//when running dotnet new console

// You can remove all the code in Program.cs except using System;

// At the bottom of the Program file, define a Book type with 
//some properties you might expect a book to have (Author, title, 
//publishdate, number of pages, whatever you like...). 
//You can use the example at the bottom of chapter 9 as a guide 
//if you're still learning the syntax.

// at the top of the file (after using System;), create three 
//instances of your Book class using the new keyword. You can 
//use the object initialize (the {}) to add values for each of 
//those instances (for example {Title = "20,000 Leagues Under the Sea"}

// Add a constructor that allows you to set the properties on object creation.

// You should now have compiler errors. What are your options for fixing
// the errors? Come up with at least two options, and then pick one
// solution and implement it.

// Create an empty List of Book s.

// Use the Add method to add your three instances to the list.

// Iterate over the list and print "<Title> - by <Author>" or something
// like that for each iteration (react to this post with :book: when you've
// finished this step)

// Bonus: Write a get-only Property for the class to create the string in
// Step 8 for you. The property can be called DisplayName

// Bonus: Use your newly created property in the iteration you wrote in
// step 8 (react with :books: if you finish this step)

/////////////////////////////////////////////////////

//Create a new class called Library (you can put it in Program.cs under 
//the Book class). It should have a Name property 

//Add a private field which is  a List of Books. Give it a 
//good name for a private field.

//Create a method in the Library class called AddBook that takes 
//a Book parameter, and adds the book to the book list

//Create another method called ListLibrary that iterates through 
//the library's books and prints their DisplayName  (see the bonus from yesterday)
//create a library using the Library class, and add books to it using the 
//AddBook and print the library to the console using the ListLibrary method

using System;
using System.Collections.Generic;
// created books
Book book1 = new Book()
{
    Author = "Seth Lewis",
    Title = "The book",
    PublishDate = new DateTime(2022, 8, 24),
    NumberOfPages = 200
};

Book book2 = new Book()
{
    Author = "Seth Lewis' son",
    Title = "The book 2",
    PublishDate = new DateTime(2029, 7, 19),
    NumberOfPages = 168
};

Book book3 = new Book()
{
    Author = "Seth Lewis' grandson",
    Title = "The book 3",
    PublishDate = new DateTime(2038, 8, 12),
    NumberOfPages = 215
};

//list of books
List<Book> bookList = new List<Book>();

// add each book to bookList (similar to array.push() from JS)
bookList.Add(book1);
bookList.Add(book2);
bookList.Add(book3);

foreach (Book book in bookList)
{
    Console.WriteLine($"{book.Title} by {book.Author}");
}

Library bookLibrary = new Library("bookLibrary");

bookLibrary.AddBook(book1);
bookLibrary.AddBook(book2);
bookLibrary.AddBook(book3);

bookLibrary.ListLibrary();

// Book class
public class Book
{
    public Book() { }
    public Book(string author, string title, DateTime publishDate, int pages)
    {
        Title = title;

        Author = author;
        
        PublishDate = publishDate;
        
        NumberOfPages = pages;
    }

    public String DisplayName { get {return $"{Title}-{Author}";}}
    public string Author { get; set; }
    public string Title { get; set; }
    public DateTime PublishDate { get; set; }
    public int NumberOfPages { get; set; }
}

public class Library
{
    public Library(string name)
    {
        name = name;
    }

    public String Name { get; set; }

    private List<Book> _secretBooks = new List<Book>();

    public void AddBook(Book book)
    {
        _secretBooks.Add(book);
    }

    public void ListLibrary()
    {
        foreach (Book secretBook in _secretBooks)
        {
            Console.WriteLine(secretBook.DisplayName);
        }
    }
}