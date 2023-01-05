namespace Drawing;
    public enum Color{RED,BLUE,GREEN};
public abstract class Shapes{
    public int Width{get;set;}
    public Color Color{set;get;}
    public Shapes(int width,Color color){
        this.Width=width;
        this.Color=color;
    }
    public Shapes(){
        this.Width=45;
        this.Color=GREEN;
    }
    public abstract void Draw();
}