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
        public double Salary()
        {

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
    public class Aviary : Container, IContainment
    {
       public int RequiredSpace { get; set; }
    }
    public class Aquarium : Aviary
    {
        public int Temperature { get; set; }
        public int Salinity { get; set; }
    }
    public class Serpentarium:Aviary
    {
        public int Temperature { get; set; }
    }
    public class BirdCage : Aviary
    {
        public int Heihgt { get; set; }
    }
    class Animal:IContainment
    {
       public int RequiredSpace { get; set; }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Zoo z = new Zoo();
            Aviary aviary = new Aviary();
            Animal animal = new Animal();
            z.Add(aviary);
            aviary.Add(animal);
            z.Add(animal);
            //aviary.Add(z);
            
        }
    }
}
