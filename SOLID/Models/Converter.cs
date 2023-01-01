public abstract class Converter
{
    public int DecimalNumber { get; set; }

    public Converter(int decimalNumber)
    {
        DecimalNumber = decimalNumber;
    }

    public abstract string Convert();
}