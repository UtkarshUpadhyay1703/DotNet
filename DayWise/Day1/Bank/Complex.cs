namespace Maths;
public class Complex{
    private int real;
    private int imaginary;
    public Complex(int real,int imaginary){
        this.real=real;
        this.imaginary=imaginary;
    }
    public Complex(){
        this.real=10;
        this.imaginary=10;
    }
    public int Real{
        set{this.real=value;}
        get{return this.real;}
    }
    public int Imaginary{
        set{this.imaginary=value;}
        get{return this.imaginary;}
    }
    public static Complex operator+(Complex c1,Complex c2){
        Complex temp=new Complex();
        temp.real=c1.real+c2.real;
        temp.imaginary=c1.imaginary+c2.imaginary;
        return temp;
    }
}