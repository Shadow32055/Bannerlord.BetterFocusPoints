using BetterFocusPoints.Utils;
using HarmonyLib;
using TaleWorlds.CampaignSystem.GameComponents;

namespace BetterFocusPoints.Patches {
    [HarmonyPatch(typeof(DefaultCharacterDevelopmentModel))]
    class DefaultCharacterDevelopmentModelPatch {

        [HarmonyPostfix]
        [HarmonyPatch(typeof(DefaultCharacterDevelopmentModel), nameof(DefaultCharacterDevelopmentModel.FocusPointsPerLevel), MethodType.Getter)]
        public static void FocusPointsPerLevel(ref int __result) {
            __result = Helper.settings.focusPointsPerLevel;
        }

        [HarmonyPostfix]
        [HarmonyPatch(typeof(DefaultCharacterDevelopmentModel), nameof(DefaultCharacterDevelopmentModel.MaxFocusPerSkill), MethodType.Getter)]
        public static void MaxFocusPerSkill(ref int __result) {
            __result = Helper.settings.maxFocusPointsPerSkill;
        }
    }
}
