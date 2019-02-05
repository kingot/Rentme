using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rentme.Models;

namespace Rentme.ViewModels
{
    public class RandomMoviesViewModel
    {
        public Movies  Movies { get; set; }
        public List< Customers>  Customers{ get; set; }
    }
}
