using System;
using System.Collections.Generic;
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
            var Vasya = new RatingUser
            {
                Name = "Вася"
            };
            var Maria = new RatingUser
            {
                Name = "Маша"
            };
            var Lena = new RatingUser
            {
                Name = "Лена"
            };
            RatingUser[] users =  { Vasya, Maria, Lena };

            var Frog = new Animal
            {
                ClassName = "Лягушка"
            };
            var Snake = new Animal
            {
                ClassName = "Змея"
            };
            var Bear = new Animal
            {
                ClassName = "Медведь"
            };
            Animal[] animals = {Frog, Snake, Bear };

            var rateSystem = new RatingSystem();
            var recommendingSystem = new RecommendingSystem();
            var top = new Top();

            foreach (var user in users)
            {
                user.RateRequest += rateSystem.RequestHandler;
                user.RecommendRequest += recommendingSystem.Recommend;
                rateSystem.RateUpdated += user.UpdateUserFavourites;
            };
            rateSystem.RateUpdated += top.RequestHandler;
            /* Test rates
             * 
             * user\animal  Frog    Snake   Bear
             * Vasya        2       5       6
             * Maria        3       2       6
             * Lena         4       5       3
             * 
             * ---Average Rate----
             *              3       4       5
             */
            
            Vasya.UserRate(Frog,2);
            Vasya.UserRate(Snake, 5);
            Vasya.UserRate(Bear, 6);
            Maria.UserRate(Frog, 3);
            Maria.UserRate(Snake, 2);
            Maria.UserRate(Bear, 6);
            Lena.UserRate(Frog, 4);
            Lena.UserRate(Snake, 5);
            Lena.UserRate(Bear, 3);

            foreach (var animal in animals)
            {
                Console.WriteLine($"Рейтинг {animal.ClassName} {animal.RateValue}");
            }

            foreach (var user in users)
            {
                user.Recommend(top); 
            }
            
            for (int i = 0; i<3; i++)
            {
                Console.Write($"Пользователю {users[i].Name} рекомндуется ");
                PrintArray(users[i].Recommended);
                Console.WriteLine("");
            }
            

            /*
            Zoo z = new Zoo();
            Aquarium aquarium = new Aquarium();
            //Animal animal = new Animal();
            Employee employee = new Employee(4); 
            z.Add(aquarium);
            aquarium.Add(animal);
            z.Add(animal);
            z.Staff.Add(employee);
            //Console.WriteLine(employee.ProfessionName);
            */

            var r1 = new Aquarium
            {
                RateValue = 4
            };
            var r2 = new Aquarium
            {
                RateValue = 5
            };
            top.Rateables.Add(r1);
            top.Rateables.Add(r2); // list 4, 5
            top.Rateables.Sort(); // 5, 4
            var array = top.Rateables.ToArray();
            //Console.WriteLine(array[0].RateValue);
            //Console.WriteLine(array[1].RateValue);
            /*
            Console.WriteLine("Количество вольеров {0}",z.Content.Count);
            Console.WriteLine("Количество сотрудников {0}", z.Staff.Count);
            Console.WriteLine(aquarium.RateValue);

            Console.WriteLine(animal.RateValue);
            //Console.WriteLine("Рейтинг employee равен {0}", z.Aviaries.Find().RateValue);
            //aviary.Add(z);
            user.UserRate(aquarium);
            Console.WriteLine(aquarium.RateValue);

            Console.WriteLine(animal.RateValue);
            */
             void PrintArray(HashSet<IRateable> ar)
            {
                foreach (var i in ar)
                {
                    Console.Write($"{i.ClassName} ");
                }

            }
        }
        
    }
}
