namespace Accounting.Utils;
public class GenerateToken
{
    public static string GenerateUserToken()
    {
        Random generator = new Random();
        return generator.Next(0, 1000000).ToString("D6");
    }
}
