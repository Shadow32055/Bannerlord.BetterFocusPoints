using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace BetterFocusPoints.Settings {

    internal class MCMSettings : AttributeGlobalSettings<MCMSettings>, ISettings {

        const string focusText = "{BA_OUkZom}Focus Points";

        [SettingPropertyGroup(focusText)]
        [SettingPropertyInteger("{=BA_S7nfeK}Focus Points Per Level", 0, 100, "0", Order = 0, RequireRestart = false, HintText = "{=BA_GtIuji}How many focus points per level.")]
        public int focusPointsPerLevel { get; set; } = 1;

        [SettingPropertyGroup(focusText)]
        [SettingPropertyInteger("{=BA_S7nfeK}Max Focus Points Per Skill", 0, 100, "0", Order = 0, RequireRestart = false, HintText = "{=BA_GtIutr}How many focus points that can be spent on a skill.")]
        public int maxFocusPointsPerSkill { get; set; } = 5;



        public override string Id { get { return base.GetType().Assembly.GetName().Name; } }
        public override string DisplayName { get; } = "Better Focus Points";
        public override string FolderName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FormatType { get; } = "xml";
        public bool LoadMCMConfigFile { get; set; } = true;
    }
}
