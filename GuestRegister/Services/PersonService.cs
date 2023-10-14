using GuestRegisterModels;

namespace GuestRegister.Services
{
    public class PersonService : IPersonService
    {
        private readonly HttpClient httpClient;

        public PersonService(HttpClient httpClient)
        {
            this.httpClient= httpClient;    
        }
        public async Task<List<Person>> getPerson()
        {
            return await httpClient.GetFromJsonAsync<List<Person>>("api/Person/getPerson");
        }

       
    }
}
