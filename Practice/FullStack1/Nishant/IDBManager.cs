namespace DAL;
using BOL;
public interface IDBManager{
    List<Nishant> GetAll();
    Nishant GetById(int id);
    void InsertNishant(Nishant nishant);
    void DeleteNishant(int id);
    void UpdateNishant(int id,Nishant nishant);
}