using HarmonyLib;
using MoreAttributePoints.Utils;
using MoreAttributePoints.Settings;
using TaleWorlds.MountAndBlade;

namespace MoreAttributePoints {
	public class SubModule : MBSubModuleBase {

		protected override void OnSubModuleLoad() {
			base.OnSubModuleLoad();

			Harmony h = new Harmony("Bannerlord.Shadow.MoreAttributePoints");

            //*** Manual patching reference
            //MethodInfo original = typeof(Hero).GetProperty("AddSkillXp").GetGetMethod();
            //MethodInfo postfix = typeof(XPPatch).GetMethod("AddSkillXp");
            //h.Patch(original, postfix: new HarmonyMethod(postfix));

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
