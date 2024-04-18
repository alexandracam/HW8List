// Alexandra Camarena
// MIS 3013 HW8 List

List<Student> stuList;
stuList = new List<Student>();// empty <> null

Console.WriteLine("Would you like to add another student? (yes/no) ");
string userInput = Console.ReadLine();
string m;
while (userInput.ToLower() == "yes"||userInput.ToLower() == "y")
{
    m = string.Format($"Please input student {stuList.Count + 1} ID: ");
    Console.Write(m);
    string id = Console.ReadLine();

    m = string.Format($"Please input student {stuList.Count+1} name: ");
    Console.Write(m);
    string name = Console.ReadLine();

    m = string.Format($"Please input student {stuList.Count + 1} favorite thing: ");
    Console.Write(m);
    string favoriteThing = Console.ReadLine();

    Student newstu = new Student();
    newstu.id = id;
    newstu.name = name;
    newstu.favoriteThing = favoriteThing;

    stuList.Add(newstu);

    Console.Write("Would you like to add another student? (yes/no) ");
    userInput = Console.ReadLine();
}

Console.WriteLine("Students in the normal order: ");
for (int i = 0; i < stuList.Count; i++)
{
    m = string.Format($"Student {i+1}, ID: {stuList[i].id}, name: {stuList[i].name}, favorite thing: {stuList[i].favoriteThing}");
    Console.Write(m);
}

Console.WriteLine("Students in the reverse order: ");
for (int i = stuList.Count - 1; i >= 0 ; i--)
{
    m = string.Format($"Student {i + 1}, ID: {stuList[i].id}, name: {stuList[i].name}, favorite thing: {stuList[i].favoriteThing}");
    Console.Write(m);
}

Console.WriteLine("Students in every other order: ");
for (int i = 0; i < stuList.Count; i=i + 2)// i++ i=1+1
{
    m = string.Format($"Student {i + 1}, ID: {stuList[i].id}, name: {stuList[i].name}, favorite thing: {stuList[i].favoriteThing}");
    Console.Write(m);
}

m = string.Format($"\nThe number of students in the list is {stuList.Count}");
Console.WriteLine(m);
public class Student
{
    public string id;
    public string name;
    public string favoriteThing;
}