using Person;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "Hello World!");
List<Employee> employee=new List<Employee>();
employee.Add(new Employee(Empid:1,Ename:"dfghj",designation:"vgbhj",basicSal:845));
employee.Add(new Employee(Empid:3,Ename:"rftg",designation:"grfe",basicSal:2145));
employee.Add(new Employee(Empid:2,Ename:"ujy",designation:"iuy",basicSal:8679));
employee.Add(new Employee(Empid:4,Ename:"hgf",designation:"hgtf",basicSal:5584));
app.MapGet("/Employee",()=>employee);
app.Run();
