using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainForm : Form
    {
        byte[] input = new byte[8];
        byte[] output = new byte[8];
        byte[] genKey = new byte[8];
        int genKeySize;
        int count;
        UInt64 key;            
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream inFile = File.OpenRead(openFileDialog.FileName);
                count = inFile.Read(input, 0, 8);
                inFile.Close();
                tbIn.Text = Utils.ToByteString(input, count);
                btnOpen.BackColor = Color.LightGreen;
            }
        }

        private void btnCipher_Click(object sender, EventArgs e)
        {
            key = Utils.ToUInt64(tbKey.Text);
            if (key != UInt64.MaxValue)
            {
                if (openFileDialog.FileName == "") MessageBox.Show("Выберите файл ввода");
                else if (saveFileDialog.FileName == "") MessageBox.Show("Выберите файл вывода");
                else
                {
                    try
                    {
                        genKeySize = StreamCipher.Cipher(key, openFileDialog.FileName, saveFileDialog.FileName, genKey, output);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    tbGenKey.Text = Utils.ToByteString(genKey, genKeySize);
                    tbOut.Text = Utils.ToByteString(output, count);
                }
            }
            else MessageBox.Show("Ключ некорректен!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                btnSave.BackColor = Color.LightGreen;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
