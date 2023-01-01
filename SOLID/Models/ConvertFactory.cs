public static class ConverterFactory
{
    public static Converter Create(BaseType baseType, int decimalNumber)
    {
        if (baseType == BaseType.Binary)
        return new BinaryConverter(decimalNumber);

        else if (baseType == BaseType.Octal)
        return new OctalConverter(decimalNumber);

        else if (baseType == BaseType.Hexadecimal)
        return new HexadecimalConverter(decimalNumber);

        else return new InvalidBaseConverter(decimalNumber);
    }
}

/*
try
        {
            return (Converter)
            Activator.CreateInstance(
            Type.GetType($"SOLID.{baseType.ToString()}Converter"),
            new object[] { decimalNumber });
        }
catch (Exception)
        {
        return null;
        }
*/