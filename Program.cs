class PemrosesData
{
    public dynamic DapatkanNilaiTerbesar<T>(T x1, T x2, T x3)
    {
        dynamic bilangan1 = x1;
        dynamic bilangan2 = x2;
        dynamic bilangan3 = x3;

        if (bilangan1 > bilangan2 && bilangan1 > bilangan3)
        {
            return bilangan1;
        }
        else if (bilangan2 > bilangan3 && bilangan2 > bilangan1)
        {
            return bilangan2;
        }
        else
        {
            return bilangan3;
        }
    }
}
public class program
    {
        public static void Main() {
            {
                PemrosesData data = new PemrosesData();
                Console.WriteLine("Nilai terbesar adalah: " + data.DapatkanNilaiTerbesar<double>(10, 30, 22));
            }
        }
    }