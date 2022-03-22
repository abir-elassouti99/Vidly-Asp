using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly1.Models;
namespace Vidly1.ViewModel
{
    public class CustomerMovieViewModel
    {
        public List<Movie> Movies = new List<Movie>() ;
        public List<Customer> Customers = new List<Customer>() ;
    }
}