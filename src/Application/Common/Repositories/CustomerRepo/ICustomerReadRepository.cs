﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Repositories.CustomerRepo
{
    public interface ICustomerReadRepository : IReadRepository<Customer>
    {
    }
}