using Game.Find.Server.Model;

namespace Game.Find.Server
{

  // [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
  public class CGameFind : IGameFind
  {
    private static CGameEngine m_pGame = new CGameEngine();

    #region public methods

    public bool StartGame(string sPlayer)
    {
      return m_pGame.StartGame(sPlayer);
    }

    public bool Turn(string sPlayer, ETurn enTurn)
    {
      return m_pGame.Turn(sPlayer, enTurn);
    }

    public void EndGame(string sPlayer)
    {
      m_pGame.EndGame(sPlayer);
    }

    public GameState GetState(string sPlayer)
    {
      CGame pGame = m_pGame.GetGame(sPlayer);
      if (pGame == null) {
        return new GameState();
      }
      GameState pGameState = new GameState() {
        CurrentPlayer = pGame.CurrentPlayer,
        Distance = pGame.GetDistance(sPlayer),
        State = pGame.State,
        GameUid = pGame.Guid,
        OpponentDistance = pGame.GetBestDistance()
      };
      return pGameState;
    }

    public string GetVersion()
    {
      return "1.0";
    }

    #endregion

    #region static methods
    public static void SetLogger(ILogger pLogger)
    {
      m_pGame.SetLogger(pLogger);
    }
    #endregion
  }
}