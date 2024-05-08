namespace Rock_Paper_Scissor_Game
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
            if (disposing && (components != null))
            {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pBox_enemy = new System.Windows.Forms.PictureBox();
            this.pBox_player = new System.Windows.Forms.PictureBox();
            this.btn_rock = new System.Windows.Forms.Button();
            this.btn_paper = new System.Windows.Forms.Button();
            this.btn_scissor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_Player = new System.Windows.Forms.TextBox();
            this.txtBox_Enemy = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_player)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.09901F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "YOU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.09901F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "ENEMY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.09901F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "VS";
            // 
            // pBox_enemy
            // 
            this.pBox_enemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBox_enemy.Image = global::Rock_Paper_Scissor_Game.Properties.Resources.PAPER;
            this.pBox_enemy.Location = new System.Drawing.Point(247, 40);
            this.pBox_enemy.Name = "pBox_enemy";
            this.pBox_enemy.Size = new System.Drawing.Size(150, 150);
            this.pBox_enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_enemy.TabIndex = 0;
            this.pBox_enemy.TabStop = false;
            // 
            // pBox_player
            // 
            this.pBox_player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBox_player.Image = global::Rock_Paper_Scissor_Game.Properties.Resources.ROCK;
            this.pBox_player.Location = new System.Drawing.Point(23, 40);
            this.pBox_player.Name = "pBox_player";
            this.pBox_player.Size = new System.Drawing.Size(150, 150);
            this.pBox_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_player.TabIndex = 0;
            this.pBox_player.TabStop = false;
            // 
            // btn_rock
            // 
            this.btn_rock.BackColor = System.Drawing.Color.White;
            this.btn_rock.BackgroundImage = global::Rock_Paper_Scissor_Game.Properties.Resources.ROCK;
            this.btn_rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rock.Location = new System.Drawing.Point(86, 335);
            this.btn_rock.Name = "btn_rock";
            this.btn_rock.Size = new System.Drawing.Size(89, 89);
            this.btn_rock.TabIndex = 3;
            this.btn_rock.UseVisualStyleBackColor = false;
            this.btn_rock.Click += new System.EventHandler(this.btn_rock_Click);
            // 
            // btn_paper
            // 
            this.btn_paper.BackgroundImage = global::Rock_Paper_Scissor_Game.Properties.Resources.PAPER;
            this.btn_paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_paper.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_paper.Location = new System.Drawing.Point(181, 335);
            this.btn_paper.Name = "btn_paper";
            this.btn_paper.Size = new System.Drawing.Size(89, 89);
            this.btn_paper.TabIndex = 3;
            this.btn_paper.UseVisualStyleBackColor = true;
            this.btn_paper.Click += new System.EventHandler(this.btn_paper_Click);
            // 
            // btn_scissor
            // 
            this.btn_scissor.BackgroundImage = global::Rock_Paper_Scissor_Game.Properties.Resources.SCISSOR;
            this.btn_scissor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_scissor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_scissor.Location = new System.Drawing.Point(276, 335);
            this.btn_scissor.Name = "btn_scissor";
            this.btn_scissor.Size = new System.Drawing.Size(89, 89);
            this.btn_scissor.TabIndex = 3;
            this.btn_scissor.UseVisualStyleBackColor = true;
            this.btn_scissor.Click += new System.EventHandler(this.btn_scissor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.09901F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "Pick One:";
            // 
            // txtBox_Player
            // 
            this.txtBox_Player.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Player.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17.82178F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Player.Location = new System.Drawing.Point(23, 196);
            this.txtBox_Player.Name = "txtBox_Player";
            this.txtBox_Player.ReadOnly = true;
            this.txtBox_Player.Size = new System.Drawing.Size(150, 29);
            this.txtBox_Player.TabIndex = 5;
            this.txtBox_Player.Text = "ROCK";
            this.txtBox_Player.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_Enemy
            // 
            this.txtBox_Enemy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Enemy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17.82178F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Enemy.Location = new System.Drawing.Point(247, 196);
            this.txtBox_Enemy.Name = "txtBox_Enemy";
            this.txtBox_Enemy.ReadOnly = true;
            this.txtBox_Enemy.Size = new System.Drawing.Size(150, 29);
            this.txtBox_Enemy.TabIndex = 5;
            this.txtBox_Enemy.Text = "PAPER";
            this.txtBox_Enemy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtBox_Enemy);
            this.panel1.Controls.Add(this.txtBox_Player);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pBox_enemy);
            this.panel1.Controls.Add(this.pBox_player);
            this.panel1.Location = new System.Drawing.Point(12, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 261);
            this.panel1.TabIndex = 6;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(188, 447);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 26);
            this.btn_confirm.TabIndex = 7;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 493);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_scissor);
            this.Controls.Add(this.btn_paper);
            this.Controls.Add(this.btn_rock);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RPS Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_player)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox_player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBox_enemy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_rock;
        private System.Windows.Forms.Button btn_paper;
        private System.Windows.Forms.Button btn_scissor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_Player;
        private System.Windows.Forms.TextBox txtBox_Enemy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_confirm;
    }
}

