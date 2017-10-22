namespace RSASignature.Model
{
    partial class ClientForm
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
            this.Request = new System.Windows.Forms.Button();
            this.Generation = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.TextBox();
            this.MsgLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label1.Location = new System.Drawing.Point(119, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент";
            // 
            // Request
            // 
            this.Request.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Request.Location = new System.Drawing.Point(61, 92);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(261, 66);
            this.Request.TabIndex = 1;
            this.Request.Text = "Отправить запрос";
            this.Request.UseVisualStyleBackColor = true;
            this.Request.Visible = false;
            this.Request.Click += new System.EventHandler(this.SendRequest);
            // 
            // Generation
            // 
            this.Generation.AutoSize = true;
            this.Generation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generation.Location = new System.Drawing.Point(76, 92);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(236, 24);
            this.Generation.TabIndex = 2;
            this.Generation.Text = "Идет генерация ключей..";
            // 
            // Message
            // 
            this.Message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Message.Location = new System.Drawing.Point(12, 213);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Message.Size = new System.Drawing.Size(360, 94);
            this.Message.TabIndex = 3;
            this.Message.Visible = false;
            // 
            // MsgLabel
            // 
            this.MsgLabel.AutoSize = true;
            this.MsgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MsgLabel.Location = new System.Drawing.Point(12, 186);
            this.MsgLabel.Name = "MsgLabel";
            this.MsgLabel.Size = new System.Drawing.Size(113, 24);
            this.MsgLabel.TabIndex = 4;
            this.MsgLabel.Text = "Сообщение";
            this.MsgLabel.Visible = false;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.MsgLabel);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.Request);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientForm";
            this.Text = "Клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Request;
        private System.Windows.Forms.Label Generation;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Label MsgLabel;
    }
}