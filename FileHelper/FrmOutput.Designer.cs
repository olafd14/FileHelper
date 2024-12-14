namespace FileHelper
{
    partial class FrmOutput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOutput));
            lblOutput = new Label();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblOutput.Location = new Point(12, 9);
            lblOutput.MaximumSize = new Size(775, 0);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 21);
            lblOutput.TabIndex = 0;
            // 
            // FrmOutput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOutput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "FrmOutput";
            Text = "Program Wsparcia Seniorów";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
    }
}