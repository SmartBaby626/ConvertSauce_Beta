namespace ConvertSauce_Beta
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
            btnVideo = new Button();
            btnAudio = new Button();
            btnPDF = new Button();
            btnImage = new Button();
            btnOther = new Button();
            buymeacoffee = new Microsoft.Web.WebView2.WinForms.WebView2();
            pnlVideo = new Panel();
            lblTitle = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            gbxinp1vid = new GroupBox();
            gbxoutp1vid = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)buymeacoffee).BeginInit();
            pnlVideo.SuspendLayout();
            gbxinp1vid.SuspendLayout();
            gbxoutp1vid.SuspendLayout();
            SuspendLayout();
            // 
            // btnVideo
            // 
            btnVideo.Location = new Point(131, 288);
            btnVideo.Name = "btnVideo";
            btnVideo.Size = new Size(106, 36);
            btnVideo.TabIndex = 0;
            btnVideo.Text = "Video";
            btnVideo.UseVisualStyleBackColor = true;
            btnVideo.Click += btnVideo_Click;
            // 
            // btnAudio
            // 
            btnAudio.Enabled = false;
            btnAudio.Location = new Point(235, 288);
            btnAudio.Name = "btnAudio";
            btnAudio.Size = new Size(106, 36);
            btnAudio.TabIndex = 1;
            btnAudio.Text = "Audio";
            btnAudio.UseVisualStyleBackColor = true;
            // 
            // btnPDF
            // 
            btnPDF.Enabled = false;
            btnPDF.Location = new Point(339, 288);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(106, 36);
            btnPDF.TabIndex = 2;
            btnPDF.Text = "PDF";
            btnPDF.UseVisualStyleBackColor = true;
            // 
            // btnImage
            // 
            btnImage.Enabled = false;
            btnImage.Location = new Point(443, 288);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(106, 36);
            btnImage.TabIndex = 3;
            btnImage.Text = "Image";
            btnImage.UseVisualStyleBackColor = true;
            // 
            // btnOther
            // 
            btnOther.Enabled = false;
            btnOther.Location = new Point(547, 288);
            btnOther.Name = "btnOther";
            btnOther.Size = new Size(106, 36);
            btnOther.TabIndex = 4;
            btnOther.Text = "Other";
            btnOther.UseVisualStyleBackColor = true;
            // 
            // buymeacoffee
            // 
            buymeacoffee.AllowExternalDrop = true;
            buymeacoffee.CreationProperties = null;
            buymeacoffee.DefaultBackgroundColor = Color.White;
            buymeacoffee.Location = new Point(315, 330);
            buymeacoffee.Name = "buymeacoffee";
            buymeacoffee.Size = new Size(155, 43);
            buymeacoffee.Source = new Uri("file://C:\\Users\\aidan\\source\\repos\\ConvertSauce_Beta\\ConvertSauce_Beta\\resources\\buymeacoffee.html", UriKind.Absolute);
            buymeacoffee.TabIndex = 5;
            buymeacoffee.ZoomFactor = 0.5D;
            // 
            // pnlVideo
            // 
            pnlVideo.Controls.Add(gbxoutp1vid);
            pnlVideo.Controls.Add(gbxinp1vid);
            pnlVideo.Location = new Point(1, 0);
            pnlVideo.Name = "pnlVideo";
            pnlVideo.Size = new Size(800, 451);
            pnlVideo.TabIndex = 6;
            pnlVideo.Visible = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tox Typewriter", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(171, 136);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(421, 67);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "ConvertSauce";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(40, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 31);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 1;
            // 
            // gbxinp1vid
            // 
            gbxinp1vid.Controls.Add(comboBox1);
            gbxinp1vid.Location = new Point(108, 182);
            gbxinp1vid.Name = "gbxinp1vid";
            gbxinp1vid.Size = new Size(200, 100);
            gbxinp1vid.TabIndex = 2;
            gbxinp1vid.TabStop = false;
            gbxinp1vid.Text = "Input";
            // 
            // gbxoutp1vid
            // 
            gbxoutp1vid.Controls.Add(comboBox2);
            gbxoutp1vid.Location = new Point(479, 182);
            gbxoutp1vid.Name = "gbxoutp1vid";
            gbxoutp1vid.Size = new Size(200, 100);
            gbxoutp1vid.TabIndex = 3;
            gbxoutp1vid.TabStop = false;
            gbxoutp1vid.Text = "Output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlVideo);
            Controls.Add(buymeacoffee);
            Controls.Add(lblTitle);
            Controls.Add(btnOther);
            Controls.Add(btnImage);
            Controls.Add(btnPDF);
            Controls.Add(btnAudio);
            Controls.Add(btnVideo);
            Name = "Form1";
            Text = "ConvertSauce";
            ((System.ComponentModel.ISupportInitialize)buymeacoffee).EndInit();
            pnlVideo.ResumeLayout(false);
            gbxinp1vid.ResumeLayout(false);
            gbxoutp1vid.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVideo;
        private Button btnAudio;
        private Button btnPDF;
        private Button btnImage;
        private Button btnOther;
        private Microsoft.Web.WebView2.WinForms.WebView2 buymeacoffee;
        private Panel pnlVideo;
        private Label lblTitle;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private GroupBox gbxoutp1vid;
        private GroupBox gbxinp1vid;
    }
}
