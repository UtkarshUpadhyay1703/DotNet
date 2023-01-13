namespace DAL.DisConnected;
using BOL;
using System.Data;//for DataSet and for faster fetching
using MySql.Data.MySqlClient;
public  class DBManager{
    //To provide server port user password and database name
    public static string conString=@"server=localhost;port=3306;user=root;password=sah_utk;database=transflower";

    public static List<Department> GetAllDepartments(){
        List<Department> allDepartments=new List<Department>();
        //This is done for connection purpose with database
        MySqlConnection con=new MySqlConnection();
        //To send the connection string to connect with database;
        con.ConnectionString=conString;
        try{
            //creating an empty object of DataSet for storing the result after the query fires 
            DataSet ds=new DataSet();
            //Represents a SQL statement to execute against a MySQL database. This class cannot be inherited.
            MySqlCommand cmd=new MySqlCommand();
            //we are connecting the command line to the database
            cmd.Connection=con;
            //storing the query string into a string
            string query="Select * from departments";
            
            //sending the query to command
            //Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
            cmd.CommandText=query;

            //Represents a set of data commands and a database connection that are used to fill a dataset and update a MySQL database. This class cannot be inherited.
            MySqlDataAdapter da=new MySqlDataAdapter();
            //Sending the command to adapter
            da.SelectCommand=cmd;
            //Catching the result in DataSet
            da.Fill(ds);
            DataTable dt=ds.Tables[0];
            DataRowCollection rows=dt.Rows;
            foreach(DataRow row in rows){
                int id=int.Parse(row["id"].ToString());
                string name=row["name"].ToString();
                string location=row["location"].ToString();
                Department dept=new Department{
                    Id=id,
                    Name=name,
                    Location=location
                };
                allDepartments.Add(dept);
            }
        }
        catch(Exception ee){
            Console.WriteLine(ee.Message);
        }
        return allDepartments;
    }

}