using G4Guidance.Models.Interface;
using Microsoft.AspNetCore.Http;
namespace G4Guidance.Models.Repository
{
    public class CurrentUserService:ICurrentUserService
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor=httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }
        public string GetCurrentUsername()
        {
            return httpContextAccessor.HttpContext.Request.Cookies["username"];
        }
    }
}
