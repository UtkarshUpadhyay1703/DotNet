using BOL;
using DAL;
using System.Collections.Generic;
using System;
Console.WriteLine("Welcome to Employee Signup");
IDBManager dbm=new DBManager();
bool status=true;

while(status){
    Console.WriteLine("Choose Option :");
    Console.WriteLine("1. Display  records");
    Console.WriteLine("2. Insert  new record");
    Console.WriteLine("3. Update existing record");
    Console.WriteLine("4. Delete existing record");
    Console.WriteLine("5. Exit");
    switch(int.Parse(Console.ReadLine())){
        case 1:
        {
            List<Employee> allEmployees=dbm.GetAll();
            foreach(var emp in allEmployees){
            //     Console.WriteLine("ID :"+emp.employee_id+"Name : "+emp.employee_name+"Address : "+emp.employee_address+"Mob No : "+emp.employee_mobile_no+"Aadhar : "+emp.employee_aadhar_no+"Bank Acc No : "+emp.employee_bank_account_no+"Email Id : "+emp.employee_email_id+"Password"+emp.employee_password+"Qualification : "+emp.employee_qualification+"Status : "+emp.employee_status);

            Console.WriteLine("ID : {0}, Name: {1}, Address : {2}, Mob no: {3}, Aadhar : {4}, Account No : {5}, Email : {6}, Password : {7}, Qualification : {8}, Status : {9}",emp.employee_id,
emp.employee_name,
emp.employee_address,
emp.employee_mobile_no,
emp.employee_aadhar_no,
emp.employee_bank_account_no,
emp.employee_email_id,
emp.employee_password,
emp.employee_qualification,
emp.employee_status);

            }

        }
            break;
            case 5:
            status=false;
            break;
    }
}