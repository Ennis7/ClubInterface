namespace ClubInterface;
interface IClub
{
    //Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //Methods
    public string Fullname();
}

//Class or Structure
class Program
{
    //three public fields or properties
    class Pet : IClub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Animal { get; set; }
        public string PetsName { get; set; }
        public int PetsAge { get; set; }

        //default constructor
        public Pet()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Animal = string.Empty;
            PetsName = string.Empty;
            PetsAge = 0;
        }
        //parameterized constructor
        public Pet(int id, string firstName, string lastName, string animal, string petsName, int petsAge)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Animal = animal;
            PetsName = petsName;
            PetsAge = petsAge;
        }

        public string Fullname()
        {
            return FirstName + " " + LastName;
        }
        //method to display new field
        public string PetId()
        {
            return Id + ": " + Animal + " " + PetsName + " "  + PetsAge; 
        }

    }
    //Main Method:
    static void Main(string[] args)
    {
        //object or structure
        Pet gizmo = new Pet(1, "Sarah", "Ennis", "Dog", "Gizmo", 12);
        //display method in Console.WriteLine
        Console.WriteLine(gizmo.Fullname());
        Console.WriteLine(gizmo.PetId());
        Console.ReadLine();

        //Add data to field or properties
        Pet luna = new Pet();
        luna.Id = 2;
        luna.FirstName = "Sarah";
        luna.LastName = "Ennis";
        luna.Animal = "Cat";
        luna.PetsName = "Luna";
        luna.PetsAge = 11;
        //display method in Console.WriteLine
        Console.WriteLine(luna.Fullname());
        Console.WriteLine(luna.PetId());
        Console.ReadLine();

        
    }
}









   
