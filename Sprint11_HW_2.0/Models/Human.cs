namespace Sprint11_HW_2._0.Models
{
    public class Human : IHuman
    {
        public Human()
        {
            ID = humanCount++   ;
            FirstName = "Jacob";
            LastName = "Larringston";
            Age = 32;
            Occupation = "Bartender";
        }

        public static int humanCount;

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
        public string Description()
        {
            return $"Hello! I am {FirstName} {LastName}. I am {Age} and my job is {Occupation}";
        }
    }
}