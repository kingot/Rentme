using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rentme.Models;
using Rentme.ViewModels;

namespace Rentme.Controllers
{
    public class MoviesController : Controller

    {

        public IActionResult Random()
        {
            var movie = new Movies() {

                Name = "Black Panter & Girls Kassa",
               Id = 200

        };

            var Customers = new List<Customers>
            {
                new Customers{Name = "Customer 1"},
                new Customers{Name="Customer 2"},
                new Customers{Name="Customer 3"}
            };

            var viewModel = new RandomMoviesViewModel {

                Movies = movie,
                Customers = Customers
            };

            return View(viewModel);
         
        }

        // we want to navigate to movies/radmon

       
    }
}