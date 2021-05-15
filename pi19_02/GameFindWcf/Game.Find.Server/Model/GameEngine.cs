using System;

namespace Game.Find.Server.Model
{
  public class CGameEngine
  {
    #region private variables

    private CGamesPool Games = new CGamesPool();
    private DateTime m_dtNextCleanTime = DateTime.Now;
    private ILogger m_pLogger;

    #endregion

    #region consts

    private const int MinutesToRemoveGameOver = 2;
    private const int MinutesToFinishGameWait = 2;
    private const int MinutesToFinishGameProcess = 2;
    private const int SecondsCleanInterval = 2;

    #endregion

    #region constructors

    public CGameEngine()
    {
    }

    #endregion

    #region public methods

    public void Clean()
    {
      // не чистим чаще раза в 2 секунды
      if (DateTime.Now > m_dtNextCleanTime) {
        Games.RemoveOld(EGameState.GameOver, DateTime.Now.AddMinutes(-MinutesToRemoveGameOver));
        Games.GameOverOld(EGameState.GameWait, DateTime.Now.AddMinutes(-MinutesToFinishGameWait));
        Games.GameOverOld(EGameState.GameProcess, DateTime.Now.AddMinutes(-MinutesToFinishGameProcess));
        m_dtNextCleanTime = DateTime.Now.AddSeconds(SecondsCleanInterval);
      }
    }

    public bool StartGame(string sPlayer)
    {
      Clean();

      if (Games.GetGameOwned(sPlayer) != null) {
        return false;
      }

      var pGame = Games.GetGameToJoin();
      if (pGame == null) {
        pGame = new CGame();
        Games.Add(pGame);
      }

      pGame.AddPlayer(sPlayer);
      return true;
    }

    public CGame GetGame(string sPlayer)
    {
      return Games.GetGameOwned(sPlayer);
    }

    public void EndGame(string sPlayer)
    {
      var pG = GetGame(sPlayer);
      if (pG == null) {
        throw new Exception();
      }
      pG.LastDateTime = DateTime.Now;

      pG.EndGame();
    }

    public bool Turn(string sPlayer, ETurn enTurn)
    {
      var pG = GetGame(sPlayer);
      if (pG == null) {
        throw new Exception();
      }
      pG.LastDateTime = DateTime.Now;
      return pG.Turn(sPlayer, enTurn);
    }

    public void SetLogger(ILogger pLogger)
    {
      m_pLogger = pLogger;
    }

    // TODO: LogMethod + logging
    #endregion

  }
}
