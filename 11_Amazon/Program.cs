namespace _11_Amazon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("amazona hos geldiniz");
                Console.WriteLine("kayit icin 1");
                Console.WriteLine(" giris icin 2");
                Console.WriteLine("cikis icin 3 tuslayiniz");
                string wahl=Console.ReadLine();
                if (wahl != "3")
                {
                    if (wahl=="1")
                    {
                        SignIn signIn=new SignIn();
                        signIn.KullaniciyiKaydet();
                    }
                }
                else break;
            }
           

        }
    }
}
