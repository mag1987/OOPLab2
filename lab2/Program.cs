using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2

{
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
