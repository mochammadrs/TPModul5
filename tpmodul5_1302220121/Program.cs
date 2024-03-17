public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " +  data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataGeneric<string> dataNIM = new DataGeneric<string>("1302220121");
        dataNIM.PrintData();
    }
}