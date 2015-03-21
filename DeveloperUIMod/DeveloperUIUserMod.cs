using ICities;

namespace DeveloperUIMod
{
    public class DeveloperUIUserMod : IUserMod
    {

        public string Description
        {
            get { return "Opens the developer UI tools"; }
        }

        public string Name
        {
            get { return "DeveloperUI"; }
        }
    }
}
