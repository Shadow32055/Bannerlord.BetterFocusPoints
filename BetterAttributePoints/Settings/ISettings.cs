
namespace BetterAttributePoints.Settings {
    public interface ISettings {

        int levelsPerAttributePoint { get; set; }
        int maxAttributeLevel { get; set; }
        int extraAttPointsPerLevel { get; set; }
    }
}
