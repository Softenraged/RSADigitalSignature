namespace RSASignature
{
    partial class ControlPanel
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
            this.StartModel = new System.Windows.Forms.Button();
            this.Maximize = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartModel
            // 
            this.StartModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartModel.Location = new System.Drawing.Point(59, 220);
            this.StartModel.Name = "StartModel";
            this.StartModel.Size = new System.Drawing.Size(332, 128);
            this.StartModel.TabIndex = 0;
            this.StartModel.Text = "Запустить модель";
            this.StartModel.UseVisualStyleBackColor = true;
            this.StartModel.Click += new System.EventHandler(this.Start);
            // 
            // Maximize
            // 
            this.Maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Maximize.Location = new System.Drawing.Point(3, 114);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(220, 100);
            this.Maximize.TabIndex = 1;
            this.Maximize.Text = "Развернуть";
            this.Maximize.UseVisualStyleBackColor = true;
            this.Maximize.Visible = false;
            this.Maximize.Click += new System.EventHandler(this.Show);
            // 
            // Minimize
            // 
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minimize.Location = new System.Drawing.Point(229, 114);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(220, 100);
            this.Minimize.TabIndex = 2;
            this.Minimize.Text = "Свернуть";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Visible = false;
            this.Minimize.Click += new System.EventHandler(this.Hide);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 376);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Maximize);
            this.Controls.Add(this.StartModel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ControlPanel";
            this.Text = "Панель управления";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartModel;
        private System.Windows.Forms.Button Maximize;
        private System.Windows.Forms.Button Minimize;
    }
}

