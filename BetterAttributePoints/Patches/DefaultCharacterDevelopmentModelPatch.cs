using BetterAttributePoints.Utils;
using HarmonyLib;
using TaleWorlds.CampaignSystem.GameComponents;

namespace BetterAttributePoints.Patches {
    [HarmonyPatch(typeof(DefaultCharacterDevelopmentModel))]
    class DefaultCharacterDevelopmentModelPatch {

        [HarmonyPostfix]
        [HarmonyPatch(typeof(DefaultCharacterDevelopmentModel), nameof(DefaultCharacterDevelopmentModel.LevelsPerAttributePoint), MethodType.Getter)]
        public static void LevelsPerAttributePoint(ref int __result) {
            __result = Helper.settings.levelsPerAttributePoint;
        }

        [HarmonyPostfix]
        [HarmonyPatch(typeof(DefaultCharacterDevelopmentModel), nameof(DefaultCharacterDevelopmentModel.MaxAttribute), MethodType.Getter)]
        public static void MaxAttribute(ref int __result) {
            __result = Helper.settings.maxAttributeLevel;
        }
    }
}
