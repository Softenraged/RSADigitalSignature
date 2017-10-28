namespace RSASignature.Model
{
    partial class EnemyForm
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
            this.AttackBtn = new System.Windows.Forms.Button();
            this.MsgLabel = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.TextBox();
            this.EnemyLabel = new System.Windows.Forms.Label();
            this.Generation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AttackBtn
            // 
            this.AttackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AttackBtn.Location = new System.Drawing.Point(64, 88);
            this.AttackBtn.Name = "AttackBtn";
            this.AttackBtn.Size = new System.Drawing.Size(261, 66);
            this.AttackBtn.TabIndex = 2;
            this.AttackBtn.Text = "Произвести атаку";
            this.AttackBtn.UseVisualStyleBackColor = true;
            this.AttackBtn.Visible = false;
            this.AttackBtn.Click += new System.EventHandler(this.Attack);
            // 
            // MsgLabel
            // 
            this.MsgLabel.AutoSize = true;
            this.MsgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MsgLabel.Location = new System.Drawing.Point(12, 178);
            this.MsgLabel.Name = "MsgLabel";
            this.MsgLabel.Size = new System.Drawing.Size(113, 24);
            this.MsgLabel.TabIndex = 6;
            this.MsgLabel.Text = "Сообщение";
            this.MsgLabel.Visible = false;
            // 
            // Message
            // 
            this.Message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Message.Location = new System.Drawing.Point(12, 205);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Message.Size = new System.Drawing.Size(360, 94);
            this.Message.TabIndex = 5;
            this.Message.Visible = false;
            // 
            // EnemyLabel
            // 
            this.EnemyLabel.AutoSize = true;
            this.EnemyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.EnemyLabel.Location = new System.Drawing.Point(85, 20);
            this.EnemyLabel.Name = "EnemyLabel";
            this.EnemyLabel.Size = new System.Drawing.Size(206, 42);
            this.EnemyLabel.TabIndex = 7;
            this.EnemyLabel.Text = "Противник";
            // 
            // Generation
            // 
            this.Generation.AutoSize = true;
            this.Generation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generation.Location = new System.Drawing.Point(76, 88);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(236, 24);
            this.Generation.TabIndex = 8;
            this.Generation.Text = "Идет генерация ключей..";
            // 
            // EnemyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.ControlBox = false;
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.EnemyLabel);
            this.Controls.Add(this.MsgLabel);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.AttackBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnemyForm";
            this.Text = "Противник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AttackBtn;
        private System.Windows.Forms.Label MsgLabel;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Label EnemyLabel;
        private System.Windows.Forms.Label Generation;
    }
}