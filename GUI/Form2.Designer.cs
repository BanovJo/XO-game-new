namespace GUI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.newGame = new System.Windows.Forms.Button();
            this.b11 = new System.Windows.Forms.Button();
            this.b12 = new System.Windows.Forms.Button();
            this.b13 = new System.Windows.Forms.Button();
            this.b21 = new System.Windows.Forms.Button();
            this.b22 = new System.Windows.Forms.Button();
            this.b23 = new System.Windows.Forms.Button();
            this.b31 = new System.Windows.Forms.Button();
            this.b32 = new System.Windows.Forms.Button();
            this.b33 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newGame
            // 
            this.newGame.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.newGame.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newGame.Location = new System.Drawing.Point(252, 349);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(74, 47);
            this.newGame.TabIndex = 0;
            this.newGame.Text = "NEW GAME";
            this.newGame.UseVisualStyleBackColor = false;
            this.newGame.Click += new System.EventHandler(this.newGame1);
            // 
            // b11
            // 
            this.b11.Location = new System.Drawing.Point(39, 43);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(80, 80);
            this.b11.TabIndex = 1;
            this.b11.UseVisualStyleBackColor = true;
            this.b11.Click += new System.EventHandler(this.button_click);
            // 
            // b12
            // 
            this.b12.Location = new System.Drawing.Point(125, 43);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(80, 80);
            this.b12.TabIndex = 2;
            this.b12.UseVisualStyleBackColor = true;
            this.b12.Click += new System.EventHandler(this.button_click);
            // 
            // b13
            // 
            this.b13.Location = new System.Drawing.Point(211, 43);
            this.b13.Name = "b13";
            this.b13.Size = new System.Drawing.Size(80, 80);
            this.b13.TabIndex = 3;
            this.b13.UseVisualStyleBackColor = true;
            this.b13.Click += new System.EventHandler(this.button_click);
            // 
            // b21
            // 
            this.b21.Location = new System.Drawing.Point(39, 129);
            this.b21.Name = "b21";
            this.b21.Size = new System.Drawing.Size(80, 80);
            this.b21.TabIndex = 4;
            this.b21.UseVisualStyleBackColor = true;
            this.b21.Click += new System.EventHandler(this.button_click);
            // 
            // b22
            // 
            this.b22.Location = new System.Drawing.Point(125, 129);
            this.b22.Name = "b22";
            this.b22.Size = new System.Drawing.Size(80, 80);
            this.b22.TabIndex = 5;
            this.b22.UseVisualStyleBackColor = true;
            this.b22.Click += new System.EventHandler(this.button_click);
            // 
            // b23
            // 
            this.b23.Location = new System.Drawing.Point(211, 129);
            this.b23.Name = "b23";
            this.b23.Size = new System.Drawing.Size(80, 80);
            this.b23.TabIndex = 6;
            this.b23.UseVisualStyleBackColor = true;
            this.b23.Click += new System.EventHandler(this.button_click);
            // 
            // b31
            // 
            this.b31.Location = new System.Drawing.Point(39, 215);
            this.b31.Name = "b31";
            this.b31.Size = new System.Drawing.Size(80, 80);
            this.b31.TabIndex = 7;
            this.b31.UseVisualStyleBackColor = true;
            this.b31.Click += new System.EventHandler(this.button_click);
            // 
            // b32
            // 
            this.b32.Location = new System.Drawing.Point(125, 215);
            this.b32.Name = "b32";
            this.b32.Size = new System.Drawing.Size(80, 80);
            this.b32.TabIndex = 8;
            this.b32.UseVisualStyleBackColor = true;
            this.b32.Click += new System.EventHandler(this.button_click);
            // 
            // b33
            // 
            this.b33.Location = new System.Drawing.Point(211, 215);
            this.b33.Name = "b33";
            this.b33.Size = new System.Drawing.Size(80, 80);
            this.b33.TabIndex = 9;
            this.b33.UseVisualStyleBackColor = true;
            this.b33.Click += new System.EventHandler(this.button_click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(338, 408);
            this.Controls.Add(this.b33);
            this.Controls.Add(this.b32);
            this.Controls.Add(this.b31);
            this.Controls.Add(this.b23);
            this.Controls.Add(this.b22);
            this.Controls.Add(this.b21);
            this.Controls.Add(this.b13);
            this.Controls.Add(this.b12);
            this.Controls.Add(this.b11);
            this.Controls.Add(this.newGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "XO game";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button b11;
        private System.Windows.Forms.Button b12;
        private System.Windows.Forms.Button b13;
        private System.Windows.Forms.Button b21;
        private System.Windows.Forms.Button b22;
        private System.Windows.Forms.Button b23;
        private System.Windows.Forms.Button b31;
        private System.Windows.Forms.Button b32;
        private System.Windows.Forms.Button b33;
    }
}