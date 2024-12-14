namespace FileHelper
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            tbFolderPath = new TextBox();
            lblDescription = new Label();
            btnCheck = new Button();
            SuspendLayout();
            // 
            // tbFolderPath
            // 
            tbFolderPath.Location = new Point(12, 47);
            tbFolderPath.Name = "tbFolderPath";
            tbFolderPath.Size = new Size(438, 23);
            tbFolderPath.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblDescription.Location = new Point(12, 25);
            lblDescription.Name = "lblDescription";
            lblDescription.RightToLeft = RightToLeft.No;
            lblDescription.Size = new Size(339, 19);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Podaj ścieżkę do folderu który ma zostać sprawdzony:";
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnCheck.Location = new Point(12, 76);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(438, 25);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Sprawdź folder";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 123);
            Controls.Add(btnCheck);
            Controls.Add(lblDescription);
            Controls.Add(tbFolderPath);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(487, 162);
            MinimumSize = new Size(487, 162);
            Name = "frmMain";
            Text = "Program Wsparcia Seniorów";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbFolderPath;
        private Label lblDescription;
        private Button btnCheck;
    }
}
