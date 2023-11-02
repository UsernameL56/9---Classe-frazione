namespace _9___Classe_frazione
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
            listView1 = new ListView();
            semplifica = new Button();
            somma = new Button();
            sottrazione = new Button();
            moltiplicazione = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.Location = new Point(402, 36);
            listView1.Name = "listView1";
            listView1.Size = new Size(494, 133);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // semplifica
            // 
            semplifica.Location = new Point(402, 222);
            semplifica.Name = "semplifica";
            semplifica.Size = new Size(94, 36);
            semplifica.TabIndex = 1;
            semplifica.Text = "Semplifica";
            semplifica.UseVisualStyleBackColor = true;
            semplifica.Click += semplifica_Click;
            // 
            // somma
            // 
            somma.Location = new Point(502, 222);
            somma.Name = "somma";
            somma.Size = new Size(94, 36);
            somma.TabIndex = 2;
            somma.Text = "Somma";
            somma.UseVisualStyleBackColor = true;
            somma.Click += somma_Click;
            // 
            // sottrazione
            // 
            sottrazione.Location = new Point(602, 222);
            sottrazione.Name = "sottrazione";
            sottrazione.Size = new Size(94, 36);
            sottrazione.TabIndex = 3;
            sottrazione.Text = "Sottrazione";
            sottrazione.UseVisualStyleBackColor = true;
            sottrazione.Click += sottrazione_Click;
            // 
            // moltiplicazione
            // 
            moltiplicazione.Location = new Point(702, 222);
            moltiplicazione.Name = "moltiplicazione";
            moltiplicazione.Size = new Size(104, 36);
            moltiplicazione.TabIndex = 4;
            moltiplicazione.Text = "Moltiplicazione";
            moltiplicazione.UseVisualStyleBackColor = true;
            moltiplicazione.Click += moltiplicazione_Click;
            // 
            // button5
            // 
            button5.Location = new Point(812, 222);
            button5.Name = "button5";
            button5.Size = new Size(94, 36);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 36);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 45);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(25, 99);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(90, 45);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(176, 36);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(90, 45);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(176, 99);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(90, 45);
            textBox4.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1561, 633);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(moltiplicazione);
            Controls.Add(sottrazione);
            Controls.Add(somma);
            Controls.Add(semplifica);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button semplifica;
        private Button somma;
        private Button sottrazione;
        private Button moltiplicazione;
        private Button button5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}