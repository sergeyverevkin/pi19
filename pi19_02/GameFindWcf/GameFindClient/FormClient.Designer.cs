namespace GameFindClient
{
  partial class FormClient
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.panInfo = new System.Windows.Forms.Panel();
      this.labOpponentDistance = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.labDistance = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.labPlayer = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.labGame = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.labState = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.panTop = new System.Windows.Forms.Panel();
      this.btnFinish = new System.Windows.Forms.Button();
      this.btnStart = new System.Windows.Forms.Button();
      this.txtUrl = new System.Windows.Forms.TextBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.panInfo.SuspendLayout();
      this.panTop.SuspendLayout();
      this.SuspendLayout();
      // 
      // panInfo
      // 
      this.panInfo.Controls.Add(this.labOpponentDistance);
      this.panInfo.Controls.Add(this.label2);
      this.panInfo.Controls.Add(this.button4);
      this.panInfo.Controls.Add(this.button3);
      this.panInfo.Controls.Add(this.button2);
      this.panInfo.Controls.Add(this.button1);
      this.panInfo.Controls.Add(this.labDistance);
      this.panInfo.Controls.Add(this.label5);
      this.panInfo.Controls.Add(this.labPlayer);
      this.panInfo.Controls.Add(this.label4);
      this.panInfo.Controls.Add(this.labGame);
      this.panInfo.Controls.Add(this.label3);
      this.panInfo.Controls.Add(this.labState);
      this.panInfo.Controls.Add(this.label1);
      this.panInfo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panInfo.Location = new System.Drawing.Point(0, 48);
      this.panInfo.Name = "panInfo";
      this.panInfo.Size = new System.Drawing.Size(483, 237);
      this.panInfo.TabIndex = 1;
      this.panInfo.Visible = false;
      // 
      // labOpponentDistance
      // 
      this.labOpponentDistance.AutoSize = true;
      this.labOpponentDistance.Location = new System.Drawing.Point(448, 39);
      this.labOpponentDistance.Name = "labOpponentDistance";
      this.labOpponentDistance.Size = new System.Drawing.Size(10, 13);
      this.labOpponentDistance.TabIndex = 13;
      this.labOpponentDistance.Text = "-";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(319, 38);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(115, 13);
      this.label2.TabIndex = 12;
      this.label2.Text = "У лучшего до победы";
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(175, 166);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(75, 54);
      this.button4.TabIndex = 11;
      this.button4.Tag = "3";
      this.button4.Text = "Вниз";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button3_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(177, 106);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 54);
      this.button3.TabIndex = 10;
      this.button3.Tag = "1";
      this.button3.Text = "Вверх";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(258, 139);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 54);
      this.button2.TabIndex = 9;
      this.button2.Tag = "2";
      this.button2.Text = "Вправо";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button3_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(94, 139);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 54);
      this.button1.TabIndex = 8;
      this.button1.Tag = "4";
      this.button1.Text = "Влево";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button3_Click);
      // 
      // labDistance
      // 
      this.labDistance.AutoSize = true;
      this.labDistance.Location = new System.Drawing.Point(448, 13);
      this.labDistance.Name = "labDistance";
      this.labDistance.Size = new System.Drawing.Size(10, 13);
      this.labDistance.TabIndex = 7;
      this.labDistance.Text = "-";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(370, 13);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(63, 13);
      this.label5.TabIndex = 6;
      this.label5.Text = "До победы";
      // 
      // labPlayer
      // 
      this.labPlayer.AutoSize = true;
      this.labPlayer.Location = new System.Drawing.Point(118, 68);
      this.labPlayer.Name = "labPlayer";
      this.labPlayer.Size = new System.Drawing.Size(10, 13);
      this.labPlayer.TabIndex = 5;
      this.labPlayer.Text = "-";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(23, 69);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(38, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "Игрок";
      // 
      // labGame
      // 
      this.labGame.AutoSize = true;
      this.labGame.Location = new System.Drawing.Point(118, 42);
      this.labGame.Name = "labGame";
      this.labGame.Size = new System.Drawing.Size(10, 13);
      this.labGame.TabIndex = 3;
      this.labGame.Text = "-";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(23, 43);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(32, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Игра";
      // 
      // labState
      // 
      this.labState.AutoSize = true;
      this.labState.Location = new System.Drawing.Point(118, 13);
      this.labState.Name = "labState";
      this.labState.Size = new System.Drawing.Size(10, 13);
      this.labState.TabIndex = 1;
      this.labState.Text = "-";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(23, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(89, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Состояние игры";
      // 
      // panTop
      // 
      this.panTop.Controls.Add(this.btnFinish);
      this.panTop.Controls.Add(this.btnStart);
      this.panTop.Controls.Add(this.txtUrl);
      this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.panTop.Location = new System.Drawing.Point(0, 0);
      this.panTop.Name = "panTop";
      this.panTop.Size = new System.Drawing.Size(483, 48);
      this.panTop.TabIndex = 2;
      // 
      // btnFinish
      // 
      this.btnFinish.Enabled = false;
      this.btnFinish.Location = new System.Drawing.Point(358, 9);
      this.btnFinish.Name = "btnFinish";
      this.btnFinish.Size = new System.Drawing.Size(75, 23);
      this.btnFinish.TabIndex = 3;
      this.btnFinish.Text = "Финиш";
      this.btnFinish.UseVisualStyleBackColor = true;
      this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(268, 10);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(75, 23);
      this.btnStart.TabIndex = 2;
      this.btnStart.Text = "Старт";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // txtUrl
      // 
      this.txtUrl.Location = new System.Drawing.Point(74, 12);
      this.txtUrl.Name = "txtUrl";
      this.txtUrl.Size = new System.Drawing.Size(172, 20);
      this.txtUrl.TabIndex = 1;
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 500;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // FormClient
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(483, 285);
      this.Controls.Add(this.panInfo);
      this.Controls.Add(this.panTop);
      this.Name = "FormClient";
      this.Text = "Form1";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.panInfo.ResumeLayout(false);
      this.panInfo.PerformLayout();
      this.panTop.ResumeLayout(false);
      this.panTop.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panInfo;
    private System.Windows.Forms.Panel panTop;
    private System.Windows.Forms.TextBox txtUrl;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button btnFinish;
    private System.Windows.Forms.Label labState;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label labPlayer;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label labGame;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label labDistance;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label labOpponentDistance;
    private System.Windows.Forms.Label label2;
  }
}

