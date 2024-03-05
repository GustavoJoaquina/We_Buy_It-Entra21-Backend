using PI_Entra21_Back_end.DTO;

namespace PI_Entra21_Back_end.Contracts.Repository
{
    public interface IpaymentmethodRepository
    {
        Task Add(PaymentDTO payment);

    }
}
