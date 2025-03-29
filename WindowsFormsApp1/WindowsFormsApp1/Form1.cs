using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace WindowsFormsApp1
{
    public partial class Notepad: Form
    {

        string name_file = "text.txt";
        public Notepad()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Открыть

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextArea.Text = File.ReadAllText(openFileDialog.FileName);
                name_file = openFileDialog.FileName.ToString();
            }
        }

        // Сохранить

        private void SaveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(name_file, TextArea.Text); 
        }

        // Сохранить как

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, TextArea.Text);
                name_file = saveFileDialog.FileName.ToString();
            }
        }

        private int CountWords(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return 0;
            }

            string[] words = text.Split(new char[] { ' ', '\n', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        // Закрыть файл

        private void CloseButton_Click(object sender, EventArgs e)
        {
            TextArea.Clear();
        }

        private void ColorPickerLabel_Click(object sender, EventArgs e)
        {
            using (var ColorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    ColorPickerLabel.ForeColor = colorDialog.Color;
                    TextArea.ForeColor = colorDialog.Color;

                }
            }
        }

        private void Notepad_Resize(object sender, EventArgs e)
        {
            if (this.Width < 700)
            {
                this.Width = 700;
            }

            if (this.Height < 500)
            {
                this.Height = 500;
            }

            TextArea.Width = this.Width - 50;
            TextArea.Height = this.Height - 100;

            ColorPickerLabel.Top = this.ClientSize.Height - ColorPickerLabel.Height - 10;
            WordCounter.Left = this.ClientSize.Width - WordCounter.Width - 50;
            WordCounter.Top = this.ClientSize.Height - WordCounter.Height - 10;
            BackgroundPicture.Width = this.Width;

        }

        // Подсчёт слов

        private void TextArea_TextChanged(object sender, EventArgs e)
        {
            int WordCount = CountWords(TextArea.Text);
            WordCounter.Text = $"Слов: {WordCount}";

            if (colorDialog.Color != Color.Black)
            {
                TextArea.ForeColor = colorDialog.Color;
            }
        }
    }
}
