namespace DAL;
using System.Data;
using MySql.Data.MySqlClient;


public class DBManager
{
    public static string main=@"server=localhost;port=3306;user=root;password=sah_utk;database:DotNet";

    public static bool Insert(Employee emp){
        bool status=false;
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=main;
        string query="insert into Employee(Id,Name,Email,Password) values('"+emp.Id+"','"+emp.Name+"','"+emp.Email+"','"+emp.Password+"'";
        try{
            con.Open();
            MySqlCommand command=new MySqlCommand(query,con);
            command.ExecuteNonQuery();
            status=true;
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
    }

}
