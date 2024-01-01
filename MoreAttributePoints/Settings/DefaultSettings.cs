
namespace MoreAttributePoints.Settings {
    public class DefaultSettings : ISettings {
       
        public int levelsPerAttributePoint { get; set; } = 4;
        public int maxAttributeLevel { get; set; } = 10;
        public int extraAttPointsPerLevel { get; set; } = 0;

    }
}
