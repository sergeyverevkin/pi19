using Game.Find.Server.Model;
using System.ServiceModel;

namespace Game.Find.Server
{

  [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
  public class CGameFind : IGameFind
  {
    private CGameEngine m_pGame = new CGameEngine();

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
      GameState pGameState = new GameState() {
        CurrentPlayer = pGame.CurrentPlayer,
        Distance = pGame.GetDistance(sPlayer),
        State = pGame.State
      };
      return pGameState;
    }

    public string GetVersion()
    {
      return "1.0";
    }
  }
}