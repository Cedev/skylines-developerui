using ColossalFramework.UI;
using ICities;
using UnityEngine;

namespace DeveloperUIMod
{
    public class LoadingExtension : LoadingExtensionBase
    {
        private ToggleableDeveloperUI toggleableDeveloperUI;

        public override void OnLevelLoaded(LoadMode mode)
        {
            base.OnLevelLoaded(mode);

            Log.Message("OnLevelLoaded");

            var gameObject = new GameObject();
            toggleableDeveloperUI = gameObject.AddComponent<ToggleableDeveloperUI>();

            var infoViewsPanel = GameObject.Find("InfoViewsPanel");
            if (infoViewsPanel == null) {
                Log.Error("Could not find InfoViewsPanel");
                return;
            }

            var uiPanel = infoViewsPanel.GetComponent<UIPanel>();
            if (uiPanel == null) {
                Log.Error("Could not find InfoViewsPanel's UIPanel");
                return;
            }

            uiPanel.eventVisibilityChanged += OnInfoVisibilityChanged;

            Log.Message("uiPanel.isVisible {0}", uiPanel.isVisible);

            toggleableDeveloperUI.visible = !uiPanel.isVisible;
        }

        private void OnInfoVisibilityChanged(UIComponent component, bool value)
        {
            Log.Message("OnInfoVisibilityChanged {0}", value);

            if (toggleableDeveloperUI != null)
            {
                toggleableDeveloperUI.visible = !value;
            }
        }
    }
}
