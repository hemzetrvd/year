namespace month
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ayın sıra nömrəsini daxil ed:");
            int aylar = int.Parse(Console.ReadLine());

            switch (aylar)
            {
                case 1:
                    Console.WriteLine("yanvar 31 gün");
                    break;
                case 2:
                    Console.WriteLine("Fevral 29 gün");
                    break;
                case 3:
                    Console.WriteLine("Mart 31 gün");
                    break;
                case 4:
                    Console.WriteLine("Aprel 30 gün");
                    break;
                case 5:
                    Console.WriteLine("May 31 gün");
                    break;
                case 6:
                    Console.WriteLine("İyun 30 gün");
                    break;
                case 7:
                    Console.WriteLine("İyul 31 gün");
                    break;
                case 8:
                    Console.WriteLine("Avqust 31 gün");
                    break;
                case 9:
                    Console.WriteLine("Sentyabr 30 gün");
                    break;
                case 10:
                    Console.WriteLine("Oktyabr 31 gün");
                    break;
                case 11:
                    Console.WriteLine("Noyabr 30 gün");
                    break;
                case 12:
                    Console.WriteLine("Dekabr 31 gün");
                    break;
                default:
                    Console.WriteLine("Düzgün ay nömrəsi daxil et.");
                    break;
            }

        }
    }

}
    

