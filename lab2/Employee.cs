using System.Collections.Generic;

namespace lab2
{
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
}
