namespace DAndDCharRoller
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
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(3, 12);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(126, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "New Character";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(3, 41);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(126, 23);
            this.btn_Load.TabIndex = 1;
            this.btn_Load.Text = "Load Character";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(3, 71);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(126, 23);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(141, 120);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_New);
            this.Name = "MainForm";
            this.Text = "D&d Character Roller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Exit;
    }
}

