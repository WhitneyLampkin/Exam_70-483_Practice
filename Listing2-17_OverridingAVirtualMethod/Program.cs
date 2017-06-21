namespace Listing2_17_OverridingAVirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Base
    {
        public virtual int MyMethod()
        {
            return 42;
        }
    }

    class Derived : Base
    {
        public override int MyMethod()
        {
            return base.MyMethod() * 2; 
        }
    }
}
