namespace MusicPlayer.Design.Display
{
    partial class SearchWnd
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
			this.SearchFld = new System.Windows.Forms.TextBox();
			this.SearchBttn = new System.Windows.Forms.Button();
			this.log = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// SearchFld
			// 
			this.SearchFld.Location = new System.Drawing.Point(12, 15);
			this.SearchFld.Name = "SearchFld";
			this.SearchFld.Size = new System.Drawing.Size(502, 20);
			this.SearchFld.TabIndex = 5;
			// 
			// SearchBttn
			// 
			this.SearchBttn.Location = new System.Drawing.Point(521, 13);
			this.SearchBttn.Name = "SearchBttn";
			this.SearchBttn.Size = new System.Drawing.Size(91, 23);
			this.SearchBttn.TabIndex = 8;
			this.SearchBttn.Text = "Search";
			this.SearchBttn.UseVisualStyleBackColor = true;
			this.SearchBttn.Click += new System.EventHandler(this.SearchBttn_Click);
			// 
			// log
			// 
			this.log.Location = new System.Drawing.Point(12, 42);
			this.log.Multiline = true;
			this.log.Name = "log";
			this.log.Size = new System.Drawing.Size(600, 244);
			this.log.TabIndex = 9;
			// 
			// SearchWnd
			// 
			this.AcceptButton = this.SearchBttn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(625, 301);
			this.Controls.Add(this.log);
			this.Controls.Add(this.SearchBttn);
			this.Controls.Add(this.SearchFld);
			this.Name = "SearchWnd";
			this.Text = "Search";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.TextBox SearchFld;
        private System.Windows.Forms.Button SearchBttn;
		private System.Windows.Forms.TextBox log;
    }
}