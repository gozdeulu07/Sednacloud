﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : class
    {
        
    }
}