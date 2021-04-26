using Apple.Receipt.Verificator.Models;
using Apple.Receipt.Verificator.Models.IAPVerification;
using Refit;
using System.Threading.Tasks;

namespace Apple.Receipt.Verificator.Services
{
    internal interface IProductionRestService
    {
        [Post("")]
        Task<IAPVerificationResponse?> ValidateAppleReceiptAsync(IAPVerificationRequest request);
    }
}
