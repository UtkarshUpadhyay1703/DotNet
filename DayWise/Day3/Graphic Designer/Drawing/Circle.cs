namespace Drawing;
public class Circle:Shapes,IPrintable{
    public Point Radius{set;get;}
    public int Center{set;get;}
    public Circle(){
        Radius=new Point(10,20);
        Center=10;
    }
    public Circle(Point p,int c){
        this.Radius=p;
        this.Center=c;
    }
    public void print(){
        Type t=this.GetType();
        Console.WriteLine("Name = "+t.Name);
        Console.WriteLine("Radius = "+Radius+" Center = "+Center+" Width = "+Width+" Color = "+Color);
    }
    public override void Draw(){
        Type t =this.GetType();
        Console.WriteLine("Name = "+t.Name);
        Console.WriteLine("Radius = "+Radius+" Center = "+Center+" Width = "+Width+" Color = "+Color);
    }
}