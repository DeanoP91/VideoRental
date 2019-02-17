using System.Collections.Generic;
using VideoRentalApp.Models;

namespace VideoRentalApp.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}