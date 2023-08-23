namespace NewApp.Models
{
    public class Student : Person
    {
        public string FullNameCode { get; set;}
        public string Address { get; set;}
        public int Age { get; set;}
        public void enterdata()
        {
            System.Console.Write("Full name =");
            FullName = Console.ReadLine();
            System.Console.Write("Address =");
            Address = Console.ReadLine();
            System.Console.Write("Age =");
            Age = Convert.ToInt16(Console.ReadLine());

        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} -{2} tuoi", FullName, Address, Age);
        }
    }
}