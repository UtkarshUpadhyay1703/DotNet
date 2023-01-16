namespace DAL;
using BOL;
public class DBManager:IDBManager{
    public List<Nishant> GetAll(){
        using(var context=new NishantContext()){
            var nishants=from nis in context.Nishants select nis;
            return nishants.ToList<Nishant>();
        }
    }
    public Nishant GetById(int id){
        using(var context=new NishantContext()){
            var nishant=context.Nishants.Find(id);
            return nishant;
        }
    }
    public void InsertNishant(Nishant nishant){
        using(var context=new NishantContext()){
            context.Nishants.Add(nishant);
            context.SaveChanges();
        }
    }
    public void DeleteNishant(int id){
        using(var context=new NishantContext()){
            context.Nishants.Remove(context.Nishants.Find(id));
            context.SaveChanges();
        }
    }
    public void UpdateNishant(int id,Nishant nishant){
        using(var context=new NishantContext()){
            var nish=context.Nishants.Find(id);
            nish.Id=nishant.Id;
            nish.Name=nishant.Name;
            nish.Email=nishant.Email;
            context.SaveChanges();
        }
    }
}