using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2

{
    public interface IRateable :IComparable<IRateable>
    {
        double RateValue { get; set; }
        int Votes { get; set; }
        List<IRatingUser> Users { get; set; }
        
    }
    public interface IRatingUser
    {
        void UserRate(IRateable rateable, IRatingSystem system);
        int UserKarma { get; set; }
    }
    public interface IRatingSystem
    {
        //double UserVoteWeight(Request request);
        void CalculateRate(Request request);
        Queue<Request> Requests { get; set; }
    }
    public class RatingUser : IRatingUser
    {
        public void UserRate(IRateable rateable, IRatingSystem system)
        {
            Request r = new Request();
            r.UserKarma = UserKarma;
            r.UserRate = GetUserRate();
            r.Rateable = rateable;
            system.Requests.Enqueue(r);
        }
        public int UserKarma { get; set; }
        int GetUserRate()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
    public class Request
    {
        public IRateable Rateable { get; set; }
        public int UserKarma { get; set; }
        public int UserRate { get; set; }
    }
    public class RatingSystem : IRatingSystem
    {
        public  Queue<Request> Requests { get; set; }
        public int UserKarmaLimit { get; set; }
        public  double UserVoteWeight(Request request)
        {
            if (request.UserKarma > UserKarmaLimit) return 1.0;
            else
            {
                if (request.UserKarma > (request.Rateable.RateValue / request.UserRate))
                {
                    return (double)request.UserKarma / UserKarmaLimit;
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
    }
    public class Top 
    {
        public List<IRateable> Rateables { get; set; }
        public int NumberOfTop { get; set; }
        public IRateable MinRateable { get; set; }
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
