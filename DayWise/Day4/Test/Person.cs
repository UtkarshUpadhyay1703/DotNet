namespace humans;
interface IA{
    void lol();
}
class A:IA{
    public void lol(){
        Console.WriteLine("A");
    }
}
interface IB{
    void abc();
}
class B:IB{
    public void abc(){
        Console.WriteLine("B");
    }
}
class AB:IA,IB{
    public void lol(){
        Console.WriteLine("AB");
    }
    public void abc(){
        Console.WriteLine("ab");
    }
}