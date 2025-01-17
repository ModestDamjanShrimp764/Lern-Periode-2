namespace Taschenrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnmal = new System.Windows.Forms.Button();
            this.btngeteilt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(367, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(247, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 3;
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(504, 75);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(95, 69);
            this.btnplus.TabIndex = 4;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(673, 75);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(99, 69);
            this.btnminus.TabIndex = 5;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnmal
            // 
            this.btnmal.Location = new System.Drawing.Point(504, 202);
            this.btnmal.Name = "btnmal";
            this.btnmal.Size = new System.Drawing.Size(95, 81);
            this.btnmal.TabIndex = 6;
            this.btnmal.Text = "*";
            this.btnmal.UseVisualStyleBackColor = true;
            this.btnmal.Click += new System.EventHandler(this.button3_Click);
            // 
            // btngeteilt
            // 
            this.btngeteilt.Location = new System.Drawing.Point(673, 202);
            this.btngeteilt.Name = "btngeteilt";
            this.btngeteilt.Size = new System.Drawing.Size(99, 81);
            this.btngeteilt.TabIndex = 7;
            this.btngeteilt.Text = "button4";
            this.btngeteilt.UseVisualStyleBackColor = true;
            this.btngeteilt.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btngeteilt);
            this.Controls.Add(this.btnmal);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnmal;
        private System.Windows.Forms.Button btngeteilt;
    }
}

