namespace GameFindClient
{
  partial class Form1
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.panTop = new System.Windows.Forms.Panel();
      this.btnFinish = new System.Windows.Forms.Button();
      this.btnStart = new System.Windows.Forms.Button();
      this.txtUrl = new System.Windows.Forms.TextBox();
      this.panTop.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 48);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 402);
      this.panel1.TabIndex = 1;
      // 
      // panTop
      // 
      this.panTop.Controls.Add(this.btnFinish);
      this.panTop.Controls.Add(this.btnStart);
      this.panTop.Controls.Add(this.txtUrl);
      this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.panTop.Location = new System.Drawing.Point(0, 0);
      this.panTop.Name = "panTop";
      this.panTop.Size = new System.Drawing.Size(800, 48);
      this.panTop.TabIndex = 2;
      // 
      // btnFinish
      // 
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
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.panTop);
      this.Name = "Form1";
      this.Text = "Form1";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.panTop.ResumeLayout(false);
      this.panTop.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panTop;
    private System.Windows.Forms.TextBox txtUrl;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button btnFinish;
  }
}

