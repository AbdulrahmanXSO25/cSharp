public class InvalidBaseConverter: Converter
{
    public InvalidBaseConverter(int decimalNumber) :base(decimalNumber)
    {
    }
    public override string Convert()
    {
        return "This Type is not a valid base \n";
    }
}