namespace CardGame
{
    partial class formCardGame
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
            this.shuffleBtn = new System.Windows.Forms.Button();
            this.createDeckBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shuffleBtn
            // 
            this.shuffleBtn.Location = new System.Drawing.Point(100, 492);
            this.shuffleBtn.Name = "shuffleBtn";
            this.shuffleBtn.Size = new System.Drawing.Size(75, 23);
            this.shuffleBtn.TabIndex = 0;
            this.shuffleBtn.Text = "Shuffle";
            this.shuffleBtn.UseVisualStyleBackColor = true;
            this.shuffleBtn.Click += new System.EventHandler(this.shuffleBtn_Click);
            // 
            // createDeckBtn
            // 
            this.createDeckBtn.Location = new System.Drawing.Point(101, 458);
            this.createDeckBtn.Name = "createDeckBtn";
            this.createDeckBtn.Size = new System.Drawing.Size(75, 23);
            this.createDeckBtn.TabIndex = 1;
            this.createDeckBtn.Text = "Create Deck";
            this.createDeckBtn.UseVisualStyleBackColor = true;
            this.createDeckBtn.Click += new System.EventHandler(this.createDeckBtn_Click);
            // 
            // formCardGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 593);
            this.Controls.Add(this.createDeckBtn);
            this.Controls.Add(this.shuffleBtn);
            this.Name = "formCardGame";
            this.Text = "A Card Game!";
            this.ResumeLayout(false);

        }

        #endregion

        private Button shuffleBtn;
        private Button createDeckBtn;
    }
}