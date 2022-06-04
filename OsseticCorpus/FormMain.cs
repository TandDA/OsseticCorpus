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
        Label[] stickerLines;
        string[] tags;
        string lemma;
        bool PinClip = false;

        public FormMain()
        {
            InitializeComponent();
            WriteDictionary();
            CheckModules();
            stickerLines = new Label[]{ label1,label2, label3, label4, label5, label6, label7, label8, label9 };
        }
        private void RunPython()
        {
            if (string.IsNullOrEmpty(textBoxWord.Text))
            {
                MessageBox.Show("Ошибка: Пустое поле ввода");
                return;
            }

            string currPath = Directory.GetCurrentDirectory();
            string fileName = currPath + "\\lingcorpora.py-master\\FindWord.py";

            Process proc = new Process();
            proc.StartInfo = new ProcessStartInfo("python", fileName)
            {
                RedirectStandardOutput = true, // Перехватывает текстовые выходные данные от запущенного приложения
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardInput = true
            };
            proc.Start();
            proc.StandardInput.WriteLine(textBoxWord.Text);
            string[] output = proc.StandardOutput.ReadLine()?.Split(' ');
            proc.WaitForExit();
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
        private void textBoxWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RunPython();
                AddInf(lemma,tags);
            }
        }
        public void AddInf(string lemma, string[] tags)
        {
            if (lemma != null && tags != null)
            {
                int tagsCount = tags.Length;
                stickerLines[0].Text = $"Лемма: {lemma}";
                stickerLines[1].Text = $"Тэги:";
                for (int i = 2; i < stickerLines.Length; i++)
                {
                    stickerLines[i].Text = i < tagsCount+2 ? $"-{tags[i-2]}" : string.Empty;
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
        string RunCmd(string command)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("cmd", $"/c {command}")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardInput = true
            };
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            return output;
        }
        public void CheckModules() // bs4 requests lxml tqdm
        {
            bool bs4 = false, requests = false, lxml = false, tqdm = false, lingcorpora = false;
            string[] modules = RunCmd("pip list").Split('\r');
            foreach (var item in modules)
            {
                string[] module = item.Split(' ');
                switch(module[0])
                {
                    case "\\nbs4":
                        bs4 = true;
                        break;
                    case "\\nrequests":
                        requests = true;
                        break;
                    case "\\nlxml":
                        lxml = true;
                        break;
                    case "\\ntqdm":
                        tqdm = true;
                        break;
                    case "\\nlingcorpora":
                        lingcorpora = true;
                        break;
                }
            }
            if (!bs4)
                RunCmd("pip install bs4");
            if (!requests)
                RunCmd("pip install requests");
            if (!lxml)
                RunCmd("pip install lxml");
            if (!tqdm)
                RunCmd("pip install tqdm");
            if (!lingcorpora)
                RunCmd("pip install lingcorpora");

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
