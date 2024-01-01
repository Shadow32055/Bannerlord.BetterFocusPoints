using HarmonyLib;
using MoreAttributePoints.Utils;
using MoreAttributePoints.Settings;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using MoreAttributePoints.Custom;

namespace MoreAttributePoints {
	public class SubModule : MBSubModuleBase {

		protected override void OnSubModuleLoad() {
			base.OnSubModuleLoad();

			Harmony h = new Harmony("Bannerlord.Shadow.MoreAttributePoints");


            h.PatchAll();
		}

        protected override void OnGameStart(Game game, IGameStarter gameStarter) {
            base.OnGameStart(game, gameStarter);

            if (game.GameType is Campaign) {
                Campaign campaign = (Campaign)game.GameType;

                if (campaign != null) {
                    campaign.AddCampaignEventReceiver(new AddAttributePoints());
                }
            }
        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot() {
			base.OnBeforeInitialModuleScreenSetAsRoot();

			string modName = base.GetType().Assembly.GetName().Name;

			Helper.SetModName(modName);
			Helper.settings = SettingsManager.Instance;
		}
    }
}
