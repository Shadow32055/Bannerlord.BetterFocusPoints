using MoreAttributePoints.Utils;
using System;
using TaleWorlds.CampaignSystem;

namespace MoreAttributePoints.Custom {
    public class AddAttributePoints : CampaignEventReceiver {

        public override void OnHeroLevelledUp(Hero hero, bool shouldNotify = true) {
            base.OnHeroLevelledUp(hero, shouldNotify);
            hero.HeroDeveloper.UnspentAttributePoints = hero.HeroDeveloper.UnspentAttributePoints + Helper.settings.extraAttPointsPerLevel;
        }
    }
}
