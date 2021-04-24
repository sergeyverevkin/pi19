using System.Threading;

namespace Game.Find.Server.Model
{
  public class CPlayer
  {
    public CPlayer(string guid)
    {
      Guid = guid;
    }

    public int Count { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public string Guid { get; set; }

    public void Turn(ETurn enTurn)
    {
      Count++;
      switch (enTurn) {
        case ETurn.Left:
          X--;
          break;
        case ETurn.Right:
          X++;
          break;
        case ETurn.Top:
          Y--;
          break;
        case ETurn.Bottom:
          Y++;
          break;
      }
    }

  }
}