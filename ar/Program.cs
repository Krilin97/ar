namespace ar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            String cadena;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Dime numero["+i+"]: ");
                cadena = Console.ReadLine();
                array[i] = int.Parse(cadena);
            }

            for (int i = 0;i < array.Length;i++)
            {
                Console.Write(array[i]);
            }
            Console.ReadKey();
        }
    }
}