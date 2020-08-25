namespace BusinessRuleEngine.Services.Contracts.Notification
{
    public interface IEmailService
    {
        void SendMail(string emailId, string subject, string content);
    }
}
