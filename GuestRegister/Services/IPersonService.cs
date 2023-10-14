using GuestRegisterModels;

namespace GuestRegister.Services
{
    public interface IPersonService
    {
        
            Task<List<Person>> getPerson();

        
    }
}
