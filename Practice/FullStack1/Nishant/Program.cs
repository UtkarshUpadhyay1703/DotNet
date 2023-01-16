using BOL;
using DAL;
using System.Collections.Generic;
using System;
Console.WriteLine("Welcome Nishant");
IDBManager dbm=new DBManager();
bool status=true;

while(status){
    Console.WriteLine("Choose Option :");
    Console.WriteLine("1. Display  records");
    Console.WriteLine("2. Display  By Id");
    Console.WriteLine("5. Exit");
    switch(int.Parse(Console.ReadLine())){
        case 1:
        {
            List<Nishant> list=dbm.GetAll();
            foreach(var nish in list){
                Console.WriteLine("Id : "+nish.Id+"Name : "+nish.Name+"Email : "+nish.Email);
            }
        }
        break;
        case 2:
        Console.WriteLine("Enter Id ");
        int id=int.Parse(Console.ReadLine());
        Nishant nishant=dbm.GetById(id);
        Console.WriteLine(nishant);
        break;
        case 5:
        status=false;
        break;
    }
}