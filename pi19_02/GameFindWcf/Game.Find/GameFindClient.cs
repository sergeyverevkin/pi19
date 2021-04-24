using System.ServiceModel;

namespace Game.Find
{
  public class GameFindClient : System.ServiceModel.ClientBase<IGameFind>, IGameFind
  {

    public GameFindClient(string sUrl) :
      base(new BasicHttpBinding(), new EndpointAddress(sUrl))
    {
    }

    public bool StartGame(string sPlayer)
    {
      return base.Channel.StartGame(sPlayer);
    }

    public bool Turn(string sPlayer, ETurn enTurn)
    {
      return base.Channel.Turn(sPlayer, enTurn);
    }

    public void EndGame(string sPlayer)
    {
      base.Channel.EndGame(sPlayer);
    }

    public GameState GetState(string sPlayer)
    {
      return base.Channel.GetState(sPlayer);
    }
  }
}
