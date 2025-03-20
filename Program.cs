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

class SimpleDataBase<T>
{
    List<T> storedData;
    List<DateTime> inputDates;

    public SimpleDataBase()
    {
        inputDates = new List<DateTime>();
        storedData = new List<T>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
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
            
            SimpleDataBase<string> simpleDataBase = new SimpleDataBase<string>();
            simpleDataBase.PrintAllData();
        }
    }