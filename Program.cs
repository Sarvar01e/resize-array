namespace resize_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraysize = 3;
            int[] array = new int[arraysize];
            Console.WriteLine(array.Length);
            resizes(ref array);
            Console.WriteLine(array.Length);
        }

        static void resizes(ref int[] for_resize) 
        {
            Console.WriteLine("Enter new size");
            int newsize = int.Parse(Console.ReadLine());
            int[] resizedarray = new int[newsize];
            for_resize = resizedarray;
        }
    }
}