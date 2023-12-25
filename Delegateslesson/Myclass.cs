namespace Delegateslesson
{
    public  class Myclass
    {
        public Myclass(params int[] tomonlar) 
        {
            if (Rectangle(tomonlar))
            {
                if (Togritortburchak(tomonlar))
                {
                    Console.WriteLine("Tog'ri tort burchak ");
                }
                else Console.WriteLine("Tog'ri tort burchak emas");
            }
            else Console.WriteLine("tort burchak emas ");
            if (Rectangle(tomonlar))
            {
                Console.Write("Diaganal: ");
                Diaganal(tomonlar);
                Console.Write("Perimetr: ");
                Perimetor(tomonlar);
                Console.Write("Yuzasi: ");
                Yuza(tomonlar);
            }
        }

        public static bool Rectangle(params int[] tomonlar) 
        {
            if (tomonlar.Length == 4) return true;
            return false;
        }
        public static bool Togritortburchak(params int[] tomonlar)
        {
            if (tomonlar[0] == tomonlar[2] && tomonlar[1] == tomonlar[3])
                return true;
            return false;
        }
        public  void Diaganal(params int[] tomonlari) 
        {
            double a = tomonlari[0] * tomonlari[0] + tomonlari[1] * tomonlari[1];
            Console.WriteLine(Math.Sqrt(a));
        }
        public void Perimetor(params int[] tomonlari) 
        {
            Console.WriteLine((tomonlari[0] + tomonlari[1]) * 2);
        }
        public void Yuza(params int[] tomonlari) 
        {
            Console.WriteLine(tomonlari[0] * tomonlari[1]);
        }


    }
}
