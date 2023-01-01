namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberConverter converter = new NumberConverter(new TextFileLogger(), new Logger(), new Reader(new Logger()));
            converter.Convert();
        }
    }
}