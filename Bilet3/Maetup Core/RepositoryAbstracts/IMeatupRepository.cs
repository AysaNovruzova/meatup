using Maetup_Core.Models;
using Meatup_Business.RepositoryAbstracts;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maetup_Core.RepositoryAbstracts
{
    public class IMeatupRepository
    {
        public void Add(Meatup meatup)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public Meatup Get(Func<Meatup, bool>? func)
        {
            throw new NotImplementedException();
        }

        public List<Meatup> GetAll(Func<Meatup, bool>? func)
        {
            throw new NotImplementedException();
        }

        public void Remove(Meatup port)
        {
            throw new NotImplementedException();
        }

       
    }
}


