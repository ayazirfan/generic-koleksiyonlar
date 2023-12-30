namespace generic_list;
class Program
{
    static void Main(string[] args)
    {
        
        List<int> numberList = new List<int>();

        numberList.Add(23);
        numberList.Add(10);
        numberList.Add(6);
        numberList.Add(5);
        numberList.Add(92);
        numberList.Add(34);

        List<string> colorList = new List<string>();

        colorList.Add("Red");
        colorList.Add("Blue");
        colorList.Add("Orange");
        colorList.Add("yellow");
        colorList.Add("Green");
        
        //Count
        Console.WriteLine(colorList.Count);
        Console.WriteLine(numberList.Count);

        
        foreach(var number in numberList)
            Console.WriteLine(number);
        
        foreach(var color in colorList)
            Console.WriteLine(color);

        
        numberList.ForEach(number => Console.WriteLine(number));
        colorList.ForEach(color => Console.WriteLine(color));
        
       
        numberList.Remove(5);
        colorList.Remove("Green");

        numberList.ForEach(number => Console.WriteLine(number));
        colorList.ForEach(color => Console.WriteLine(color));

        
        numberList.RemoveAt(0);
        colorList.RemoveAt(2);
        
        numberList.ForEach(number => Console.WriteLine(number));
        colorList.ForEach(color => Console.WriteLine(color));

        
        if(numberList.Contains(34))
            Console.WriteLine("Item found!");

        

        Console.WriteLine(colorList.BinarySearch("Blue"));

        
        string[] animals = {"cat", "dog", "bird"};

        List<string> animalList = new List<string>(animals);

        
        animalList.Clear();

        
        List<Users> UserList = new List<Users>();

        
        Users userOne = new Users();
        userOne.Name = "John";
        userOne.LastName = "Brick";
        userOne.Age = 21;
        
        Users userTwo = new Users();
        userTwo.Name = "Adam";
        userTwo.LastName = "Sm'th";
        userTwo.Age = 32;

        
        UserList.Add(userOne);
        UserList.Add(userTwo);


        
        List<Users> UserListTwo = new List<Users>();
        
        UserListTwo.Add(new Users(){
            Name = "Patrick",
            LastName = "Klein",
            Age = 24
        });
       
        foreach(Users user in UserListTwo)
        {
            Console.WriteLine("Name: " + user.Name);
            Console.WriteLine("LastName: " + user.LastName);
            Console.WriteLine("Age: " + user.Age);
        }

        UserListTwo.Clear();
    }
}

public class Users
{
    string name;
    string lastName;
    int age;


    public string Name {get => name; set => name = value;}
    public string LastName {get => lastName; set => lastName = value;}
    public int Age {get => age; set => age = value;}
}