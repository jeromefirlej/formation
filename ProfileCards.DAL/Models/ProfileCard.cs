namespace ProfileCards.ProfilesManagement.Models
{
    public class ProfileCard : SimpleCard
    {
        public string[] Info { get; set; }

        public Site Site { get; set; }

        public SocialNetwork[] SocialNetwork { get; set; }
    }
}