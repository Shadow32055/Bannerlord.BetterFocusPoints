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
                __result = BetterFocusPoints.Settings.focusPointsPerLevel;
            } catch (Exception e) {
                NotifyHelper.ReportError(BetterFocusPoints.ModName, "DefaultCharacterDevelopmentModel.FocusPointsPerLevel threw exception: " + e);
            }
        }

        [HarmonyPostfix]
        [HarmonyPatch(typeof(DefaultCharacterDevelopmentModel), nameof(DefaultCharacterDevelopmentModel.MaxFocusPerSkill), MethodType.Getter)]
        public static void MaxFocusPerSkill(ref int __result) {
            try {
                __result = BetterFocusPoints.Settings.maxFocusPointsPerSkill;
            } catch (Exception e) {
                NotifyHelper.ReportError(BetterFocusPoints.ModName, "DefaultCharacterDevelopmentModel.MaxFocusPerSkill threw exception: " + e);
            }
        }
    }
}
