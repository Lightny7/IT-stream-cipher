namespace Lab2
{
    partial class MainForm
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
            this.tbIn = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnCipher = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbGenKey = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbIn
            // 
            this.tbIn.Location = new System.Drawing.Point(12, 12);
            this.tbIn.Name = "tbIn";
            this.tbIn.ReadOnly = true;
            this.tbIn.Size = new System.Drawing.Size(600, 22);
            this.tbIn.TabIndex = 0;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(62, 40);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(550, 22);
            this.tbKey.TabIndex = 1;
            // 
            // tbOut
            // 
            this.tbOut.Location = new System.Drawing.Point(12, 96);
            this.tbOut.Name = "tbOut";
            this.tbOut.ReadOnly = true;
            this.tbOut.Size = new System.Drawing.Size(600, 22);
            this.tbOut.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(618, 11);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(170, 30);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Выбрать ввод";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnCipher
            // 
            this.btnCipher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCipher.Location = new System.Drawing.Point(618, 88);
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.Size = new System.Drawing.Size(170, 30);
            this.btnCipher.TabIndex = 4;
            this.btnCipher.Text = "Шифровать";
            this.btnCipher.UseVisualStyleBackColor = true;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(618, 49);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Выбрать вывод";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbGenKey
            // 
            this.tbGenKey.Location = new System.Drawing.Point(12, 68);
            this.tbGenKey.Name = "tbGenKey";
            this.tbGenKey.ReadOnly = true;
            this.tbGenKey.Size = new System.Drawing.Size(600, 22);
            this.tbGenKey.TabIndex = 6;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Title = "Открыть...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ключ:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 132);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGenKey);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCipher);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.tbOut);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tbIn);
            this.Name = "MainForm";
            this.Text = "Stream cipher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIn;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TextBox tbOut;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnCipher;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbGenKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label1;
    }
}

