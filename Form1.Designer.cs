
namespace Geditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Stage = new System.Windows.Forms.Label();
            this.lbl_Player1 = new System.Windows.Forms.Label();
            this.lbl_Player2 = new System.Windows.Forms.Label();
            this.lbl_Score1 = new System.Windows.Forms.Label();
            this.lbl_Score2 = new System.Windows.Forms.Label();
            this.cbx_Players1 = new System.Windows.Forms.ComboBox();
            this.cbx_Players2 = new System.Windows.Forms.ComboBox();
            this.btn_Score_Add = new System.Windows.Forms.Button();
            this.btn_Score2_Add = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Swap = new System.Windows.Forms.Button();
            this.btn_Winners = new System.Windows.Forms.Button();
            this.btn_Losers = new System.Windows.Forms.Button();
            this.btn_Semis = new System.Windows.Forms.Button();
            this.btn_Quarters = new System.Windows.Forms.Button();
            this.btn_Finals = new System.Windows.Forms.Button();
            this.btn_Round = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Score_Reset = new System.Windows.Forms.Button();
            this.btn_Stage_Subtract = new System.Windows.Forms.Button();
            this.btn_Stage_Add = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Stage_Reset = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Stage
            // 
            this.lbl_Stage.AutoSize = true;
            this.lbl_Stage.BackColor = System.Drawing.Color.Black;
            this.lbl_Stage.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Stage.Location = new System.Drawing.Point(412, 75);
            this.lbl_Stage.Name = "lbl_Stage";
            this.lbl_Stage.Size = new System.Drawing.Size(46, 17);
            this.lbl_Stage.TabIndex = 10;
            this.lbl_Stage.Text = "STAGE";
            // 
            // lbl_Player1
            // 
            this.lbl_Player1.AutoSize = true;
            this.lbl_Player1.BackColor = System.Drawing.Color.Black;
            this.lbl_Player1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Player1.Location = new System.Drawing.Point(165, 54);
            this.lbl_Player1.Name = "lbl_Player1";
            this.lbl_Player1.Size = new System.Drawing.Size(60, 17);
            this.lbl_Player1.TabIndex = 11;
            this.lbl_Player1.Text = "PLAYER1";
            // 
            // lbl_Player2
            // 
            this.lbl_Player2.AutoSize = true;
            this.lbl_Player2.BackColor = System.Drawing.Color.Black;
            this.lbl_Player2.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Player2.Location = new System.Drawing.Point(567, 54);
            this.lbl_Player2.Name = "lbl_Player2";
            this.lbl_Player2.Size = new System.Drawing.Size(60, 17);
            this.lbl_Player2.TabIndex = 12;
            this.lbl_Player2.Text = "PLAYER2";
            // 
            // lbl_Score1
            // 
            this.lbl_Score1.AutoSize = true;
            this.lbl_Score1.BackColor = System.Drawing.Color.Black;
            this.lbl_Score1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Score1.Location = new System.Drawing.Point(388, 54);
            this.lbl_Score1.Name = "lbl_Score1";
            this.lbl_Score1.Size = new System.Drawing.Size(16, 17);
            this.lbl_Score1.TabIndex = 13;
            this.lbl_Score1.Text = "X";
            // 
            // lbl_Score2
            // 
            this.lbl_Score2.AutoSize = true;
            this.lbl_Score2.BackColor = System.Drawing.Color.Black;
            this.lbl_Score2.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Score2.Location = new System.Drawing.Point(529, 51);
            this.lbl_Score2.Name = "lbl_Score2";
            this.lbl_Score2.Size = new System.Drawing.Size(15, 17);
            this.lbl_Score2.TabIndex = 14;
            this.lbl_Score2.Text = "Y";
            // 
            // cbx_Players1
            // 
            this.cbx_Players1.BackColor = System.Drawing.Color.DodgerBlue;
            this.cbx_Players1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_Players1.ForeColor = System.Drawing.SystemColors.Control;
            this.cbx_Players1.FormattingEnabled = true;
            this.cbx_Players1.Location = new System.Drawing.Point(165, 136);
            this.cbx_Players1.Name = "cbx_Players1";
            this.cbx_Players1.Size = new System.Drawing.Size(226, 25);
            this.cbx_Players1.TabIndex = 15;
            this.cbx_Players1.Text = "PLAYERS";
            this.cbx_Players1.SelectedIndexChanged += new System.EventHandler(this.cbx_Players1_SelectedIndexChanged);
            // 
            // cbx_Players2
            // 
            this.cbx_Players2.BackColor = System.Drawing.Color.OrangeRed;
            this.cbx_Players2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_Players2.ForeColor = System.Drawing.SystemColors.Control;
            this.cbx_Players2.FormattingEnabled = true;
            this.cbx_Players2.Location = new System.Drawing.Point(546, 136);
            this.cbx_Players2.Name = "cbx_Players2";
            this.cbx_Players2.Size = new System.Drawing.Size(269, 25);
            this.cbx_Players2.TabIndex = 16;
            this.cbx_Players2.Text = "PLAYERS";
            this.cbx_Players2.SelectedIndexChanged += new System.EventHandler(this.cbx_Players2_SelectedIndexChanged);
            // 
            // btn_Score_Add
            // 
            this.btn_Score_Add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Score_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Score_Add.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Score_Add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Score_Add.Location = new System.Drawing.Point(-3, 36);
            this.btn_Score_Add.Name = "btn_Score_Add";
            this.btn_Score_Add.Size = new System.Drawing.Size(75, 464);
            this.btn_Score_Add.TabIndex = 17;
            this.btn_Score_Add.Text = "+";
            this.btn_Score_Add.UseVisualStyleBackColor = false;
            this.btn_Score_Add.Click += new System.EventHandler(this.btn_Score_Add_Click);
            // 
            // btn_Score2_Add
            // 
            this.btn_Score2_Add.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Score2_Add.FlatAppearance.BorderSize = 0;
            this.btn_Score2_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Score2_Add.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Score2_Add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Score2_Add.Location = new System.Drawing.Point(839, 36);
            this.btn_Score2_Add.Name = "btn_Score2_Add";
            this.btn_Score2_Add.Size = new System.Drawing.Size(85, 464);
            this.btn_Score2_Add.TabIndex = 18;
            this.btn_Score2_Add.Text = "+";
            this.btn_Score2_Add.UseVisualStyleBackColor = false;
            this.btn_Score2_Add.Click += new System.EventHandler(this.btn_Score2_Add_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Black;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Back.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Back.Location = new System.Drawing.Point(-3, 0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 48);
            this.btn_Back.TabIndex = 19;
            this.btn_Back.Text = "←";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Reset_All_Click);
            // 
            // btn_Swap
            // 
            this.btn_Swap.BackColor = System.Drawing.Color.White;
            this.btn_Swap.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Swap.FlatAppearance.BorderSize = 0;
            this.btn_Swap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Swap.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Swap.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Swap.Location = new System.Drawing.Point(423, 54);
            this.btn_Swap.Name = "btn_Swap";
            this.btn_Swap.Size = new System.Drawing.Size(96, 409);
            this.btn_Swap.TabIndex = 20;
            this.btn_Swap.Text = "⇄";
            this.btn_Swap.UseVisualStyleBackColor = false;
            this.btn_Swap.Click += new System.EventHandler(this.btn_Swap_Click);
            // 
            // btn_Winners
            // 
            this.btn_Winners.BackColor = System.Drawing.Color.White;
            this.btn_Winners.FlatAppearance.BorderSize = 0;
            this.btn_Winners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Winners.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Winners.Location = new System.Drawing.Point(749, 461);
            this.btn_Winners.Name = "btn_Winners";
            this.btn_Winners.Size = new System.Drawing.Size(93, 35);
            this.btn_Winners.TabIndex = 21;
            this.btn_Winners.Text = "WINNERS";
            this.btn_Winners.UseVisualStyleBackColor = false;
            this.btn_Winners.Click += new System.EventHandler(this.btn_Winners_Click);
            // 
            // btn_Losers
            // 
            this.btn_Losers.BackColor = System.Drawing.Color.White;
            this.btn_Losers.FlatAppearance.BorderSize = 0;
            this.btn_Losers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Losers.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_Losers.Location = new System.Drawing.Point(71, 461);
            this.btn_Losers.Name = "btn_Losers";
            this.btn_Losers.Size = new System.Drawing.Size(87, 39);
            this.btn_Losers.TabIndex = 22;
            this.btn_Losers.Text = "LOSERS";
            this.btn_Losers.UseVisualStyleBackColor = false;
            this.btn_Losers.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_Semis
            // 
            this.btn_Semis.BackColor = System.Drawing.Color.White;
            this.btn_Semis.FlatAppearance.BorderSize = 0;
            this.btn_Semis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Semis.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_Semis.Location = new System.Drawing.Point(529, 461);
            this.btn_Semis.Name = "btn_Semis";
            this.btn_Semis.Size = new System.Drawing.Size(129, 36);
            this.btn_Semis.TabIndex = 23;
            this.btn_Semis.Text = "SEMIS";
            this.btn_Semis.UseVisualStyleBackColor = false;
            this.btn_Semis.Click += new System.EventHandler(this.btn_Semis_Click);
            // 
            // btn_Quarters
            // 
            this.btn_Quarters.BackColor = System.Drawing.Color.White;
            this.btn_Quarters.FlatAppearance.BorderSize = 0;
            this.btn_Quarters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quarters.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Quarters.Location = new System.Drawing.Point(403, 461);
            this.btn_Quarters.Name = "btn_Quarters";
            this.btn_Quarters.Size = new System.Drawing.Size(129, 35);
            this.btn_Quarters.TabIndex = 24;
            this.btn_Quarters.Text = "QUARTERS";
            this.btn_Quarters.UseVisualStyleBackColor = false;
            this.btn_Quarters.Click += new System.EventHandler(this.btn_Quarters_Click);
            // 
            // btn_Finals
            // 
            this.btn_Finals.BackColor = System.Drawing.Color.White;
            this.btn_Finals.FlatAppearance.BorderSize = 0;
            this.btn_Finals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Finals.ForeColor = System.Drawing.Color.Lime;
            this.btn_Finals.Location = new System.Drawing.Point(631, 461);
            this.btn_Finals.Name = "btn_Finals";
            this.btn_Finals.Size = new System.Drawing.Size(129, 36);
            this.btn_Finals.TabIndex = 25;
            this.btn_Finals.Text = "FINALS";
            this.btn_Finals.UseVisualStyleBackColor = false;
            this.btn_Finals.Click += new System.EventHandler(this.btn_Finals_Click);
            // 
            // btn_Round
            // 
            this.btn_Round.BackColor = System.Drawing.Color.White;
            this.btn_Round.FlatAppearance.BorderSize = 0;
            this.btn_Round.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Round.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Round.Location = new System.Drawing.Point(155, 461);
            this.btn_Round.Name = "btn_Round";
            this.btn_Round.Size = new System.Drawing.Size(122, 39);
            this.btn_Round.TabIndex = 26;
            this.btn_Round.Text = "ROUND";
            this.btn_Round.UseVisualStyleBackColor = false;
            this.btn_Round.Click += new System.EventHandler(this.btn_Round_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(861, 80);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Score_Reset
            // 
            this.btn_Score_Reset.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Score_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Score_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Score_Reset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Score_Reset.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Score_Reset.Location = new System.Drawing.Point(71, 0);
            this.btn_Score_Reset.Name = "btn_Score_Reset";
            this.btn_Score_Reset.Size = new System.Drawing.Size(770, 48);
            this.btn_Score_Reset.TabIndex = 28;
            this.btn_Score_Reset.Text = "   ↶                 ↷";
            this.btn_Score_Reset.UseVisualStyleBackColor = false;
            this.btn_Score_Reset.Click += new System.EventHandler(this.btn_Score_Reset_Click);
            // 
            // btn_Stage_Subtract
            // 
            this.btn_Stage_Subtract.BackColor = System.Drawing.Color.White;
            this.btn_Stage_Subtract.FlatAppearance.BorderSize = 0;
            this.btn_Stage_Subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stage_Subtract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Stage_Subtract.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_Stage_Subtract.Location = new System.Drawing.Point(272, 461);
            this.btn_Stage_Subtract.Name = "btn_Stage_Subtract";
            this.btn_Stage_Subtract.Size = new System.Drawing.Size(67, 35);
            this.btn_Stage_Subtract.TabIndex = 29;
            this.btn_Stage_Subtract.Text = "0";
            this.btn_Stage_Subtract.UseVisualStyleBackColor = false;
            this.btn_Stage_Subtract.Click += new System.EventHandler(this.btn_Stage_Subtract_Click);
            // 
            // btn_Stage_Add
            // 
            this.btn_Stage_Add.BackColor = System.Drawing.Color.White;
            this.btn_Stage_Add.FlatAppearance.BorderSize = 0;
            this.btn_Stage_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stage_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Stage_Add.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_Stage_Add.Location = new System.Drawing.Point(334, 461);
            this.btn_Stage_Add.Name = "btn_Stage_Add";
            this.btn_Stage_Add.Size = new System.Drawing.Size(94, 39);
            this.btn_Stage_Add.TabIndex = 30;
            this.btn_Stage_Add.Text = "+";
            this.btn_Stage_Add.UseVisualStyleBackColor = false;
            this.btn_Stage_Add.Click += new System.EventHandler(this.btn_Stage_Add_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Reset.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Reset.Location = new System.Drawing.Point(839, -3);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 48);
            this.btn_Reset.TabIndex = 31;
            this.btn_Reset.Text = "↻";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Stage_Reset
            // 
            this.btn_Stage_Reset.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Stage_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Stage_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stage_Reset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Stage_Reset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Stage_Reset.Location = new System.Drawing.Point(-3, 493);
            this.btn_Stage_Reset.Name = "btn_Stage_Reset";
            this.btn_Stage_Reset.Size = new System.Drawing.Size(918, 48);
            this.btn_Stage_Reset.TabIndex = 32;
            this.btn_Stage_Reset.Text = "↻";
            this.btn_Stage_Reset.UseVisualStyleBackColor = false;
            this.btn_Stage_Reset.Click += new System.EventHandler(this.btn_Stage_Reset_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.DimGray;
            this.btn_Help.FlatAppearance.BorderSize = 0;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Help.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Help.Location = new System.Drawing.Point(-3, 493);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(75, 48);
            this.btn_Help.TabIndex = 33;
            this.btn_Help.Text = "?";
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 538);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_Stage_Reset);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Stage_Add);
            this.Controls.Add(this.btn_Stage_Subtract);
            this.Controls.Add(this.btn_Score_Reset);
            this.Controls.Add(this.btn_Round);
            this.Controls.Add(this.btn_Finals);
            this.Controls.Add(this.btn_Quarters);
            this.Controls.Add(this.btn_Semis);
            this.Controls.Add(this.btn_Losers);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Score2_Add);
            this.Controls.Add(this.btn_Score_Add);
            this.Controls.Add(this.cbx_Players2);
            this.Controls.Add(this.cbx_Players1);
            this.Controls.Add(this.lbl_Score2);
            this.Controls.Add(this.lbl_Score1);
            this.Controls.Add(this.lbl_Player2);
            this.Controls.Add(this.lbl_Player1);
            this.Controls.Add(this.lbl_Stage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Swap);
            this.Controls.Add(this.btn_Winners);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Strimmy";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Stage;
        private System.Windows.Forms.Label lbl_Player1;
        private System.Windows.Forms.Label lbl_Player2;
        private System.Windows.Forms.Label lbl_Score1;
        private System.Windows.Forms.Label lbl_Score2;
        private System.Windows.Forms.ComboBox cbx_Players1;
        private System.Windows.Forms.ComboBox cbx_Players2;
        private System.Windows.Forms.Button btn_Score_Add;
        private System.Windows.Forms.Button btn_Score2_Add;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Swap;
        private System.Windows.Forms.Button btn_Winners;
        private System.Windows.Forms.Button btn_Losers;
        private System.Windows.Forms.Button btn_Semis;
        private System.Windows.Forms.Button btn_Quarters;
        private System.Windows.Forms.Button btn_Finals;
        private System.Windows.Forms.Button btn_Round;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Score_Reset;
        private System.Windows.Forms.Button btn_Stage_Subtract;
        private System.Windows.Forms.Button btn_Stage_Add;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Stage_Reset;
        private System.Windows.Forms.Button btn_Help;
    }
}

