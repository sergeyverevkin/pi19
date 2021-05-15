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
using Microsoft.Win32;

namespace GameFindClient
{
  public partial class FormClient : Form
  {
    private string m_sPlayerGuid;
    private Game.Find.GameFindClient m_pClient;


    public FormClient()
    {
      InitializeComponent();
      string sUrlService = "http://127.0.0.1:8000/GameFind";
      txtUrl.Text = sUrlService;
    }

    private void h_Refresh()
    {
      if (m_pClient == null)
      {
        return;
      }

      panInfo.Visible = true;
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

      labDistance.Text = pState.Distance.ToString("F0");
      labPlayer.Text = pState.CurrentPlayer ?? m_sPlayerGuid;
      labState.Text = pState.State.ToString();
      labGame.Text = pState.GameUid;
      labOpponentDistance.Text = pState.OpponentDistance.ToString("F0");

    }

    private void btnStart_Click(object sender, EventArgs e)
    {
      txtUrl.Enabled = false;
      btnStart.Enabled = false;
      btnFinish.Enabled = true;
      panInfo.Visible = true;

      m_pClient = h_CreateClient();
      m_sPlayerGuid = System.Guid.NewGuid().ToString("N");
      Text = m_pClient.GetVersion();
      m_pClient.StartGame(m_sPlayerGuid);
      h_Refresh();
    }

    private Game.Find.GameFindClient h_CreateClient()
    {
      return new Game.Find.GameFindClient(txtUrl.Text);
    }

    private void btnFinish_Click(object sender, EventArgs e)
    {
      txtUrl.Enabled = true;
      btnStart.Enabled = true;
      btnFinish.Enabled = false;

      m_pClient.EndGame(m_sPlayerGuid);
      h_Refresh();

      m_pClient = null;
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
      h_Refresh();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      h_Refresh();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      int ii = (int) Int32.Parse((string)((sender as Button).Tag));
      switch (ii)
      {
        case 1:
          m_pClient.Turn(m_sPlayerGuid, ETurn.Top);
          break;
        case 2:
          m_pClient.Turn(m_sPlayerGuid, ETurn.Right);
          break;
        case 3:
          m_pClient.Turn(m_sPlayerGuid, ETurn.Bottom);
          break;
        case 4:
          m_pClient.Turn(m_sPlayerGuid, ETurn.Left);
          break;
      }
    }
  }
}
