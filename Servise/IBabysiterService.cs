using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IBabysiterService
    {
        Task<Babysiter[]> GetAll();

        Task<Babysiter> Get(string Password, string Email);
        Task<Babysiter> Insert(Babysiter babysiter);
        void put(string id, Babysiter babysiter);
        //Task<Babysiter> Mail(RequsetSearchBabysiter requsetSearchBabysiter);
        void Delete(int id );
    }
}
