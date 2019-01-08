namespace lab2
{
    public interface IStaff: IProfession
    {
        int WorkerID { get; }
        int TermOfEmployment { get; set; }
    }
}
