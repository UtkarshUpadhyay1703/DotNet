namespace Game;
public class Player{
    private int Number{set;get;}
    private string Name{set;get;}
    private string Type{set;get;}
    public Player(int Number,string Name,string Type){
        this.Number=Number;
        this.Name=Name;
        this.Type=Type;
    }
    public override string ToString()
    {
        return base.ToString() +"   Number : "+Number+"   Name:   "+Name+"   Type : "+Type;
    }
}