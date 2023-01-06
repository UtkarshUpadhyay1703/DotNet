using System.Collections.Generic;
using Person;
List<Object> list=new List<Object>();
list.Add(234);
list.Add("ghjk");

// list.Add(new Employee() { Id=1, Name="fgh", Desg="dfghj" });

// List<Employee> emp=new List<Employee>();

// emp.Add(new Employee() { Id=1, Name="fgh", Desg="dfghj" });

foreach(Object l in list){
    Console.WriteLine(l);
}

List<Employee> employee=new List<Employee>();
employee.Add(new Employee(2,"hghkjj","tfgjhkjyu"));
employee.Add(new Employee(1,"hj","tfyu"));

foreach(Employee emp in employee){
    Console.WriteLine(emp);
}

Dictionary<int,Employee> empl=new Dictionary<int,Employee>();
empl.Add(2,new Employee(2,"hghkjj","tfgjhkjyu"));
empl.Add(1,new Employee(1,"hj","tfyu"));
foreach(var e in empl){
    Console.WriteLine(e);
}


Console.WriteLine(empl[1]);


EmpComparer ec=new EmpComparer();
employee.Sort(ec);
foreach(var e in employee){
    Console.WriteLine(e);
}






