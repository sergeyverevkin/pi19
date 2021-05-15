using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Find;

namespace GameFindClient
{
  public partial class Form1 : Form
  {
    private string m_sPlayerGuid;
    private Game.Find.GameFindClient m_pClient;


    public Form1()
    {
      InitializeComponent();
      string sUrlService = "http://127.0.0.1:8000/GameFind";
      txtUrl.Text = sUrlService;
    }

    private void h_Refresh()
    {
      GameState pState = m_pClient.GetState(m_sPlayerGuid);
      switch (pState.State)
      {
        case EGameState.GameWait:
          panTop.BackColor = Color.Gray;
          break;
        case EGameState.GameProcess:
          panTop.BackColor = Color.Green;
          break;
        case EGameState.GameOver:
          panTop.BackColor = Color.Bisque;
          break;
      }
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
      m_pClient = h_CreateClient();
      m_sPlayerGuid = new Guid().ToString("N");
      Text = m_pClient.GetVersion();
      m_pClient.StartGame(m_sPlayerGuid);
    }

    private Game.Find.GameFindClient h_CreateClient()
    {
      return new Game.Find.GameFindClient(txtUrl.Text);
    }

    private void btnFinish_Click(object sender, EventArgs e)
    {
      m_pClient.EndGame(m_sPlayerGuid);

    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      switch (e.KeyCode)
      {
        case Keys.Left:
          m_pClient.Turn(m_sPlayerGuid, ETurn.Left);
          break;
        case Keys.Right:
          m_pClient.Turn(m_sPlayerGuid, ETurn.Right);
          break;
        case Keys.Up:
          m_pClient.Turn(m_sPlayerGuid, ETurn.Top);
          break;
        case Keys.Down:
          m_pClient.Turn(m_sPlayerGuid, ETurn.Bottom);
          break;
      }
      // TODO: get extended game state
      h_Refresh();
    }
  }
}
