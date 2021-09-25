namespace TypingGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txbAnswer = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.rtbParagraph = new System.Windows.Forms.RichTextBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            this.lblWordLeft = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblTotalWords = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSurrender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbAnswer
            // 
            this.txbAnswer.Enabled = false;
            this.txbAnswer.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAnswer.Location = new System.Drawing.Point(12, 239);
            this.txbAnswer.Multiline = true;
            this.txbAnswer.Name = "txbAnswer";
            this.txbAnswer.Size = new System.Drawing.Size(306, 30);
            this.txbAnswer.TabIndex = 2;
            this.txbAnswer.Text = "Type here after press the start button...";
            this.txbAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbAnswer_KeyDown);
            this.txbAnswer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbAnswer_KeyUp);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(414, 241);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 25);
            this.btnStart.TabIndex = 1;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "SET";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // rtbParagraph
            // 
            this.rtbParagraph.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbParagraph.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtbParagraph.Location = new System.Drawing.Point(12, 12);
            this.rtbParagraph.Name = "rtbParagraph";
            this.rtbParagraph.Size = new System.Drawing.Size(560, 221);
            this.rtbParagraph.TabIndex = 3;
            this.rtbParagraph.TabStop = false;
            this.rtbParagraph.Text = "A quick brown fox jump over a lazy dog.";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(12, 313);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(63, 15);
            this.lblCorrect.TabIndex = 4;
            this.lblCorrect.Text = "Correct : 0";
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong.Location = new System.Drawing.Point(12, 331);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(60, 15);
            this.lblWrong.TabIndex = 5;
            this.lblWrong.Text = "Wrong : 0";
            // 
            // lblWordLeft
            // 
            this.lblWordLeft.AutoSize = true;
            this.lblWordLeft.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordLeft.Location = new System.Drawing.Point(12, 279);
            this.lblWordLeft.Name = "lblWordLeft";
            this.lblWordLeft.Size = new System.Drawing.Size(83, 15);
            this.lblWordLeft.TabIndex = 6;
            this.lblWordLeft.Text = "Words Left : 0";
            this.lblWordLeft.Visible = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(333, 241);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 25);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.TabStop = false;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblTotalWords
            // 
            this.lblTotalWords.AutoSize = true;
            this.lblTotalWords.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWords.Location = new System.Drawing.Point(12, 296);
            this.lblTotalWords.Name = "lblTotalWords";
            this.lblTotalWords.Size = new System.Drawing.Size(90, 15);
            this.lblTotalWords.TabIndex = 8;
            this.lblTotalWords.Text = "Total Words : 0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(12, 349);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(52, 15);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Time : 0";
            this.lblTime.Visible = false;
            // 
            // btnSurrender
            // 
            this.btnSurrender.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurrender.Location = new System.Drawing.Point(495, 241);
            this.btnSurrender.Name = "btnSurrender";
            this.btnSurrender.Size = new System.Drawing.Size(75, 25);
            this.btnSurrender.TabIndex = 10;
            this.btnSurrender.TabStop = false;
            this.btnSurrender.Text = "SUREN";
            this.btnSurrender.UseVisualStyleBackColor = true;
            this.btnSurrender.Click += new System.EventHandler(this.btnSurrender_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 372);
            this.Controls.Add(this.btnSurrender);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTotalWords);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblWordLeft);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.rtbParagraph);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txbAnswer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TypingGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbAnswer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox rtbParagraph;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.Label lblWordLeft;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblTotalWords;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnSurrender;
    }
}

