using HarmonyLib;
using BetterFocusPoints.Utils;
using BetterFocusPoints.Settings;
using TaleWorlds.MountAndBlade;

namespace BetterFocusPoints {
	public class SubModule : MBSubModuleBase {

		protected override void OnSubModuleLoad() {
			base.OnSubModuleLoad();

			Harmony h = new Harmony("Bannerlord.Shadow.BetterFocusPoints");


            h.PatchAll();
		}

        protected override void OnBeforeInitialModuleScreenSetAsRoot() {
			base.OnBeforeInitialModuleScreenSetAsRoot();

			string modName = base.GetType().Assembly.GetName().Name;

			Helper.SetModName(modName);
			Helper.settings = SettingsManager.Instance;
		}
    }
}
