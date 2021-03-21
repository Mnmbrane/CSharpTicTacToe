
namespace TicTacToe
{
  partial class TicTacToeForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnTopLeft = new System.Windows.Forms.Button();
      this.btnTopMid = new System.Windows.Forms.Button();
      this.btnTopRight = new System.Windows.Forms.Button();
      this.btnMidLeft = new System.Windows.Forms.Button();
      this.btnMidMid = new System.Windows.Forms.Button();
      this.btnMidRight = new System.Windows.Forms.Button();
      this.btnBotLeft = new System.Windows.Forms.Button();
      this.btnBotMid = new System.Windows.Forms.Button();
      this.btnBotRight = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lblGamesLost = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnTopLeft
      // 
      this.btnTopLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.btnTopLeft.Location = new System.Drawing.Point(12, 12);
      this.btnTopLeft.Name = "btnTopLeft";
      this.btnTopLeft.Size = new System.Drawing.Size(150, 150);
      this.btnTopLeft.TabIndex = 0;
      this.btnTopLeft.UseVisualStyleBackColor = false;
      this.btnTopLeft.Click += new System.EventHandler(this.btnClick);
      // 
      // btnTopMid
      // 
      this.btnTopMid.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.btnTopMid.Location = new System.Drawing.Point(168, 12);
      this.btnTopMid.Name = "btnTopMid";
      this.btnTopMid.Size = new System.Drawing.Size(150, 150);
      this.btnTopMid.TabIndex = 1;
      this.btnTopMid.UseVisualStyleBackColor = false;
      this.btnTopMid.Click += new System.EventHandler(this.btnClick);
      // 
      // btnTopRight
      // 
      this.btnTopRight.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.btnTopRight.Location = new System.Drawing.Point(324, 12);
      this.btnTopRight.Name = "btnTopRight";
      this.btnTopRight.Size = new System.Drawing.Size(150, 150);
      this.btnTopRight.TabIndex = 2;
      this.btnTopRight.UseVisualStyleBackColor = false;
      this.btnTopRight.Click += new System.EventHandler(this.btnClick);
      // 
      // btnMidLeft
      // 
      this.btnMidLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.btnMidLeft.Location = new System.Drawing.Point(12, 168);
      this.btnMidLeft.Name = "btnMidLeft";
      this.btnMidLeft.Size = new System.Drawing.Size(150, 150);
      this.btnMidLeft.TabIndex = 3;
      this.btnMidLeft.UseVisualStyleBackColor = false;
      this.btnMidLeft.Click += new System.EventHandler(this.btnClick);
      // 
      // btnMidMid
      // 
      this.btnMidMid.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.btnMidMid.Location = new System.Drawing.Point(168, 168);
      this.btnMidMid.Name = "btnMidMid";
      this.btnMidMid.Size = new System.Drawing.Size(150, 150);
      this.btnMidMid.TabIndex = 4;
      this.btnMidMid.UseVisualStyleBackColor = false;
      this.btnMidMid.Click += new System.EventHandler(this.btnClick);
      // 
      // btnMidRight
      // 
      this.btnMidRight.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.btnMidRight.Location = new System.Drawing.Point(324, 168);
      this.btnMidRight.Name = "btnMidRight";
      this.btnMidRight.Size = new System.Drawing.Size(150, 150);
      this.btnMidRight.TabIndex = 5;
      this.btnMidRight.UseVisualStyleBackColor = false;
      this.btnMidRight.Click += new System.EventHandler(this.btnClick);
      // 
      // btnBotLeft
      // 
      this.btnBotLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.btnBotLeft.Location = new System.Drawing.Point(12, 324);
      this.btnBotLeft.Name = "btnBotLeft";
      this.btnBotLeft.Size = new System.Drawing.Size(150, 150);
      this.btnBotLeft.TabIndex = 6;
      this.btnBotLeft.UseVisualStyleBackColor = false;
      this.btnBotLeft.Click += new System.EventHandler(this.btnClick);
      // 
      // btnBotMid
      // 
      this.btnBotMid.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.btnBotMid.Location = new System.Drawing.Point(168, 324);
      this.btnBotMid.Name = "btnBotMid";
      this.btnBotMid.Size = new System.Drawing.Size(150, 150);
      this.btnBotMid.TabIndex = 7;
      this.btnBotMid.UseVisualStyleBackColor = false;
      this.btnBotMid.Click += new System.EventHandler(this.btnClick);
      // 
      // btnBotRight
      // 
      this.btnBotRight.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.btnBotRight.Location = new System.Drawing.Point(324, 324);
      this.btnBotRight.Name = "btnBotRight";
      this.btnBotRight.Size = new System.Drawing.Size(150, 150);
      this.btnBotRight.TabIndex = 8;
      this.btnBotRight.UseVisualStyleBackColor = false;
      this.btnBotRight.Click += new System.EventHandler(this.btnClick);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 487);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(74, 15);
      this.label2.TabIndex = 11;
      this.label2.Text = "Games Won:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(93, 487);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(13, 15);
      this.label1.TabIndex = 12;
      this.label1.Text = "0";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(112, 487);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(71, 15);
      this.label3.TabIndex = 13;
      this.label3.Text = "Games Lost:";
      // 
      // lblGamesLost
      // 
      this.lblGamesLost.AutoSize = true;
      this.lblGamesLost.Location = new System.Drawing.Point(190, 487);
      this.lblGamesLost.Name = "lblGamesLost";
      this.lblGamesLost.Size = new System.Drawing.Size(13, 15);
      this.lblGamesLost.TabIndex = 14;
      this.lblGamesLost.Text = "0";
      // 
      // TicTacToeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 511);
      this.Controls.Add(this.lblGamesLost);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnBotRight);
      this.Controls.Add(this.btnBotMid);
      this.Controls.Add(this.btnBotLeft);
      this.Controls.Add(this.btnMidRight);
      this.Controls.Add(this.btnMidMid);
      this.Controls.Add(this.btnMidLeft);
      this.Controls.Add(this.btnTopRight);
      this.Controls.Add(this.btnTopMid);
      this.Controls.Add(this.btnTopLeft);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "TicTacToeForm";
      this.Text = "TicTacToe";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnTopLeft;
    private System.Windows.Forms.Button btnTopMid;
    private System.Windows.Forms.Button btnTopRight;
    private System.Windows.Forms.Button btnMidLeft;
    private System.Windows.Forms.Button btnMidMid;
    private System.Windows.Forms.Button btnMidRight;
    private System.Windows.Forms.Button btnBotLeft;
    private System.Windows.Forms.Button btnBotMid;
    private System.Windows.Forms.Button btnBotRight;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblGamesLost;
  }
}

