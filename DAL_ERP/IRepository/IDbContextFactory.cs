using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_ERP.IRepository
{
    public interface IDbContextFactory
    {
        ERPDbContext DbContext { get; }
    }
}
