namespace DAL;
using BOL;
public class DBManager:IDBManager{
    // public void Delete(int id){
    //     using(var context=new CollectionContext()){
    //         context.Employees.Remove(context.Departments.Find(id));
    //         context.SaveChanges();
    //     }
    // }

    public List<Employee> GetAll(){
        using(var context=new CollectionContext()){
            var employees=from emp in context.Employees select emp;
            return employees.ToList<Employee>();//tolist(), used to convert the data elements of an array into a list.            
        }
    }
}