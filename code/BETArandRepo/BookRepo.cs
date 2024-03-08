using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BETArandDomain;

namespace BETArandRepo
{
    public class BookRepo
    {
        private int userIdCurrent = 1;
        private List<Book> books = new List<Book>();
        private List<User> users = new List<User>();

        public BookRepo()
        {
            createBook(
                new Book(
                    "jacklino",
                    "123fasfafas",
                    "cao azul aprende as cores",
                    "O cao está azul mas queria ser vermelho"
                    )
                );
            createBook(
                new Book(
                    "mANUEL",
                    "2134xbbse",
                    "As aventuras da ex do menezes",
                    "Katakana e companhia e as suas desaventuras"
                    )
                );
            createBook(
                new Book(
                    "cristina ferreira",
                    "tininha1234",
                    "As aventuras do manuel luis goucha",
                    "o manel é lindo e maravilhoso."
                    )
                );
            createUser(new User("SIm", "coiso@gmail.com", "fortniteémau123"));
        }
        public List<Book> GetBooks()
        {
            return books;
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public bool createBook(Book book)
        {
            books.Add(book);
            return true;
        }
        public bool createUser(User user)
        {
            user.Id = userIdCurrent;
            userIdCurrent++;
            users.Add(user);
            return true;
        }
        public void updateUser(User uUser)
        {
            foreach (User user in users)
            {
                if (uUser.Id == user.Id)
                {
                    uUser.Name = user.Name;
                    uUser.Email = user.Email;
                    uUser.Password = user.Password;
                }
            }
        }

        public void updateBook(Book uBook)
        {
            foreach (Book book in books)
            {
                if (book.ISBN == uBook.ISBN)
                {
                    book.Author = uBook.Author;
                    book.Sinopse = uBook.Sinopse;
                    book.Title = uBook.Title;
                }
            }
        }
        public void deleteUser(int Id)
        {
            foreach (User user in users)
            {
                if (user.Id == Id)
                {
                    users.Remove(user);
                    break;
                }
            }
        }

        public void deleteBook(string isbn)
        {
            foreach (Book book in books)
            {
                if (book.ISBN == isbn)
                {
                    books.Remove(book);
                    break;
                }
            }
        }

        /*
         public void updateBook(Book uBook)
        {
            
            Book? bookToUpdate = books.Find(book => book.ISBN == uBook.ISBN);

            if (bookToUpdate == null) return;

            bookToUpdate.Author = uBook.Author;
            bookToUpdate.Title = uBook.Title;
            bookToUpdate.Sinopse=uBook.Sinopse;
        }
         */
    }
}
