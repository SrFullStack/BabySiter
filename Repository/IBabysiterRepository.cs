﻿using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IBabysiterRepository
{
        Task<Babysiter> Get(string Password, string Email);
    }
}
