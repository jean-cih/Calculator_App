namespace NewCalculatorApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textInput = new System.Windows.Forms.TextBox();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelList = new System.Windows.Forms.Label();
            this.labelRad = new System.Windows.Forms.Label();
            this.labelClear = new System.Windows.Forms.Label();
            this.pictureClear = new System.Windows.Forms.PictureBox();
            this.buttonArrow = new System.Windows.Forms.PictureBox();
            this.buttonSettings = new System.Windows.Forms.PictureBox();
            this.ButtonRad = new System.Windows.Forms.PictureBox();
            this.pictureGray = new System.Windows.Forms.PictureBox();
            this.pictureOrange = new System.Windows.Forms.PictureBox();
            this.pictureGreen = new System.Windows.Forms.PictureBox();
            this.pictureRed = new System.Windows.Forms.PictureBox();
            this.picturePerson = new System.Windows.Forms.PictureBox();
            this.pictureInput = new System.Windows.Forms.PictureBox();
            this.pictureOutput = new System.Windows.Forms.PictureBox();
            this.pictureList = new System.Windows.Forms.PictureBox();
            this.pictureBackSet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textInput.BackColor = System.Drawing.Color.Black;
            this.textInput.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textInput.Location = new System.Drawing.Point(50, 89);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textInput.Size = new System.Drawing.Size(322, 52);
            this.textInput.TabIndex = 0;
            this.textInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textInput.TextChanged += new System.EventHandler(this.textInput_TextChanged);
            // 
            // textOutput
            // 
            this.textOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textOutput.BackColor = System.Drawing.Color.Black;
            this.textOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textOutput.Location = new System.Drawing.Point(50, 318);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(322, 52);
            this.textOutput.TabIndex = 1;
            this.textOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox
            // 
            this.listBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox.BackColor = System.Drawing.Color.Black;
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 29;
            this.listBox.Location = new System.Drawing.Point(526, 88);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(124, 321);
            this.listBox.TabIndex = 2;
            // 
            // labelInput
            // 
            this.labelInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInput.AutoSize = true;
            this.labelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelInput.Location = new System.Drawing.Point(121, 68);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(184, 18);
            this.labelInput.TabIndex = 11;
            this.labelInput.Text = "Что нужно посчитать?";
            // 
            // labelList
            // 
            this.labelList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelList.AutoSize = true;
            this.labelList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.labelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelList.Location = new System.Drawing.Point(544, 68);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(88, 18);
            this.labelList.TabIndex = 13;
            this.labelList.Text = "Структура";
            // 
            // labelRad
            // 
            this.labelRad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRad.AutoSize = true;
            this.labelRad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.labelRad.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelRad.Location = new System.Drawing.Point(161, 166);
            this.labelRad.Name = "labelRad";
            this.labelRad.Size = new System.Drawing.Size(46, 21);
            this.labelRad.TabIndex = 15;
            this.labelRad.Text = "Rad";
            this.labelRad.Click += new System.EventHandler(this.labelRad_Click);
            // 
            // labelClear
            // 
            this.labelClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClear.AutoSize = true;
            this.labelClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.labelClear.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelClear.Location = new System.Drawing.Point(220, 166);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(60, 21);
            this.labelClear.TabIndex = 19;
            this.labelClear.Text = "Clear";
            this.labelClear.Click += new System.EventHandler(this.labelClear_Click);
            // 
            // pictureClear
            // 
            this.pictureClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureClear.BackColor = System.Drawing.Color.Transparent;
            this.pictureClear.Image = global::NewCalculatorApp.Properties.Resources.RectangleInput;
            this.pictureClear.Location = new System.Drawing.Point(213, 157);
            this.pictureClear.Name = "pictureClear";
            this.pictureClear.Size = new System.Drawing.Size(62, 35);
            this.pictureClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClear.TabIndex = 18;
            this.pictureClear.TabStop = false;
            this.pictureClear.Click += new System.EventHandler(this.pictureClear_Click);
            // 
            // buttonArrow
            // 
            this.buttonArrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonArrow.BackColor = System.Drawing.Color.Transparent;
            this.buttonArrow.Image = global::NewCalculatorApp.Properties.Resources.Arrow;
            this.buttonArrow.Location = new System.Drawing.Point(12, 392);
            this.buttonArrow.Name = "buttonArrow";
            this.buttonArrow.Size = new System.Drawing.Size(50, 50);
            this.buttonArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonArrow.TabIndex = 17;
            this.buttonArrow.TabStop = false;
            this.buttonArrow.Click += new System.EventHandler(this.buttonArrow_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.Image = global::NewCalculatorApp.Properties.Resources.Settings;
            this.buttonSettings.Location = new System.Drawing.Point(688, 17);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(50, 50);
            this.buttonSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonSettings.TabIndex = 16;
            this.buttonSettings.TabStop = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // ButtonRad
            // 
            this.ButtonRad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonRad.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRad.Image = global::NewCalculatorApp.Properties.Resources.RectangleInput;
            this.ButtonRad.Location = new System.Drawing.Point(154, 157);
            this.ButtonRad.Name = "ButtonRad";
            this.ButtonRad.Size = new System.Drawing.Size(50, 35);
            this.ButtonRad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonRad.TabIndex = 14;
            this.ButtonRad.TabStop = false;
            this.ButtonRad.Click += new System.EventHandler(this.ButtonRad_Click);
            // 
            // pictureGray
            // 
            this.pictureGray.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureGray.BackColor = System.Drawing.Color.Transparent;
            this.pictureGray.Location = new System.Drawing.Point(547, 12);
            this.pictureGray.Name = "pictureGray";
            this.pictureGray.Size = new System.Drawing.Size(69, 52);
            this.pictureGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGray.TabIndex = 8;
            this.pictureGray.TabStop = false;
            // 
            // pictureOrange
            // 
            this.pictureOrange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureOrange.BackColor = System.Drawing.Color.Transparent;
            this.pictureOrange.Location = new System.Drawing.Point(60, 243);
            this.pictureOrange.Name = "pictureOrange";
            this.pictureOrange.Size = new System.Drawing.Size(69, 58);
            this.pictureOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOrange.TabIndex = 7;
            this.pictureOrange.TabStop = false;
            // 
            // pictureGreen
            // 
            this.pictureGreen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureGreen.BackColor = System.Drawing.Color.Transparent;
            this.pictureGreen.Location = new System.Drawing.Point(673, 318);
            this.pictureGreen.Name = "pictureGreen";
            this.pictureGreen.Size = new System.Drawing.Size(59, 60);
            this.pictureGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGreen.TabIndex = 6;
            this.pictureGreen.TabStop = false;
            // 
            // pictureRed
            // 
            this.pictureRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureRed.BackColor = System.Drawing.Color.Transparent;
            this.pictureRed.Location = new System.Drawing.Point(180, 12);
            this.pictureRed.Name = "pictureRed";
            this.pictureRed.Size = new System.Drawing.Size(69, 50);
            this.pictureRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRed.TabIndex = 5;
            this.pictureRed.TabStop = false;
            // 
            // picturePerson
            // 
            this.picturePerson.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picturePerson.BackColor = System.Drawing.Color.Transparent;
            this.picturePerson.Location = new System.Drawing.Point(386, 85);
            this.picturePerson.Name = "picturePerson";
            this.picturePerson.Size = new System.Drawing.Size(120, 297);
            this.picturePerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePerson.TabIndex = 3;
            this.picturePerson.TabStop = false;
            // 
            // pictureInput
            // 
            this.pictureInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureInput.BackColor = System.Drawing.Color.Transparent;
            this.pictureInput.Location = new System.Drawing.Point(38, 64);
            this.pictureInput.Name = "pictureInput";
            this.pictureInput.Size = new System.Drawing.Size(348, 86);
            this.pictureInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureInput.TabIndex = 9;
            this.pictureInput.TabStop = false;
            // 
            // pictureOutput
            // 
            this.pictureOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureOutput.BackColor = System.Drawing.Color.Transparent;
            this.pictureOutput.Location = new System.Drawing.Point(38, 301);
            this.pictureOutput.Name = "pictureOutput";
            this.pictureOutput.Size = new System.Drawing.Size(348, 86);
            this.pictureOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOutput.TabIndex = 10;
            this.pictureOutput.TabStop = false;
            // 
            // pictureList
            // 
            this.pictureList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureList.BackColor = System.Drawing.Color.Transparent;
            this.pictureList.Location = new System.Drawing.Point(508, 64);
            this.pictureList.Name = "pictureList";
            this.pictureList.Size = new System.Drawing.Size(159, 345);
            this.pictureList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureList.TabIndex = 12;
            this.pictureList.TabStop = false;
            // 
            // pictureBackSet
            // 
            this.pictureBackSet.Image = global::NewCalculatorApp.Properties.Resources.BackSettings;
            this.pictureBackSet.Location = new System.Drawing.Point(0, 0);
            this.pictureBackSet.Name = "pictureBackSet";
            this.pictureBackSet.Size = new System.Drawing.Size(753, 462);
            this.pictureBackSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBackSet.TabIndex = 20;
            this.pictureBackSet.TabStop = false;
            // 
            // Form1
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 454);
            this.Controls.Add(this.buttonArrow);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.pictureBackSet);
            this.Controls.Add(this.labelClear);
            this.Controls.Add(this.pictureClear);
            this.Controls.Add(this.labelRad);
            this.Controls.Add(this.ButtonRad);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.pictureGray);
            this.Controls.Add(this.pictureOrange);
            this.Controls.Add(this.pictureGreen);
            this.Controls.Add(this.pictureRed);
            this.Controls.Add(this.picturePerson);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.pictureInput);
            this.Controls.Add(this.pictureOutput);
            this.Controls.Add(this.pictureList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.PictureBox picturePerson;
        private System.Windows.Forms.PictureBox pictureRed;
        private System.Windows.Forms.PictureBox pictureGreen;
        private System.Windows.Forms.PictureBox pictureOrange;
        private System.Windows.Forms.PictureBox pictureGray;
        private System.Windows.Forms.PictureBox pictureInput;
        private System.Windows.Forms.PictureBox pictureOutput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.PictureBox pictureList;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.PictureBox ButtonRad;
        private System.Windows.Forms.Label labelRad;
        private System.Windows.Forms.PictureBox buttonSettings;
        private System.Windows.Forms.PictureBox buttonArrow;
        private System.Windows.Forms.Label labelClear;
        private System.Windows.Forms.PictureBox pictureClear;
        private System.Windows.Forms.PictureBox pictureBackSet;
    }
}

