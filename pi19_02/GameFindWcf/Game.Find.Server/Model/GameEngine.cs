using System;
using System.Collections.Generic;

namespace Game.Find.Server.Model
{
  public class CGameEngine
  {
    private List<CGame> Games = new List<CGame>();
    private Dictionary<string, CGame> PlayerGames = new Dictionary<string, CGame>();

    public string CurrentPlayer { get; set; }
    public EGameState State { get; set; }

    public CGameEngine()
    {
    }


    public bool StartGame(string sPlayer)
    {
      if (PlayerGames.ContainsKey(sPlayer)) {
        return false;
      }

      CGame pGame = new CGame();
      Games.Add(pGame);
      pGame.AddPlayer(sPlayer);
      PlayerGames.Add(sPlayer, pGame);
      return true;
    }

    public CGame GetGame(string sPlayer)
    {
      if (!PlayerGames.ContainsKey(sPlayer)) {
        return null;
      }
      return PlayerGames[sPlayer];
    }

    public void EndGame(string sPlayer)
    {
      var pG = GetGame(sPlayer);
      if (pG == null) {
        throw new Exception();
      }

      pG.EndGame();
      //foreach (var pPl in pG.PlayerList) {
      //  PlayerGames.Remove(pPl.Guid);
      //}

      //Games.Remove(pG);
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
  }
}
