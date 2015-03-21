using System;
using System.Reflection;

namespace DeveloperUIMod
{
    public class ToggleableDeveloperUI : DeveloperUI
    {
        public bool visible = true;
        private static MethodInfo baseOnGUI = typeof(DeveloperUI).GetMethod("OnGUI", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        public ToggleableDeveloperUI()
        {
            if (baseOnGUI == null)
            {
                Log.Error("Could not find DeveloperUI's OnGUI method");
            }
        }

        public void OnGUI()
        {
            if (visible && baseOnGUI != null)
            {
                try
                {
                    baseOnGUI.Invoke(this, new object[] { });
                }
                catch (ArgumentException)
                {
                    // DeveloperUI's OnGUI throws exceptions the first time it runs.
                    // Don't let them open the debug panel.
                }
            }

        }
    }
}
