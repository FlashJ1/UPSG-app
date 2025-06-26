namespace Portal_Speedrunning_Guide_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BGImage = new PictureBox();
            BTStart = new Button();
            ((System.ComponentModel.ISupportInitialize)BGImage).BeginInit();
            SuspendLayout();
            // 
            // BGImage
            // 
            BGImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BGImage.BorderStyle = BorderStyle.Fixed3D;
            BGImage.Image = (Image)resources.GetObject("BGImage.Image");
            BGImage.Location = new Point(0, 0);
            BGImage.Margin = new Padding(0);
            BGImage.Name = "BGImage";
            BGImage.Size = new Size(800, 450);
            BGImage.TabIndex = 0;
            BGImage.TabStop = false;
            // 
            // BTStart
            // 
            BTStart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BTStart.BackColor = Color.FromArgb(31, 72, 126);
            BTStart.FlatStyle = FlatStyle.Flat;
            BTStart.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BTStart.ForeColor = Color.FromArgb(179, 141, 151);
            BTStart.Location = new Point(284, 133);
            BTStart.Margin = new Padding(0);
            BTStart.Name = "BTStart";
            BTStart.Size = new Size(227, 88);
            BTStart.TabIndex = 1;
            BTStart.Text = "Start";
            BTStart.UseVisualStyleBackColor = false;
            BTStart.Click += BTStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTStart);
            Controls.Add(BGImage);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)BGImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox BGImage;
        private Button BTStart;
    }
}
