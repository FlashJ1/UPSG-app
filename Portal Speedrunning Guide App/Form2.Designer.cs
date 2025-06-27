namespace Portal_Speedrunning_Guide_App
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            CBCategory = new ComboBox();
            labelMap = new Label();
            LBStrats = new ListBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            CBMap = new ComboBox();
            textBox1 = new TextBox();
            labelRank = new Label();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(562, 24);
            label1.TabIndex = 0;
            label1.Text = "Select which category you would like to learn:";
            // 
            // CBCategory
            // 
            CBCategory.FormattingEnabled = true;
            CBCategory.Location = new Point(12, 37);
            CBCategory.Name = "CBCategory";
            CBCategory.Size = new Size(121, 23);
            CBCategory.TabIndex = 1;
            // 
            // labelMap
            // 
            labelMap.AutoSize = true;
            labelMap.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            labelMap.Location = new Point(12, 80);
            labelMap.Name = "labelMap";
            labelMap.Size = new Size(130, 24);
            labelMap.TabIndex = 4;
            labelMap.Text = "Select map";
            // 
            // LBStrats
            // 
            LBStrats.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            LBStrats.FormattingEnabled = true;
            LBStrats.HorizontalScrollbar = true;
            LBStrats.ItemHeight = 24;
            LBStrats.Location = new Point(12, 116);
            LBStrats.Name = "LBStrats";
            LBStrats.Size = new Size(313, 172);
            LBStrats.TabIndex = 5;
            LBStrats.SelectedIndexChanged += LBStrats_SelectedIndexChanged;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(332, 37);
            webView21.Name = "webView21";
            webView21.Size = new Size(819, 438);
            webView21.TabIndex = 6;
            webView21.ZoomFactor = 1D;
            // 
            // CBMap
            // 
            CBMap.FormattingEnabled = true;
            CBMap.Location = new Point(205, 36);
            CBMap.Name = "CBMap";
            CBMap.Size = new Size(121, 23);
            CBMap.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            textBox1.Location = new Point(12, 305);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(313, 248);
            textBox1.TabIndex = 8;
            textBox1.Text = "Strat Description";
            // 
            // labelRank
            // 
            labelRank.AutoSize = true;
            labelRank.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            labelRank.Location = new Point(148, 80);
            labelRank.Name = "labelRank";
            labelRank.Size = new Size(130, 24);
            labelRank.TabIndex = 9;
            labelRank.Text = "Strat rank";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1197, 644);
            Controls.Add(labelRank);
            Controls.Add(textBox1);
            Controls.Add(CBMap);
            Controls.Add(webView21);
            Controls.Add(LBStrats);
            Controls.Add(labelMap);
            Controls.Add(CBCategory);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox CBCategory;
        private Label labelMap;
        private ListBox LBStrats;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private ComboBox CBMap;
        private TextBox textBox1;
        private Label labelRank;
    }
}