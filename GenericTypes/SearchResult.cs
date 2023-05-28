using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    public interface IEntity
    {
        int Id { get; set; }    
    }

    public class User : IEntity
    {
        public int Id { get; set; }
    }

    public class Restaurant : IEntity
    {
        public int Id { get; set; }
    }

    public class UserResults
    {
        public List<User> Users { get; set; }
        public int ResultsFrom { get; set; }
        public int ResultsTo { get; set; }
        public int TotalResults { get; set; }
    }

    public class RestaurantResults
    {
        public List<Restaurant> Restaurant { get;}
        public int ResultsFrom { get; set; }
        public int ResultsTo { get; set; }
        public int TotalResults { get; set; }
    }

    public abstract class AbstractResults
    {
        public int ResultsFrom { get; set; }
        public int ResultsTo { get; set; }
        public int TotalResults { get; set; }
    }

    public class UserAbstractResults : AbstractResults
    {
        List<User> Users { get; set; }
    }

    public class RestaurantAbstractResults : AbstractResults
    {
        List<Restaurant> Restaurants { get; set; }
    }
}

