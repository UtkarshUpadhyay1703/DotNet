namespace Employee.Models;
using System.Text.Json;
using System.Collections.Generic;

public static class EmployeeManager{
    public static void AddEmployee(Employees emp){
    List<Employees> list = new List<Employees>();
    string fileName=@"D:\Dot Net\HW\DotNet\DayWise\Day9\Employee\Emp.json";
    string jsonString=File.ReadAllText(fileName);
    List<Employees> jsonEmp=JsonSerializer.Deserialize<List<Employees>>(jsonString);
    list.Add(emp);
    var options=new JsonSerializerOptions { IncludeFields=true};
    var employeejson=JsonSerializer.Serialize<List<Employees>>(list,options);
    File.WriteAllText(fileName,employeejson);
    Console.WriteLine("Serialization Done");
    }
    
    public static void Display(){
    string fileName=@"D:\Dot Net\HW\DotNet\DayWise\Day9\Employee\Emp.json";
    string jsonString=File.ReadAllText(fileName);
    List<Employees> jsonEmp=JsonSerializer.Deserialize<List<Employees>>(jsonString);
    Console.WriteLine("Deserialize done");
    foreach(Employees e in jsonEmp){
        Console.WriteLine(e.Empid + " " + e.Ename + " " + e.designation + " " + e.basicSal);
    }
    }
}