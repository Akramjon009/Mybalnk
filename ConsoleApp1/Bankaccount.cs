using Bank;

public class Bankaccount 
{
    public delegate double Mybankaccount(double sum, int years);
    public static void Main(string[] args) 
    {

        Kredit kredit = new Kredit();
        while (true)
        {
            Console.WriteLine("wait 4 secod please");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("If you want get \n" +
                "1)Ipoteka kredit\n" +
                "2)Mahina kredit\n" +
                "3)Maqsadsiz kredit\n" +
                "4)Imtiyozli kredit\n" +
                "5)Ta'lim kredit\n" +
                "6)end");
            string ok = Console.ReadLine();

            if (ok == "1")
            {
                #region Ipoteka
                Console.WriteLine("Enter sum ipoteka ");
                double sumipoteka = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter years ipoteka ");
                int yearsipoteka = int.Parse(Console.ReadLine());
                Mybankaccount account = kredit.Ipoteka;
                Console.WriteLine(account(sumipoteka, yearsipoteka));
                #endregion
            }
            else if (ok == "2")
            {
                #region Mashina
                Console.WriteLine("Enter sum mashina ");
                double summashina = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter years mashina ");
                int yearsmashina = int.Parse(Console.ReadLine());
                Mybankaccount account2 = kredit.Mashina;
                Console.WriteLine(account2(summashina, yearsmashina));
                #endregion
            }
            else if (ok == "3")
            {
                #region Maqsadsiz kridit
                Console.WriteLine("Enter sum maqsadsiz kridit ");
                double summaqsadsizkr = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter years maqsadsiz kridit ");
                int yearsmaqsadsizkr = int.Parse(Console.ReadLine());
                Mybankaccount account3 = kredit.Maqsadsizkr;
                Console.WriteLine(account3(summaqsadsizkr, yearsmaqsadsizkr)); ;
                #endregion
            }
            else if (ok == "4")
            {
                #region Imtiyozli kridit
                Console.WriteLine("Enter sum imtiyozli kridit ");
                double sumimtiyozli = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter years imtiyozli kridit ");
                int yearsimtiyozli = int.Parse(Console.ReadLine());
                Mybankaccount account4 = kredit.Imtiyozli;
                Console.WriteLine(account4(sumimtiyozli, yearsimtiyozli));
                #endregion
            }
            else if (ok == "5")
            {
                #region Talim kridit
                Console.WriteLine("Enter sum talim kridit  ");
                double sumtalim = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter years talim kridit ");
                int yearstalim = int.Parse(Console.ReadLine());
                Mybankaccount account5 = kredit.Talimkd;
                Console.WriteLine(account5(sumtalim, yearstalim));
                #endregion
            }
            else if (ok == "6")
            {
                Console.WriteLine("Thank you");
                break;
            }
            else { Console.WriteLine("Error"); }
        }

    }
}