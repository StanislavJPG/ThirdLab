class A
{
    public int x;
    public int y;
}

class B
{
    static void Main(string[] args)
    {
        A a = new A();
        a.x = 4;
        a.y = 2;


        A a2 = new A();
        a.x = 3;
        a.y = 9;

    }
}

class C
{
    static void Main(string[] args)
    {
        A a = new A();
        a.x = 13;
        a.y = -2;

        A a2 = new A();
        a.x = 7;
        a.y = 8;
    }
}