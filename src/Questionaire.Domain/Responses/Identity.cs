using Questionaire.Domain.Shared;

namespace Questionaire.Domain.Responses
{
    public class Identity
    {
        public int IdentityId { get; set; }
        public string IdentityName { get; set; }
        public Department Department { get; set; }
    }
}
