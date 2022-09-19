namespace Accounting.BLL.Otp.Interfaces;
public interface IOtpService
{
    void Generate(string cellPhoneNumber);

    string GetOtpCode(string cellPhoneNumber);
}
