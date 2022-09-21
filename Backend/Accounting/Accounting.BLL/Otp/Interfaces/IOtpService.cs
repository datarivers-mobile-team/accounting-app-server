namespace Accounting.BLL.Otp.Interfaces;
public interface IOtpService
{
    Task<string> GetOtpCodeAsync(string cellPhoneNumber);
}
