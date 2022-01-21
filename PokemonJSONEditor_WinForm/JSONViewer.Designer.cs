namespace PokemonJSONEditor_WinForm
{
    partial class JSONViewer
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
            this.txtJsonViewer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtJsonViewer
            // 
            this.txtJsonViewer.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtJsonViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJsonViewer.ForeColor = System.Drawing.Color.Lime;
            this.txtJsonViewer.Location = new System.Drawing.Point(0, 0);
            this.txtJsonViewer.Name = "txtJsonViewer";
            this.txtJsonViewer.Size = new System.Drawing.Size(965, 657);
            this.txtJsonViewer.TabIndex = 0;
            this.txtJsonViewer.Text = "";
            // 
            // JSONViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 657);
            this.Controls.Add(this.txtJsonViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "JSONViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox txtJsonViewer;
    }
}