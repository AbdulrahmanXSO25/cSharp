public enum BaseType
{
    Binary = 2,
    Octal = 8,
    Hexadecimal = 16,
    None = 0
}
public class NumberConverter
{

    public ILogger _logger { get; set;}
    public ILogger _writer { get; set;}
    public IReader _reader { get; set;}

    public NumberConverter(ILogger logger, ILogger writer, IReader reader)
    {
        _logger = logger;
        _writer = writer;
        _reader = reader;
    }
    public int DecimalNumber { get; set; }
    public void Convert()
    {

    Console.ForegroundColor = ConsoleColor.Cyan;
    
    _logger.Log("Program is starting...");

    _writer.Log("Enter the number to convert:");

    DecimalNumber = _reader.ReadInt();


    _logger.Log($"The number to convert is: {DecimalNumber}");

    _writer.Log("Enter the base type (Ex: 2,8):");

    var baseType = (BaseType)_reader.ReadInt();

    _logger.Log($"The selected base type is: {baseType.ToString()}");

    var type = ConverterFactory.Create(baseType, DecimalNumber);
    string result = type.Convert();


    _logger.Log($"Using the converter: {type.GetType().ToString().Replace("SOLID.Models", "")}");

    Console.ForegroundColor = ConsoleColor.Magenta;

    _writer.Log($"The result is: {result} ");
    _logger.Log($"The result is: {result} ");
    _logger.Log("Program is ending..");
    _logger.Log("&_________________&\n");

    Console.ForegroundColor = ConsoleColor.White;

    }
}