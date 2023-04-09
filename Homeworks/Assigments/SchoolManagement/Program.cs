/* // See https://aka.ms/new-console-template for more information
using SchoolManagement.DataModule.DataProviders;
using SchoolManagement.DataModule.Models;
using SchoolManagement.ServiceModule.Services;
using SchoolManagement.ServiceModule.Services.PersonService;
using SchoolManagement.ServiceModule.Services.StudentService;
using SchoolManagement.ClientModule.Validations;

Console.WriteLine("Hello, World!");
IDataProvider<Classroom> classdata = new ClassroomDataProvider();
IStudentDataProvider studentdata = new StudentDataProvider();
IStudentService service = new StudentService(studentdata);

Classroom classroom = new Classroom();
Student student = new Student();
Student student2 = new Student();
Console.WriteLine(10000000000.IsIdentityNumberValid());
Console.WriteLine("name".IsNameValid());
Console.WriteLine('2'.IsClassroomValid());
student.IdentityNumber = 22222222222;
student.Id = 1;
student.Name = "TempName";
student.Surname = "TempSurname";
student.SchoolNumber = 1;
student2.IdentityNumber = 22222222222;
student2.Id = 2;
student2.Name = "TempName";
student2.Surname = "TempSurname";
student2.SchoolNumber = 13;
service.Add(student);
service.Add(student2);
Student uStud = new Student{
    Name = "veli",
    Surname = "Ali",
    SchoolNumber = 22,
    IdentityNumber = 33333333333
};
service.Update(1, uStud);
var stud = service.GetByIdentityNumber(22222222222);
string? name = Convert.ToString(Console.ReadLine());
service.GetPeopleByNameOrSurname(name!).ForEach(e => Console.WriteLine($"{e.Id} {e.IdentityNumber} {e.Name} {e.Surname} {e.SchoolNumber}"));
classroom.Id = 1;
classroom.Name = 'A';
studentdata.ReadData();
classroom.Students = new List<Student>();
classroom.Students.Add(stud);
classdata.WriteData(classroom);
IStudentService service2 = new StudentService(studentdata);
var study = service2.GetByIdentityNumber(22222222222);
classroom.Students.Add(student);
classdata.ReadData()?.ForEach(x => 
{
    Console.WriteLine( $"{x.Id} {x.Name}" ); 
    x.Students?.ForEach(y => Console.WriteLine($"{y.Name} {y.IdentityNumber}"));
});
 */

using SchoolManagement.ClientModule.ClassroomClient;
using SchoolManagement.ClientModule.GetInput;
using SchoolManagement.ClientModule.StudentClient;
using SchoolManagement.ClientModule.TeacherClient;
using SchoolManagement.DataModule.DataProviders;
using SchoolManagement.ServiceModule.Services.ClassroomService;
using SchoolManagement.ServiceModule.Services.HomeworkService;
using SchoolManagement.ServiceModule.Services.StudentService;
using SchoolManagement.ServiceModule.Services.TeacherService;

GetStudentInput studentInput = new GetStudentInput();
IClassroomDataProvider classroomDataProvider = new ClassroomDataProvider(); 
IStudentDataProvider studentDataProvider = new StudentDataProvider(); 
IHomeworkDataProvider homeworkDataProvider = new HomeworkDataProvider();
ITeacherDataProvider teacherDataProvider = new TeacherDataProvider();
IHomeworkService homeworkService = new HomeworkService(homeworkDataProvider);
IStudentService studentService = new StudentService(studentDataProvider, homeworkService);
ITeacherService teacherService = new TeacherService(teacherDataProvider);
IClassroomService classroomService = new ClassroomService(classroomDataProvider, studentService, teacherService);
StudentClient studentClient = new StudentClient(studentService); 
GetClassroomInput classroomInput = new GetClassroomInput();
ClassroomClient classroomClient = new ClassroomClient(classroomService); 
GetTeacherInput getTeacherInput = new GetTeacherInput(); 
TeacherClient teacherClient = new TeacherClient(teacherService); 
string choise = string.Empty;
while(choise != "quit")
{
    try
    {
        choise = "Please write operation that you want to make (to quit 'quit')\n".GetString().ToLower();
    }
    catch(Exception err)
    {
        Console.WriteLine(err.Message);
    }
    switch(choise)
    {
        case "add student":
            StudentAdd();
        break;
        case "add classroom":
            ClassroomAdd();
        break;
        case "add teacher":
            AddTeacher();
        break;
        case "get all students data":
            StudentList();
        break;
        case "update student by id":
            UpdateStudent();
        break;
        case "get student by id":
            GetStudentById();
        break;
        case "remove student by id":
            RemoveStudent();
        break;
        case "add student in a class":
            AddStudentToClassroom();
        break;
        case "add teacher in a class":
            ClassroomTeacher();
        break;
        case "find student into a class":
            FindStudentInClass();
        break;
        case "get all classes":
            GetClassrooms();
        break;
    }
}
void AddTeacher()
{
    getTeacherInput.GetAllInputs();
    teacherClient.AddTeacher(getTeacherInput);
}
void ClassroomAdd()
{
    classroomInput.GetAllInputs();
    classroomClient.AddClassroom(classroomInput);
}
void GetClassrooms()
{
    classroomClient.GetAllClassrooms().ForEach(e => e.SendClassroomToWrite());
}
void ClassroomTeacher()
{
    TeacherList();
    GetClassrooms();
    char name = "Enter name value of classroom that you want to add teacher: ".GetChar();
    int id = "Enter id value of teacher that you want to add: ".GetInt();
    try
    { 
        classroomClient.AddTeacherToClassroom(id, name);
    }
    catch(Exception er)
    {
        Console.WriteLine(er.Message);
    }
}
void AddStudentToClassroom()
{
    StudentList();
    GetClassrooms();
    char name = "Enter name value of classroom that you want to add student: ".GetChar();
    int id = "Enter id value of student that you want to add: ".GetInt();
    try
    { 
        classroomClient.AddStudentToClassroom(name, id);
    }
    catch(Exception er)
    {
        Console.WriteLine(er.Message);
    }
}
void FindStudentInClass()
{
    StudentList();
    GetClassrooms();
    char name = "Enter name value of classroom that you want to search student: ".GetChar();
    int id = "Enter id value of student that you want to find: ".GetInt();
    try
    { 
        classroomClient.FindStudentInClassroom(id, name).SendStudentToWrite();
    }
    catch(Exception er)
    {
        Console.WriteLine(er.Message);
    }

}
void TeacherList()
{
    teacherClient.GetAllTeachers().ForEach(e => Console.WriteLine($"id: {e.Id} {e.Name}"));
}
void GetStudentById()
{
    StudentList();
    int id = "Enter id value of student that you want to see: ".GetInt();

    try
    { 
        studentClient.GetStudentById(id);
    }
    catch(Exception er)
    {
        Console.WriteLine(er.Message);
    }
}
void StudentAdd(){
    try
    { 
        studentInput.GetAllInputs();
        studentClient.AddStudent(studentInput);
        
    }
    catch(Exception er)
    {
        Console.WriteLine(er.Message);
    }
} 

void StudentList()
{   
    try
    { 
        studentClient.GetAllStudents().ForEach(e => e.SendStudentToWrite());
    }
    catch(Exception er)
    {
        Console.WriteLine(er.Message);
    }
} 

void UpdateStudent()
{
    StudentList();
    int id = "Enter id value of student that you want to update: ".GetInt();
    studentInput.GetAllInputs();
    try
    { 
        studentClient.UpdateStudent(id, studentInput);
    }
    catch(Exception er)
    {
        Console.WriteLine(er.Message);
    }
}

void RemoveStudent()
{
    StudentList();
    int id = "Enter id value of student that you want to remove: ".GetInt();
    try
    { 
        studentClient.RemoveStudent(id);
    }
    catch(Exception er)
    {
        Console.WriteLine(er.Message);
    }

}