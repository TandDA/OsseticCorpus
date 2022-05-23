using OsseticCorpus.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsseticCorpus
{
    public partial class FormMain : Form
    {
        Dictionary<string, string> tagsDictionary = new Dictionary<string, string>();
        string[] tags;
        string lemma;
        bool PinClip = false;

        public FormMain()
        {
            InitializeComponent();
            vScrollBar.Visible = false;
            WriteDictionary();
            CheckModules();
        }
        private void Run_Cmd()
        {
            if (string.IsNullOrEmpty(textBoxWord.Text))
            {
                MessageBox.Show("Ошибка: Пустое поле ввода");
                return;
            }

            string currPath = Directory.GetCurrentDirectory();
            string fileName = currPath + "\\lingcorpora.py-master\\FindWord.py";

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("python", fileName)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardInput = true
            };
            p.Start();
            p.StandardInput.WriteLine(textBoxWord.Text);
            string[] output = p?.StandardOutput.ReadLine()?.Split(' ');
            p.WaitForExit();
            if (output != null)
            {
                lemma = output[0];
                tags = output[1].Split(',');
                TranslateTags(tags);
            }
            else MessageBox.Show("Слово не найдено");
        }

        private void WriteDictionary()
        {
            StreamReader sr = new StreamReader("tags.txt");
            string[] lines = sr.ReadToEnd().Split('\n');
            foreach (var line in lines)
            {
                string[] inf = line.Split('—');
                string tag = inf[0].Trim();
                string description = inf[1].Trim();

                tagsDictionary[tag] = description;
            }
        }

        private void TranslateTags(string[] tags)
        {
            for (int i = 0; i < tags.Length; i++)
            {

                if (tagsDictionary.TryGetValue(tags[i], out string tag))
                    tags[i] = tag;
                else tags[i] = "Неопознаный тэг";
            }
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void textBoxWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Run_Cmd();
                AddInf(lemma,tags);
            }
        }
        public Label CreateLine(string text,int mod)
        {
            Label newL = new Label();
            newL.Font = new Font("Gabriola", 12);
            newL.Text = text;
            newL.Location = new Point(1, 50 + 20 * mod);
            newL.BackColor = Color.SkyBlue;
            newL.Size = new System.Drawing.Size(199, 20);
            Controls.Add(newL);
            return newL;
        }
        public void AddInf(string lemma, string[] tags)
        {
            if (lemma != null && tags != null)
            {
                int tagsCount = tags.Length;
                Label[] stickerLines = new Label[tagsCount + 2];// + lemma
                stickerLines[0] = CreateLine($"Лемма: {lemma}", 0);
                stickerLines[1] = CreateLine("Тэги:", 1);
                for (int i = 0; i < tagsCount; i++)
                {
                    stickerLines[i + 2] = CreateLine($"-{tags[i]}", i + 2);
                }
            }
        }

        private void pictureBoxPinClip_Click(object sender, EventArgs e)
        {
            if (PinClip)
            {
                pictureBoxPinClip.Image = Resources.PinClipBlack;
                PinClip = !PinClip;
                this.TopMost = false;
            }
            else
            {
                pictureBoxPinClip.Image = Resources.PinClipColor;
                PinClip = !PinClip;
                this.TopMost = true;
            }
        }
        public string[] CheckModules() // bs4 requests lxml tqdm
        {
            //Process p = new Process();
            //p.StartInfo = new ProcessStartInfo("cmd", "pip list")
            //{
            //    RedirectStandardOutput = true,
            //    UseShellExecute = false,
            //    CreateNoWindow = true,
            //    RedirectStandardInput = true
            //};
            //p.Start();
            //string a = p.StandardOutput.ReadToEnd();
            //p.WaitForExit();
            return null;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
