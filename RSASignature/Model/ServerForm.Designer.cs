namespace RSASignature.Model
{
    partial class ServerForm
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
            this.Log = new System.Windows.Forms.TextBox();
            this.Server = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Log
            // 
            this.Log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Log.Location = new System.Drawing.Point(12, 109);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log.Size = new System.Drawing.Size(360, 190);
            this.Log.TabIndex = 0;
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Server.Location = new System.Drawing.Point(117, 33);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(149, 42);
            this.Server.TabIndex = 1;
            this.Server.Text = "Сервер";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.Log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerForm";
            this.Text = "Сервер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Label Server;
    }
}