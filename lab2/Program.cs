using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2

{
    public interface IRateable :IComparable<IRateable>
    {
        string ClassName { get; set; }
        double RateValue { get; set; }
        int Votes { get; set; }
        List<IRatingUser> Users { get; set; }
        
    }
    public interface IRatingUser
    {
        void UserRate(IRateable rateable, IRatingSystem system);
        int UserKarma { get; set; }

        List<IRateable> Recommended { get; set; }
    }
    public interface IRatingSystem
    {
        //double UserVoteWeight(Request request);
        void CalculateRate(Request request);
        Queue<Request> Requests { get; set; }
    }
    public delegate void RequestHandler(Request request);
    public class RatingUser //: IRatingUser
    {
        public event RequestHandler RateRequest;
        public event RecommendingHandler RecommendRequest;
        public void UpdateUserFavourites(Request request)
        {
            if (request.UserRate >= request.Rateable.RateValue)
                Likes.Add(request.Rateable);
            else
                Dislikes.Add(request.Rateable);
        }
        public void UserRate(IRateable rateable)
        {
            Request r = new Request
            {
                User = this,
                UserRate = GetUserRate(),
                Rateable = rateable
            };
            RateRequest.Invoke(r);
        }
        public int UserKarma { get; set; }
        public List<IRateable> Likes { get; set; }
        public List<IRateable> Dislikes { get; set; }
        public List<IRateable> Recommended { get; set; }
        /*
        public void UpdateRecommended(RecommendingSystem rs, Top top)
        {
            Request r = new Request();
            r.UserKarma = UserKarma;
            r.UserRate = GetUserRate();
            r.Recommended = Recommended;
            rs.Requests.Enqueue(r);
            rs.RecommendAll(top);
            
        }
        */
        int GetUserRate()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public void Recommend(Top top)
        {
            Request r = new Request
            {
                User = this
            };
            RecommendRequest.Invoke(r,top);
        }
    }
    public class Request
    {
        public IRateable Rateable { get; set; }
        public RatingUser User { get; set; }
        public int UserRate { get; set; }
    }
    public delegate void RecommendingHandler(Request request, Top top);
    public class RecommendingSystem
    {
        public void Recommend(Request request, Top top)
        {
            int maxRecommend = 5;
            int i = 0;
            request.User.Recommended.Clear();
            foreach (var item in top.Rateables)
            {
                if (i < maxRecommend && i < top.Rateables.Count)
                {
                    if (request.User.Dislikes.Contains(item) == false)
                    {
                        request.User.Recommended.Add(item);
                    }
                    i++;
                }
                else break;
            }
            /*
            foreach (var itemTop in top.Rateables)
            {
                foreach (var itemRecommended in request.Recommended)
                {
                    if (itemTop.ClassName == itemRecommended.ClassName && 
                        itemTop.RateValue >= request.UserRate)
                    {
                        request.Recommended.Add(itemTop);
                    }
                }
            }
            */
        }
        /*
        public void RecommendAll(Top top)
        {
            while (Requests.Count != 0)
            {
                Recommend(Requests.Dequeue(),top);
            }
        }
        */
    }
    public class RatingSystem //: IRatingSystem
    {
        public event RequestHandler RateUpdated;
        public void RequestHandler(Request request)
        {
            CalculateRate(request);
            RateUpdated.Invoke(request);
        }
        public int UserKarmaLimit { get; set; }
        public  double UserVoteWeight(Request request)
        {
            if (request.User.UserKarma > UserKarmaLimit) return 1.0;
            else
            {
                if (request.User.UserKarma > (request.Rateable.RateValue / request.UserRate))
                {
                    return (double)request.User.UserKarma / UserKarmaLimit;
                }
                else
                    return request.Rateable.RateValue / request.UserRate;
            }
        }

        public  void CalculateRate(Request request)
        {
            request.Rateable.RateValue = request.Rateable.RateValue * request.Rateable.Votes / (request.Rateable.Votes + 1) +
            request.UserRate * UserVoteWeight(request) / (request.Rateable.Votes + 1);
        }
        /*
        public void CalculateRate(Request request, Top top)
        {
            CalculateRate(request);
            SendInTop(top,request);
            top.Refresh();
        }
        public void CalculateAllRates()
        {
            while (Requests.Count !=0)
            { 
                CalculateRate(Requests.Dequeue());
            }
        }
        public void CalculateAllRates( Top top)
        {
            while (Requests.Count != 0)
            {
                CalculateRate(Requests.Dequeue(), top);
            }
        }
        public void SendInTop(Top top, Request request)
        {
            if (top.MinRateable.RateValue < request.Rateable.RateValue)
            {
                top.MinRateable = request.Rateable;
            }
        }
        */
    }
    public class Top 
    {
        public void RequestHandler(Request request)
        {
            if (Rateables.Count < NumberOfTop)
            {
                Rateables.Add(request.Rateable);
                Rateables.Sort(SortByRate);
            }
            else
            {
                if (request.Rateable.RateValue > MinRateable.RateValue)
                {
                    Rateables.Remove(Rateables.Last<IRateable>());
                    Rateables.Add(request.Rateable);
                    Rateables.Sort(SortByRate);
                    MinRateable.RateValue = Rateables.Last<IRateable>().RateValue;
                }
            }
        }
        public int SortByRate(IRateable a, IRateable b)
        {
            if (a.RateValue > b.RateValue) { return 1; }
            else
            {
                if (a.RateValue == b.RateValue) { return 0; }
                else { return -1; }
            }
        }
        public List<IRateable> Rateables { get; set; }
        public int NumberOfTop { get; set; }
        public IRateable MinRateable { get; set; }
        /*
        public void Refresh()
        {
            if (Rateables.Count < NumberOfTop)
            {
                Rateables.Add(MinRateable);
            }
            else
            {
                IRateable temp = Rateables.Min<IRateable>();
                if (MinRateable.RateValue > temp.RateValue)
                {
                    Rateables.Remove(temp);
                    Rateables.Add(MinRateable);
                    MinRateable = Rateables.Min<IRateable>();
                }
            }
        }
        */
    }
    public interface IContainment
    {
         int RequiredSpace { get; set; }
    }
    public interface IProfession
    {
        string ProfessionName { get; set; }
    }
    public interface IStaff: IProfession
    {
        int WorkerID { get; }
        int TermOfEmployment { get; set; }
    }
    public interface IGeneratorID
    {
        int GenerateID(object Object);
    }
    public interface IContainer<IContainment>
    {
         int AvailableSpace { get; set; }
         void Add(IContainment containment);
         void Remove(IContainment containment);
    }
    public class Employee : IStaff
    {
        public int WorkerID { get; }
        public int TermOfEmployment { get; set; }
        public string ProfessionName { get; set; }
        public double BaseSalary { get; set; }
        public List<Aviary> AviaryResponsibilities = new List<Aviary>();
        public double Salary()
        {
            return BaseSalary * TermOfEmployment * AviaryResponsibilities.Count;
        }
       
        Employee(int workerID): this (workerID, "none")
        {
        }
        Employee(int workerID, string professionName)
        {
            WorkerID = workerID;
            ProfessionName = professionName;
            BaseSalary = 0;
        }

    }
    public class Container : IContainer<IContainment>
    {
        public int AvailableSpace { get; set; }
        public List<IContainment> Content = new List<IContainment>();
        public void Add(IContainment containment)
        {
            if (containment.RequiredSpace <= AvailableSpace)
            {
                Content.Add(containment);
                AvailableSpace -= containment.RequiredSpace;
            }
        }
        public void Remove(IContainment containment)
        {
            if (Content.Remove(containment) == true)
            {
                AvailableSpace += containment.RequiredSpace;
            }
        }
    }
    public class Zoo : Container
    { 
        
    }
    public  abstract class Aviary : Container, IContainment
    {
       public int RequiredSpace { get; set; }
        public int Temperature { get; set; }
        public virtual int HeatPumpPower()
        {
            return RequiredSpace * Temperature;
        }
    }
    public class Aquarium : Aviary
    {
        public int Salinity { get; set; }
        public override int HeatPumpPower()
        {
            return RequiredSpace * Temperature * Salinity;
        }
    }
    public class Serpentarium:Aviary
    {
       
    }
    public class BirdCage : Aviary
    {
        public int Height { get; set; }
        public override int HeatPumpPower()
        {
            return (RequiredSpace+Height) * Temperature;
        }
    }
    class Animal:IContainment
    {
       public int RequiredSpace { get; set; }
        public List<string> Meals = new List<string>(); 
    }
   
    class Program
    {
        static void Main(string[] args)
        {
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
