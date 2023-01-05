using BOL;
using System.Collections.Generic;
using System.Text.Json;

// try{
// int option;
// do
// {
//     Console.WriteLine("Enter 1.Add Employee 2.Delete Employee, 3.Display All Employees, 5.Exit");
//     option = Convert.ToInt32(Console.ReadLine());
//     Employees emp=new Employees();
//     switch (option)
//     {
//         case 1:
//             Console.WriteLine("Enter Empid, Ename, designation, joindate, basicSal");
//             emp.AddEmployee(Convert.ToInt32(Console.ReadLine()),Console.ReadLine(),Console.ReadLine(),Double.Parse(Console.ReadLine()));
//             break;

//         case 2:
//             Console.WriteLine("Enter Empid");
//             emp.DeleteEmployee(Convert.ToInt32(Console.ReadLine()));
//             break;

//         case 3:
//             emp.Display();
//             break;
//     }
// } while (option != 5);
// }catch(Exception exp){
//     Console.WriteLine(exp);
// }finally{

// }


try
{
    List<Employees> list = new List<Employees>();
    int option=0;
    do
    {
        Console.WriteLine(
            "Enter 1.Add Employee 2.Delete Employee by id, 3.Display All Employees, 4.Serialize, 5. Deserialize 6.Get by id 7.Update, 10.Exit"
        );

        
        option = int.Parse(Console.ReadLine());
        // Employees emp=new Employees();
        switch (option)
        {
            case 1:{

                 Console.WriteLine("Enter Empid, Ename, designation, basicSal");
                list.Add(
                    new Employees(
                        Convert.ToInt32(Console.ReadLine()),
                        Console.ReadLine(),
                        Console.ReadLine(),
                        Double.Parse(Console.ReadLine())
                    )
                );

            }
               
                break;

            case 2:
                Console.WriteLine("Enter Empid");
                int empid = Convert.ToInt32(Console.ReadLine());
          
          
                foreach (Employees e in list)
                {
                    if (e.Empid == empid)
                    {
                        int index=list.IndexOf(e);
                        // list.Remove(e);
                        list.RemoveAt(index);
                        break;
                    }
                }
                break;

            case 3:
                foreach (Employees e in list)
                {
                    Console.WriteLine(
                        e.Empid + " " + e.Ename + " " + e.designation + " " + e.basicSal
                    );
                }
                break;
            // case 4:
            // var options=new JsonSerializerOptions {IncludeFields=true};
            // var employeeJson=JsonSerializer.Serialize<List<Employees>>(list,options);
            // string fileName=@"D:\Emp.json";
            // File.WriteAllText(fileName,employeeJson);
            // string jsonString=File.ReadAllText(fileName);
            // List<Employees> jsonEmp=JsonSerializer.Deserialize<List<Employees>>(jsonString);
            // Console.WriteLine("\n Json : Deserializing data from json file\n");
            // foreach(Employees e in jsonEmp){
            //     Console.WriteLine(e.Empid+" "+e.Ename+" "+e.designation+" "+e.basicSal);
            // }
            // break;
            case 4:
                var options = new JsonSerializerOptions { IncludeFields = true };
                var employeeJson = JsonSerializer.Serialize<List<Employees>>(list, options);
                string fileName = @"D:\Dot Net\HW\DotNet\DayWise\Day5\employee.json";
                File.WriteAllText(fileName, employeeJson);
                break;
            case 5:
             fileName = @"D:\Dot Net\HW\DotNet\DayWise\Day5\employee.json";
                string jsonString = File.ReadAllText(fileName);
                List<Employees> jsonEmp = JsonSerializer.Deserialize<List<Employees>>(jsonString);
                Console.WriteLine("\n Deserialize data from json file\n");
                foreach (Employees e in jsonEmp)
                {
                    Console.WriteLine(
                        e.Empid + " " + e.Ename + " " + e.designation + " " + e.basicSal
                    );
                }
                break;
                case 6:
                Console.WriteLine("Enter empid");
                int eid=Convert.ToInt32(Console.ReadLine());
                foreach(Employees e in list){
                    if(e.Empid==eid){
                        Console.WriteLine( e.Empid + " " + e.Ename + " " + e.designation + " " + e.basicSal);
                    }
                }
                break;
                case 7:
                Console.WriteLine("Enter id");
                eid=Convert.ToInt32(Console.ReadLine());
                foreach(Employees e in list){
                    if(e.Empid==eid){
                        Console.WriteLine("Enter id");
                        e.Empid=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        e.Ename=Console.ReadLine();
                        Console.WriteLine("Enter Designation");
                        e.designation=Console.ReadLine();
                        Console.WriteLine("Enter Salary");
                        e.basicSal=Convert.ToInt32(Console.ReadLine());
                    }
                }
                break;
        }
    } while (option != 10);
}
catch (Exception exp)
{
    Console.WriteLine(exp);
}
finally { }
