namespace lab2;

class StudentManagementSystem
{
    private List<(int GroupId, string GroupName)> groups = new List<(int, string)>();
    private List<(int StudentId, string FullName, int GroupId)> students = new List<(int, string, int)>();

    public void AddGroup(int groupId, string groupName)
    {
        groups.Add((groupId, groupName));
    }

    public void AddStudent(int studentId, string fullName, int groupId)
    {
        students.Add((studentId, fullName, groupId));
    }

    public void RemoveGroup(int groupId)
    {
        groups.RemoveAll(g => g.GroupId == groupId);
        students.RemoveAll(s => s.GroupId == groupId);
    }

    public void RemoveStudent(int studentId)
    {
        students.RemoveAll(s => s.StudentId == studentId);
    }

    public void PrintStudents()
    {
        foreach (var student in students)
        {
            var groupName = groups.FirstOrDefault(g => g.GroupId == student.GroupId).GroupName;
            Console.WriteLine($"ID: {student.StudentId}, Name: {student.FullName}, Group: {groupName}");
        }
    }

    public void PrintStudentsByGroupName(string groupName)
    {
        var groupId = groups.FirstOrDefault(g => g.GroupName == groupName).GroupId;
        var groupStudents = students.Where(s => s.GroupId == groupId);

        foreach (var student in groupStudents)
        {
            Console.WriteLine($"ID: {student.StudentId}, Name: {student.FullName}");
        }
    }
    
}

class Test
{
    static void Main()
    {
        StudentManagementSystem sms = new StudentManagementSystem();
        
        sms.AddGroup(1, "Software Engineering");
        sms.AddGroup(2, "Computer Science");
        
        sms.AddStudent(101, "Daniil Tereshchenko", 1);
        sms.AddStudent(102, "Alex Alex", 2);
        
        Console.WriteLine("Всі студенти:");
        sms.PrintStudents();
        
        Console.WriteLine("\nСтуденти групи 'Computer Science':");
        sms.PrintStudentsByGroupName("Computer Science");
        
        sms.AddStudent(103, "Mike Smith", 1);
        Console.WriteLine("\nПісля додавання нового студента:");
        sms.PrintStudents();

        sms.RemoveStudent(103);
        Console.WriteLine("\nПісля видалення студента:");
        sms.PrintStudents();
        
        sms.AddGroup(3, "Data Science");
        sms.AddStudent(104, "Anna Brown", 3);
        Console.WriteLine("\nПісля додавання групи 'Data Science' та студента:");
        sms.PrintStudents();

        sms.RemoveGroup(3);
        Console.WriteLine("\nПісля видалення групи 'Data Science' та її студентів:");
        sms.PrintStudents();
    }
}
