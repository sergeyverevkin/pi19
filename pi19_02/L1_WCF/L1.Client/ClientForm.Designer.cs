namespace WindowsFormsApp1
{
  partial class ClientForm
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
      this.lvParts = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.lvArticles = new System.Windows.Forms.ListView();
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.txtAddr = new System.Windows.Forms.TextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lvParts
      // 
      this.lvParts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
      this.lvParts.Location = new System.Drawing.Point(26, 74);
      this.lvParts.Name = "lvParts";
      this.lvParts.Size = new System.Drawing.Size(288, 97);
      this.lvParts.TabIndex = 0;
      this.lvParts.UseCompatibleStateImageBehavior = false;
      this.lvParts.View = System.Windows.Forms.View.Details;
      this.lvParts.SelectedIndexChanged += new System.EventHandler(this.lvParts_SelectedIndexChanged);
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = " Раздел";
      this.columnHeader1.Width = 216;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Количество статей";
      // 
      // lvArticles
      // 
      this.lvArticles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
      this.lvArticles.Location = new System.Drawing.Point(26, 198);
      this.lvArticles.Name = "lvArticles";
      this.lvArticles.Size = new System.Drawing.Size(288, 97);
      this.lvArticles.TabIndex = 1;
      this.lvArticles.UseCompatibleStateImageBehavior = false;
      this.lvArticles.View = System.Windows.Forms.View.Details;
      this.lvArticles.Visible = false;
      this.lvArticles.SelectedIndexChanged += new System.EventHandler(this.lvArticles_SelectedIndexChanged);
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Слово";
      this.columnHeader3.Width = 104;
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "Значение";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnRefresh);
      this.panel1.Controls.Add(this.txtAddr);
      this.panel1.Controls.Add(this.lvParts);
      this.panel1.Controls.Add(this.lvArticles);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(333, 450);
      this.panel1.TabIndex = 2;
      // 
      // btnRefresh
      // 
      this.btnRefresh.Location = new System.Drawing.Point(246, 31);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(68, 23);
      this.btnRefresh.TabIndex = 3;
      this.btnRefresh.Text = " Обновить";
      this.btnRefresh.UseVisualStyleBackColor = true;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // txtAddr
      // 
      this.txtAddr.Location = new System.Drawing.Point(26, 31);
      this.txtAddr.Name = "txtAddr";
      this.txtAddr.Size = new System.Drawing.Size(207, 20);
      this.txtAddr.TabIndex = 2;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(333, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(467, 450);
      this.panel2.TabIndex = 3;
      // 
      // ClientForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "ClientForm";
      this.Text = "Client";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListView lvParts;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ListView lvArticles;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox txtAddr;
    private System.Windows.Forms.Button btnRefresh;
  }
}

