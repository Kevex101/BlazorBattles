using BlazorBattles.Shared;

namespace BlazorBattles.Client.Services
{
    public interface IBattleService
    {
        BattleResult LastBattle { get; set; }
        IList<BattleHistoryEntry> History { get; set; }
        Task<BattleResult> StartBattle(int opponent);
        Task GetHistory();

        
    }
}
