﻿using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IBabysiterService
    {
        Task<Babysiter> Get(string Password, string Email);
        Task<Babysiter> Insert(Babysiter babysiter);
    }
}
