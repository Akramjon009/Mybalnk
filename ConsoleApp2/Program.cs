using ConsoleApp2;
string[] studentFirstNames =
            [
                "Alice",
                "Bob",
                "Charlie",
                "David",
                "Emma",
                "Frank",
                "Grace",
                "Henry",
                "Isabel",
                "Jack",
                "Katie",
                "Liam",
                "Mia",
                "Nathan",
                "Olivia",
                "Paul",
                "Quinn",
                "Rachel",
                "Samuel",
                "Tara"
                ];

// Real last names for the students
string[] studentLastNames =
    [
        "Smith",
        "Johnson",
        "Williams",
        "Jones",
        "Brown",
        "Davis",
        "Miller",
        "Wilson",
        "Moore",
        "Taylor",
        "Anderson",
        "Thomas",
        "Jackson",
        "White",
        "Harris",
        "Martin",
        "Thompson",
        "Young",
        "Clark",
        "Walker"
        ];

Student[] unsortedStudents = new Student[20];

for (int i = 1; i <= studentFirstNames.Length; i++)
{
    var student = new Student
    {
        Id = i,
        FirstName = studentFirstNames[i - 1],
        LastName = studentLastNames[i - 1]
    };

    unsortedStudents[i - 1] = student;
}
var sortedStudents = new SortedList<int, Student>();




//1-2 tasks
byte c = 0;
while (c < unsortedStudents.Length)
{
    sortedStudents.Add(unsortedStudents[c].Id, unsortedStudents[c]);
    //Console.WriteLine(unsortedStudents[c].Id + " " + unsortedStudents[c].FirstName + " " + unsortedStudents[c].LastName);
    c++;
}





//3 task
//for (int i = 0; i < unsortedStudents.Length; i++)
//{
//    Console.WriteLine(unsortedStudents[i].Id + " " + unsortedStudents[i].FirstName + " " + unsortedStudents[i].LastName);
//}

int[] ls = [3, 4, 8, 17, 1, 6, 12];
var studentsQueueForFood = new Queue<Student>();



//4 task
foreach (var item in ls)
{
    studentsQueueForFood.Enqueue(sortedStudents[item]);
}






//5 - task
foreach (var item in studentsQueueForFood)
{
    //Console.WriteLine("ID->"+item.Id + "ga ega bo'lgan ovqatga navbatga turdi");

}




//6-task
for (int i = 0; i < 4; i++)
{
    //Console.WriteLine("ID"+studentsQueueForFood.Dequeue().Id + " ga ega bo'lgan student ovqatni oldi");
}



//7-task
var studentsEnrolledMathCourse = new HashSet<Student>();
int[] mathe = [1, 3, 5, 6, 8, 18, 15, 13, 20];
foreach (int i in mathe)
{
    studentsEnrolledMathCourse.Add(sortedStudents[i]);
}




//8-task
var studentsEnrolledEnglishCourse = new HashSet<Student>();
int[] english = [1, 2, 9, 6, 8, 7, 15, 13, 20];
foreach (int i in english)
{
    studentsEnrolledEnglishCourse.Add(sortedStudents[i]);
}





//9-task
//studentsEnrolledEnglishCourse.IntersectWith(studentsEnrolledMathCourse);
foreach (var student in studentsEnrolledEnglishCourse)
{
    //Console.WriteLine(student.Id);
}






//10-task
//studentsEnrolledMathCourse.ExceptWith(studentsEnrolledEnglishCourse);

foreach (var student1 in studentsEnrolledMathCourse)
{
    // Console.WriteLine(student1.Id);
}





//11 - task
studentsEnrolledMathCourse.IntersectWith(studentsEnrolledEnglishCourse);
studentsEnrolledEnglishCourse.ExceptWith(studentsEnrolledMathCourse);
foreach (var student2 in studentsEnrolledEnglishCourse)
{
    //Console.WriteLine(student2.Id);
}




//-12 task
var classJournal = new Dictionary<int, Student>();
foreach (var st in sortedStudents)
{
    classJournal.Add(st.Key, st.Value);
}






//13- task
foreach (var jur in classJournal)
{
    Console.WriteLine(jur.Value.Id + " " + jur.Value.FirstName + " " + jur.Value.LastName);
}