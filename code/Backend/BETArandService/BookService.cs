﻿using BETArandDomain;
using BETArandRepo;
using BETArandRepo.OldRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETArandService
{
    public class BookService
    {
        private BookRepo bookRepo;


        public List<Book> GetBooks()
        {
            return bookRepo.GetBooks();
        }

        public static List<User> GetUsers()
        {
            return UserRepo.GetUsers();
        }

        public bool createBooks(Book book)
        {
            if (!ServiceValidations.isbnNotExists(book.ISBN, bookRepo.GetBooks()) ||
                !ServiceValidations.NoEmptyProperties(book))
            {
                return false;
            }
            bookRepo.createBook(book);
            return true;
        }

        public bool createUsers(User user)
        {
            if (!ServiceValidations.isEmailValid(user.Email) ||
                !ServiceValidations.isEmailUnique(user.Email, bookRepo.GetUsers()))
                {
                return false;
            }
            UserRepo.CreateUser(user);
            return true;
        }

        public void updateBook(Book uBook)
        {
            bookRepo.updateBook(uBook);
        }

        public void updateUser(User user)
        {
            bookRepo.updateUser(user);
        }

        public void deleteBook(string ISBN)
        {
            bookRepo.deleteBook(ISBN);
        }

        public void deleteUser(int ID)
        {
            UserRepo.DeleteUser(ID);
        }

        public User Login(string email, string password)
        {
            List<User> users = UserRepo.GetUsers();
            foreach (User user in users)
            {
                if(user.Email == email && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }

        public static void GetPastReq(int id, int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
