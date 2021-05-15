using System;
using System.Collections.Generic;
using System.Linq;

namespace Game.Find.Server.Model
{
  public class CGamesPool : List<CGame>
  {
    public CGame GetGameToJoin()
    {
      foreach (CGame pG in this) {
        if (pG.IsJoinable) {
          return pG;
        }
      }
      return null;
    }


    public CGame GetGameOwned(string sPlayerGuid)
    {
      foreach (CGame pG in this) {
        if (pG.PlayerList.Any(p => p.Guid == sPlayerGuid)) {
          return pG;
        }
      }

      return null;
    }

    public void RemoveOld(EGameState enState, DateTime dtLimit)
    {
      for (int ii = this.Count - 1; ii >= 0; ii--) {
        CGame pGame = this[ii];
        if (pGame.State == enState && pGame.LastDateTime < dtLimit) {
          this.RemoveAt(ii);
        }
      }
    }

    public void GameOverOld(EGameState enState, DateTime dtLimit)
    {
      for (int ii = this.Count - 1; ii >= 0; ii--) {
        CGame pGame = this[ii];
        if (pGame.State == enState && pGame.LastDateTime < dtLimit) {
          pGame.State = EGameState.GameOver;
        }
      }
    }
  }
}