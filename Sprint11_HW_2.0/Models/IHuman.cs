namespace Sprint11_HW_2._0.Models
{
    public interface IHuman
    {
        int ID { get; set; }
        int Age { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Occupation { get; set; }

        string description()
        {
            return $"Hello! I am {FirstName} {LastName}. I am {Age} and my job is {Occupation}";
        }
    }
}
