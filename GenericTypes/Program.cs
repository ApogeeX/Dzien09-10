using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var resultsRestaurant = new PaginatedResults<Restaurant>();
            var resultsUser = new PaginatedResults<User>();

            var stringRepo = new Repository<string>();
            stringRepo.AddElement("Hello world!");

            var userRepo = new Repository<User>();
            userRepo.GetElement(-1);

            var restRepo = new Repository<string, Restaurant>();
            restRepo.AddElement("KFC", new Restaurant());
        }
    }
}
