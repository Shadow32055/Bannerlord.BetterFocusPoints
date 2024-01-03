using BetterCore.Utils;
using HarmonyLib;
using System;
using TaleWorlds.CampaignSystem.GameComponents;

namespace BetterFocusPoints.Patches {
    [HarmonyPatch(typeof(DefaultCharacterDevelopmentModel))]
    class DefaultCharacterDevelopmentModelPatch {

        [HarmonyPostfix]
        [HarmonyPatch(typeof(DefaultCharacterDevelopmentModel), nameof(DefaultCharacterDevelopmentModel.FocusPointsPerLevel), MethodType.Getter)]
        public static void FocusPointsPerLevel(ref int __result) {
            try {
                __result = SubModule._settings.focusPointsPerLevel;
            } catch (Exception e) {
                Logger.SendMessage("DefaultCharacterDevelopmentModel.FocusPointsPerLevel threw exception: " + e, Severity.High);
            }
        }

        [HarmonyPostfix]
        [HarmonyPatch(typeof(DefaultCharacterDevelopmentModel), nameof(DefaultCharacterDevelopmentModel.MaxFocusPerSkill), MethodType.Getter)]
        public static void MaxFocusPerSkill(ref int __result) {
            try {
                __result = SubModule._settings.maxFocusPointsPerSkill;
            } catch (Exception e) {
                Logger.SendMessage("DefaultCharacterDevelopmentModel.MaxFocusPerSkill threw exception: " + e, Severity.High);
            }
        }
    }
}
