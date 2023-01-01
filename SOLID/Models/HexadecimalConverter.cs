using System.Text;
public class HexadecimalConverter : Converter, IHexadecimalConverter
{
    public HexadecimalConverter(int decimalNumber)
    : base(decimalNumber)
    {
    }

    public override string Convert()
    {
        return $"The Result is: {DecimalNumber.ToString("X")}";
    }

    public string HexadecimalToText(string text)
    {
        text = text.Replace(" ", "");

        byte[] raw = new byte[text.Length / 2];

        for (int i = 0; i < raw.Length; i++)
        {
        raw[i] = System.Convert.ToByte(text.Substring(i * 2, 2), 16);
        }

        return Encoding.ASCII.GetString(raw);
    }

    public string TextToHexadecimal(string text)
    {
        byte[] bytes = Encoding.ASCII.GetBytes(text);

        var hexString = BitConverter.ToString(bytes);

        hexString = hexString.Replace("-", "");
        
        return hexString;
    }
}  