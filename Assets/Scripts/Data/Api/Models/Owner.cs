namespace Bookarino.Assets.Scripts.Data.Api.Models
{
    public partial class Owner
    {
        public long Id { get; set; }

        public string Username { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public long Score { get; set; }

        public long Subscription { get; set; }
    }
}