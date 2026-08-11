namespace Math_Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblMath = new System.Windows.Forms.Label();
            this.tBAnswer = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelFirst = new System.Windows.Forms.Panel();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.panelPlayGame = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelFirst.SuspendLayout();
            this.panelSetting.SuspendLayout();
            this.panelPlayGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Math Game";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(24, 116);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(414, 21);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "How Many Questions do you want? from 1 to 5";
            // 
            // tB1
            // 
            this.tB1.BackColor = System.Drawing.Color.LightCyan;
            this.tB1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB1.Location = new System.Drawing.Point(40, 41);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(536, 28);
            this.tB1.TabIndex = 2;
            this.tB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB1_KeyPress);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.LightCyan;
            this.btn1.Location = new System.Drawing.Point(28, 25);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 38);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Easy";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.LightCyan;
            this.btn2.Location = new System.Drawing.Point(142, 25);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 38);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "Medium ";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.LightCyan;
            this.btn3.Location = new System.Drawing.Point(256, 25);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 38);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "Hard";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.LightCyan;
            this.btn4.Location = new System.Drawing.Point(370, 25);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 38);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "Mix";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.LightCyan;
            this.btn5.Location = new System.Drawing.Point(484, 25);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 38);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "Mix";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Visible = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.LightCyan;
            this.btnRestart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestart.BackgroundImage")));
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRestart.Location = new System.Drawing.Point(12, 9);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(42, 41);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.LightCyan;
            this.btnEnter.Location = new System.Drawing.Point(582, 40);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(52, 24);
            this.btnEnter.TabIndex = 9;
            this.btnEnter.Text = ">>>";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblMath
            // 
            this.lblMath.AutoSize = true;
            this.lblMath.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMath.Location = new System.Drawing.Point(44, 3);
            this.lblMath.Name = "lblMath";
            this.lblMath.Size = new System.Drawing.Size(101, 28);
            this.lblMath.TabIndex = 10;
            this.lblMath.Text = "1 + 1 =";
            // 
            // tBAnswer
            // 
            this.tBAnswer.BackColor = System.Drawing.Color.LightCyan;
            this.tBAnswer.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBAnswer.Location = new System.Drawing.Point(49, 47);
            this.tBAnswer.Multiline = true;
            this.tBAnswer.Name = "tBAnswer";
            this.tBAnswer.Size = new System.Drawing.Size(445, 28);
            this.tBAnswer.TabIndex = 11;
            this.tBAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBAnswer_KeyPress);
            this.tBAnswer.Validating += new System.ComponentModel.CancelEventHandler(this.tBAnswer_Validating);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(24, 144);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(121, 21);
            this.lblResults.TabIndex = 12;
            this.lblResults.Text = "Final Result :";
            this.lblResults.Visible = false;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(90, 97);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(160, 21);
            this.lblAnswer.TabIndex = 13;
            this.lblAnswer.Text = "Answer is True : )";
            this.lblAnswer.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.LightCyan;
            this.btnCheck.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(500, 47);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(64, 43);
            this.btnCheck.TabIndex = 14;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelFirst
            // 
            this.panelFirst.Controls.Add(this.tB1);
            this.panelFirst.Controls.Add(this.btnEnter);
            this.panelFirst.Location = new System.Drawing.Point(12, 140);
            this.panelFirst.Name = "panelFirst";
            this.panelFirst.Size = new System.Drawing.Size(677, 87);
            this.panelFirst.TabIndex = 15;
            // 
            // panelSetting
            // 
            this.panelSetting.Controls.Add(this.btn1);
            this.panelSetting.Controls.Add(this.btn2);
            this.panelSetting.Controls.Add(this.btn3);
            this.panelSetting.Controls.Add(this.btn4);
            this.panelSetting.Controls.Add(this.btn5);
            this.panelSetting.Location = new System.Drawing.Point(12, 140);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(677, 100);
            this.panelSetting.TabIndex = 16;
            this.panelSetting.Visible = false;
            // 
            // panelPlayGame
            // 
            this.panelPlayGame.Controls.Add(this.btnCheck);
            this.panelPlayGame.Controls.Add(this.lblMath);
            this.panelPlayGame.Controls.Add(this.tBAnswer);
            this.panelPlayGame.Controls.Add(this.lblResults);
            this.panelPlayGame.Controls.Add(this.lblAnswer);
            this.panelPlayGame.Location = new System.Drawing.Point(12, 209);
            this.panelPlayGame.Name = "panelPlayGame";
            this.panelPlayGame.Size = new System.Drawing.Size(677, 185);
            this.panelPlayGame.TabIndex = 18;
            this.panelPlayGame.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(701, 403);
            this.Controls.Add(this.panelPlayGame);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.panelFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelFirst.ResumeLayout(false);
            this.panelFirst.PerformLayout();
            this.panelSetting.ResumeLayout(false);
            this.panelPlayGame.ResumeLayout(false);
            this.panelPlayGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblMath;
        private System.Windows.Forms.TextBox tBAnswer;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelFirst;
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.Panel panelPlayGame;
    }
}

