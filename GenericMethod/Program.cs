internal class Program
{
    static void Main(string[] args)
    {
        string a = "3", b = "5";
        Console.WriteLine("test");
        Swap1<string>(ref a,ref b);
        Console.WriteLine(a+ ","+ b);
    }
    //This function is non generic as it does not supported other datatypes of refrence except integer
     static void Swap(ref int x, ref int y)
    {
        int temp=x; x=y; y=temp; y=temp;
    }
    //Swap is now Generic class IT will accept any type of Data
    static void Swap1<T>(ref T x, ref T y)
    {
        T temp = x; x = y; y = temp; y = temp;
    }
}