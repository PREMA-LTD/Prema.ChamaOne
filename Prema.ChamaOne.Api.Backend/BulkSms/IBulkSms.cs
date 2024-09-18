namespace Prema.ChamaOne.Api.Backend.BulkSms
{
    public interface IBulkSms
    {
        Task<bool> SendSms(string recipient_contact, string recipient_name, string message);
        Task<bool> ResendSms(int smsRecordId);
        Task<int> GetBalance();
    }
}
