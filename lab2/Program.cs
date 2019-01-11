using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public delegate void RequestHandler(Request request);
    public delegate void RecommendingHandler(Request request, Top top);
   
    class Program
    {
        static void Main(string[] args)
        {
            var user = new RatingUser();
            var rateSystem = new RatingSystem();
            var recommendingSystem = new RecommendingSystem();
            var top = new Top();

            user.RateRequest += rateSystem.RequestHandler;
            user.RecommendRequest += recommendingSystem.Recommend;
            rateSystem.RateUpdated += user.UpdateUserFavourites;
            rateSystem.RateUpdated += top.RequestHandler;

            Zoo z = new Zoo();
            Aquarium aquarium = new Aquarium();
            Animal animal = new Animal();
            Employee employee = new Employee(4); 
            z.Add(aquarium);
            aquarium.Add(animal);
            z.Add(animal);
            z.Staff.Add(employee);
            //Console.WriteLine(employee.ProfessionName);
            Console.WriteLine("Количество вольеров {0}",z.Content.Count);
            Console.WriteLine("Количество сотрудников {0}", z.Staff.Count);
            Console.WriteLine(aquarium.RateValue);

            Console.WriteLine(animal.RateValue);
            //Console.WriteLine("Рейтинг employee равен {0}", z.Aviaries.Find().RateValue);
            //aviary.Add(z);
            user.UserRate(aquarium);
            Console.WriteLine(aquarium.RateValue);

            Console.WriteLine(animal.RateValue);

        }
    }
}
