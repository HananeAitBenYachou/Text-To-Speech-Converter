namespace TextToSpeechConverter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLanguages = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnPauseResume = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.trbSpeed = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVoices = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConvertTextToSpeech = new Guna.UI2.WinForms.Guna2Button();
            this.tbText = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btnExit);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.cbLanguages);
            this.guna2GradientPanel1.Controls.Add(this.btnRefresh);
            this.guna2GradientPanel1.Controls.Add(this.btnPauseResume);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.trbSpeed);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.cbVoices);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.btnConvertTextToSpeech);
            this.guna2GradientPanel1.Controls.Add(this.tbText);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(14)))), ((int)(((byte)(98)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(8)))), ((int)(((byte)(90)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-15, -15);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1176, 919);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(60, 60);
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.btnExit.Image = global::TextToSpeechConverter.Properties.Resources.close;
            this.btnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageRotate = 0F;
            this.btnExit.ImageSize = new System.Drawing.Size(60, 60);
            this.btnExit.Location = new System.Drawing.Point(1102, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(60, 60);
            this.btnExit.Size = new System.Drawing.Size(60, 60);
            this.btnExit.TabIndex = 17;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text To Speech Converter";
            // 
            // cbLanguages
            // 
            this.cbLanguages.BackColor = System.Drawing.Color.Transparent;
            this.cbLanguages.BorderRadius = 15;
            this.cbLanguages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguages.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLanguages.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLanguages.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLanguages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbLanguages.ItemHeight = 40;
            this.cbLanguages.Location = new System.Drawing.Point(508, 204);
            this.cbLanguages.Name = "cbLanguages";
            this.cbLanguages.Size = new System.Drawing.Size(300, 46);
            this.cbLanguages.TabIndex = 16;
            this.cbLanguages.SelectedIndexChanged += new System.EventHandler(this.cbLanguages_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Image = global::TextToSpeechConverter.Properties.Resources.refresh;
            this.btnRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRefresh.ImageRotate = 0F;
            this.btnRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Location = new System.Drawing.Point(232, 779);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Size = new System.Drawing.Size(30, 30);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPauseResume
            // 
            this.btnPauseResume.BackColor = System.Drawing.Color.Transparent;
            this.btnPauseResume.BorderRadius = 23;
            this.btnPauseResume.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPauseResume.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPauseResume.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPauseResume.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPauseResume.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(101)))));
            this.btnPauseResume.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPauseResume.ForeColor = System.Drawing.Color.White;
            this.btnPauseResume.Image = global::TextToSpeechConverter.Properties.Resources.pause;
            this.btnPauseResume.ImageSize = new System.Drawing.Size(17, 17);
            this.btnPauseResume.Location = new System.Drawing.Point(611, 779);
            this.btnPauseResume.Name = "btnPauseResume";
            this.btnPauseResume.Size = new System.Drawing.Size(155, 53);
            this.btnPauseResume.TabIndex = 14;
            this.btnPauseResume.Text = "Pause";
            this.btnPauseResume.TextChanged += new System.EventHandler(this.btnPauseResume_TextChanged);
            this.btnPauseResume.Click += new System.EventHandler(this.btnPauseResume_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(349, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select speed";
            // 
            // trbSpeed
            // 
            this.trbSpeed.BackColor = System.Drawing.Color.Transparent;
            this.trbSpeed.LargeChange = 1;
            this.trbSpeed.Location = new System.Drawing.Point(508, 367);
            this.trbSpeed.Maximum = 10;
            this.trbSpeed.Minimum = -10;
            this.trbSpeed.Name = "trbSpeed";
            this.trbSpeed.Size = new System.Drawing.Size(300, 23);
            this.trbSpeed.TabIndex = 10;
            this.trbSpeed.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trbSpeed.Value = 0;
            this.trbSpeed.ValueChanged += new System.EventHandler(this.trbSpeed_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(349, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select voice";
            // 
            // cbVoices
            // 
            this.cbVoices.BackColor = System.Drawing.Color.Transparent;
            this.cbVoices.BorderRadius = 15;
            this.cbVoices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoices.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVoices.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVoices.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbVoices.ItemHeight = 40;
            this.cbVoices.Location = new System.Drawing.Point(508, 284);
            this.cbVoices.Name = "cbVoices";
            this.cbVoices.Size = new System.Drawing.Size(300, 46);
            this.cbVoices.TabIndex = 6;
            this.cbVoices.SelectedIndexChanged += new System.EventHandler(this.cbVoices_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(349, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select language";
            // 
            // btnConvertTextToSpeech
            // 
            this.btnConvertTextToSpeech.BackColor = System.Drawing.Color.Transparent;
            this.btnConvertTextToSpeech.BorderRadius = 23;
            this.btnConvertTextToSpeech.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConvertTextToSpeech.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConvertTextToSpeech.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConvertTextToSpeech.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConvertTextToSpeech.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(101)))));
            this.btnConvertTextToSpeech.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertTextToSpeech.ForeColor = System.Drawing.Color.White;
            this.btnConvertTextToSpeech.Image = global::TextToSpeechConverter.Properties.Resources.play;
            this.btnConvertTextToSpeech.ImageSize = new System.Drawing.Size(17, 17);
            this.btnConvertTextToSpeech.Location = new System.Drawing.Point(782, 779);
            this.btnConvertTextToSpeech.Name = "btnConvertTextToSpeech";
            this.btnConvertTextToSpeech.Size = new System.Drawing.Size(155, 53);
            this.btnConvertTextToSpeech.TabIndex = 3;
            this.btnConvertTextToSpeech.Text = "Listen";
            this.btnConvertTextToSpeech.Click += new System.EventHandler(this.btnConvertTextToSpeech_Click);
            // 
            // tbText
            // 
            this.tbText.BackColor = System.Drawing.Color.Transparent;
            this.tbText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(132)))));
            this.tbText.BorderRadius = 20;
            this.tbText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbText.DefaultText = "";
            this.tbText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(132)))));
            this.tbText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbText.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbText.ForeColor = System.Drawing.Color.White;
            this.tbText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbText.Location = new System.Drawing.Point(232, 450);
            this.tbText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.PasswordChar = '\0';
            this.tbText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(237)))));
            this.tbText.PlaceholderText = " Write anything here ...";
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbText.SelectedText = "";
            this.tbText.Size = new System.Drawing.Size(705, 320);
            this.tbText.TabIndex = 10;
            this.tbText.Validating += new System.ComponentModel.CancelEventHandler(this.tbText_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 881);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbText;
        private Guna.UI2.WinForms.Guna2Button btnConvertTextToSpeech;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbVoices;
        private Guna.UI2.WinForms.Guna2TrackBar trbSpeed;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnPauseResume;
        private Guna.UI2.WinForms.Guna2ImageButton btnRefresh;
        private Guna.UI2.WinForms.Guna2ComboBox cbLanguages;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
    }
}

