﻿using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IBabysiterRepository
{
        //Task<Babysiter[]> GetAll([FromQuery] int? age, [FromQuery] int? price);
        Task<Babysiter> Get(string Password, string Email);
        Task<Babysiter> Insert(Babysiter babysiter);
         Task<Babysiter> put(string id, Babysiter babysiter);
        Task Delete(int id);


    }
}
