namespace DeveloperUIMod
{
    public class Log
    {
        public static void Error(string format, params object [] args) {
            DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Error, "DeveloperUI Mod: " + string.Format(format, args));
        }

        public static void Message(string format, params object[] args)
        {
#if DEBUG
            DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, "DeveloperUI Mod: " + string.Format(format, args));
#endif
        }
    }
}
