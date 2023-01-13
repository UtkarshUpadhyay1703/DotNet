namespace BLL;
using DAL.DisConnected;
using BOL;
public class HRManager{
    public List<Department> GetAllDepartments(){
        List<Department> allDepartments=new List<Department>();
        allDepartments=DBManager.GetAllDepartments();
        return allDepartments;
    }
}