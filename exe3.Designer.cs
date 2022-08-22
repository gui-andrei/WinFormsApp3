namespace WinFormsApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cdgtxt = new System.Windows.Forms.TextBox();
            this.nometxt = new System.Windows.Forms.TextBox();
            this.rgTxt = new System.Windows.Forms.TextBox();
            this.salariotxt = new System.Windows.Forms.TextBox();
            this.registrostxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cleartxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salario";
            // 
            // cdgtxt
            // 
            this.cdgtxt.Location = new System.Drawing.Point(33, 43);
            this.cdgtxt.Name = "cdgtxt";
            this.cdgtxt.Size = new System.Drawing.Size(100, 23);
            this.cdgtxt.TabIndex = 4;
            // 
            // nometxt
            // 
            this.nometxt.Location = new System.Drawing.Point(33, 100);
            this.nometxt.Name = "nometxt";
            this.nometxt.Size = new System.Drawing.Size(100, 23);
            this.nometxt.TabIndex = 5;
            // 
            // rgTxt
            // 
            this.rgTxt.Location = new System.Drawing.Point(33, 173);
            this.rgTxt.Name = "rgTxt";
            this.rgTxt.Size = new System.Drawing.Size(100, 23);
            this.rgTxt.TabIndex = 6;
            // 
            // salariotxt
            // 
            this.salariotxt.Location = new System.Drawing.Point(33, 240);
            this.salariotxt.Name = "salariotxt";
            this.salariotxt.Size = new System.Drawing.Size(100, 23);
            this.salariotxt.TabIndex = 7;
            // 
            // registrostxt
            // 
            this.registrostxt.Location = new System.Drawing.Point(367, 43);
            this.registrostxt.Multiline = true;
            this.registrostxt.Name = "registrostxt";
            this.registrostxt.Size = new System.Drawing.Size(303, 334);
            this.registrostxt.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Registros";
            // 
            // cleartxt
            // 
            this.cleartxt.Location = new System.Drawing.Point(204, 173);
            this.cleartxt.Name = "cleartxt";
            this.cleartxt.Size = new System.Drawing.Size(75, 23);
            this.cleartxt.TabIndex = 11;
            this.cleartxt.Text = "limpar";
            this.cleartxt.UseVisualStyleBackColor = true;
            this.cleartxt.Click += new System.EventHandler(this.cleartxt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cleartxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.registrostxt);
            this.Controls.Add(this.salariotxt);
            this.Controls.Add(this.rgTxt);
            this.Controls.Add(this.nometxt);
            this.Controls.Add(this.cdgtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox cdgtxt;
        private TextBox nometxt;
        private TextBox rgTxt;
        private TextBox salariotxt;
        private TextBox registrostxt;
        private Button button1;
        private Label label5;
        private Button cleartxt;
    }
}