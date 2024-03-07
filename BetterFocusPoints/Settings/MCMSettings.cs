using BetterFocusPoints.Localizations;
using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace BetterFocusPoints.Settings {

    public class MCMSettings : AttributeGlobalSettings<MCMSettings> {


        [SettingPropertyGroup(RefValues.FocusText)]
        [SettingPropertyInteger(RefValues.FocusPerLevelText, 0, 100, "0", Order = 0, RequireRestart = false, HintText = RefValues.FocusPerLevelHint)]
        public int focusPointsPerLevel { get; set; } = 1;

        [SettingPropertyGroup(RefValues.FocusText)]
        [SettingPropertyInteger(RefValues.MaxFocusText, 0, 100, "0", Order = 0, RequireRestart = false, HintText = RefValues.MaxFocusHint)]
        public int maxFocusPointsPerSkill { get; set; } = 5;


        public override string Id { get { return base.GetType().Assembly.GetName().Name; } }
        public override string DisplayName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FolderName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FormatType { get; } = "xml";
    }
}
