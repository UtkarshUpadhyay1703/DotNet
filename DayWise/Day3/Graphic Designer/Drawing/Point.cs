namespace Drawing;
public class Point
{
    public int X{set;get;}
    public int Y{set;get;}
    public Point(int x,int y){
        this.X=x;
        this.Y=y;
    }
    public override string ToString(){
        return "X = "+X+", Y = "+Y;
    }
}