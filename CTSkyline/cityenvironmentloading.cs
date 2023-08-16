using ColossalFramework.UI;
using ICities;

namespace CTenv
{
    public class CTenv : ILoadingExtension
    {
        // called when level loading begins
        public void OnCreated(ILoading loading)
        {
        }

        // called when level is loaded
        public void OnLevelLoaded(LoadMode mode)
        {
            // create dialog panel
            ExceptionPanel panel = UIView.library.ShowModal<ExceptionPanel>("ExceptionPanel");

            // display a message for the user in the panel
            panel.SetMessage("CTenv", "연구 모드가 정상적으로 로딩되었습니다.", false);
        }

        // called when unloading begins
        public void OnLevelUnloading()
        {
        }

        // called when unloading finished
        public void OnReleased()
        {
        }
    }
}