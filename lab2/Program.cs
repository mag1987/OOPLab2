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
            Aquarium aviary = new Aquarium();
            Animal animal = new Animal();
            z.Add(aviary);
            aviary.Add(animal);
            z.Add(animal);
            //aviary.Add(z);
            
        }
    }
}
