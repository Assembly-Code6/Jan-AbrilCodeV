﻿using System;
using BETArandRepo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BETArandDomain;

namespace BETArandService
{
    internal class ServiceValidations
    {
        BookRepo repo;
        public ServiceValidations(BookRepo repo)
        {
            this.repo = repo;
        }

        public bool isbnNotExists(string isbn)
        {
            foreach (Book book in repo.GetBooks())
            {
                if (book.ISBN == isbn)
                {
                    return false;
                }
            }
            return true;
        }

        internal bool NoEmptyProperties(Book book)
        {
            return
                book.ISBN != "" &&
                book.Title != "" &&
                book.Author != "" &&
                book.Sinopse != "";
        }
    }
}
