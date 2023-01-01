public class Reader: IReader
{
    public ILogger _logger {get;}

    public Reader(ILogger logger)
    {
        _logger = logger;
    }
    public int ReadInt()
    {
        try
        {
            string? value = Console.ReadLine();
            return int.Parse(value);
        }
        catch (Exception)
        {
            _logger.Log("The entered value is invalid.");

            return 0;
        }
    }
}