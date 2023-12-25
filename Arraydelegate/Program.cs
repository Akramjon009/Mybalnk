public class Program
{
    static void Main(string[] args)
    {
        int[] yourarray = [2, 3, 5, 4, 2, 6];
        Func<int[], int[]> name = delegate (int[] arrayname)
        {
            for (int i = 0; i < arrayname.Length; i++)
            {
                arrayname[i] = arrayname[i] * 2;
            }
            return arrayname;
        };

        foreach (var item in name(yourarray))
        {
            Console.WriteLine(item);
        }

    }
}
    