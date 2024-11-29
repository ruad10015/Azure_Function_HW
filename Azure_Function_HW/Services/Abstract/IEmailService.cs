namespace Azure_Function_HW.Services.Abstract;

public interface IEmailService
{
    Task SendEmailAsync(string toEmail, string subject, string body);
}

