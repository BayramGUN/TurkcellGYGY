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

using SchoolManagement.ClientModule;
using SchoolManagement.ClientModule.GetInput;
using SchoolManagement.ClientModule.StudentClient;
using SchoolManagement.DataModule.DataProviders;
using SchoolManagement.ServiceModule.Services.StudentService;
GetStudentInput studentInput = new GetStudentInput();
IStudentDataProvider dataProvider = new StudentDataProvider(); 
IStudentService service = new StudentService(dataProvider);
StudentClient studentClient = new StudentClient(service); 
RequestPrinter request = new AddRequest();
char choise = ' ';
while(choise != 'Q')
{
    try
    {
        choise = "Lütfen İşlem seçiniz (1-Add student, 2-List students, q- quit) \n".GetChar();
    }
    catch(Exception err)
    {
        Console.WriteLine(err.Message);
    }
    switch(choise)
    {
        case '1':
            request.PrintRequest("student");
            StudentAdd();
        break;
        case '2':
            request = new GetAllRequest();
            request.PrintRequest("student");
            StudentList();
        break;
        case '3':
            request = new UpdateRequest();
            request.PrintRequest("student");
            UpdateStudent();
        break;
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
        studentClient.GetAllStudents().ForEach(x => Console.WriteLine($"data: {x.Name} {x.Surname}"));
    }
    catch(Exception er)
    {
        Console.WriteLine(er.Message);
    }
} 

void UpdateStudent()
{
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