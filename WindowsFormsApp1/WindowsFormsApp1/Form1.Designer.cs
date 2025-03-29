namespace WindowsFormsApp1
{
    partial class Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.BackgroundPicture = new System.Windows.Forms.PictureBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveAsButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TextArea = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.WordCounter = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.ColorPickerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundPicture
            // 
            this.BackgroundPicture.Image = ((System.Drawing.Image)(resources.GetObject("BackgroundPicture.Image")));
            this.BackgroundPicture.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPicture.Name = "BackgroundPicture";
            this.BackgroundPicture.Size = new System.Drawing.Size(730, 32);
            this.BackgroundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundPicture.TabIndex = 0;
            this.BackgroundPicture.TabStop = false;
            this.BackgroundPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(0, 0);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(115, 32);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "Открыть";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(121, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(115, 32);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.Location = new System.Drawing.Point(242, 0);
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(115, 32);
            this.SaveAsButton.TabIndex = 3;
            this.SaveAsButton.Text = "Сохранить как";
            this.SaveAsButton.UseVisualStyleBackColor = true;
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(363, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(115, 32);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Очистить всё";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TextArea
            // 
            this.TextArea.Location = new System.Drawing.Point(12, 38);
            this.TextArea.Name = "TextArea";
            this.TextArea.Size = new System.Drawing.Size(706, 387);
            this.TextArea.TabIndex = 5;
            this.TextArea.Text = "";
            this.TextArea.TextChanged += new System.EventHandler(this.TextArea_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // WordCounter
            // 
            this.WordCounter.AutoSize = true;
            this.WordCounter.Location = new System.Drawing.Point(654, 428);
            this.WordCounter.Name = "WordCounter";
            this.WordCounter.Size = new System.Drawing.Size(44, 13);
            this.WordCounter.TabIndex = 6;
            this.WordCounter.Text = "Слов: 0";
            // 
            // ColorPickerLabel
            // 
            this.ColorPickerLabel.AutoSize = true;
            this.ColorPickerLabel.Location = new System.Drawing.Point(9, 428);
            this.ColorPickerLabel.Name = "ColorPickerLabel";
            this.ColorPickerLabel.Size = new System.Drawing.Size(32, 13);
            this.ColorPickerLabel.TabIndex = 7;
            this.ColorPickerLabel.Text = "Цвет";
            this.ColorPickerLabel.Click += new System.EventHandler(this.ColorPickerLabel_Click);
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.ColorPickerLabel);
            this.Controls.Add(this.WordCounter);
            this.Controls.Add(this.TextArea);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveAsButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.BackgroundPicture);
            this.Name = "Notepad";
            this.Text = " ";
            this.Resize += new System.EventHandler(this.Notepad_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackgroundPicture;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SaveAsButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.RichTextBox TextArea;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label WordCounter;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label ColorPickerLabel;
    }
}

