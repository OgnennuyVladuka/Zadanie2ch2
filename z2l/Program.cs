namespace z2l
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sred = 0;
            double[] cena = new double[20];
            for (int i = 0; i < 20; i++)
            {
                cena[i] = Convert.ToInt32(Console.ReadLine());
                sred = sred + cena[i];
            }
            sred = sred / 20;
            Console.WriteLine("Средняя стоимость товаров: " + sred);
            int kol = 0;
            for (int i = 0;i < 20; i++)
            {
                if (cena[i] < sred)
                {
                    kol++;
                }
            }
            Console.WriteLine("Количество товаров со стоимостью меньше, чем средняя: " + kol);
        }
    }
}