using BetterCore.Utils;
using BetterFocusPoints.Settings;
using HarmonyLib;
using TaleWorlds.MountAndBlade;

namespace BetterFocusPoints {
    public class SubModule : MBSubModuleBase {

        public static MCMSettings _settings;

		protected override void OnSubModuleLoad() {
			base.OnSubModuleLoad();

			Harmony h = new Harmony("Bannerlord.Shadow.BetterFocusPoints");

            h.PatchAll();
		}

        protected override void OnBeforeInitialModuleScreenSetAsRoot() {
            base.OnBeforeInitialModuleScreenSetAsRoot();

            string modName = base.GetType().Assembly.GetName().Name;

            Helper.SetModName(modName);
            if (MCMSettings.Instance is not null) {
                _settings = MCMSettings.Instance;
            } else {
                Logger.SendMessage("Failed to find settings instance!", Severity.High);
            }
        }
    }
}
