
namespace WFA210125
{
    partial class FrmUjTurazo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbVez = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVaros = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.btnUj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vezetéknév:";
            // 
            // tbVez
            // 
            this.tbVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbVez.Location = new System.Drawing.Point(189, 39);
            this.tbVez.Name = "tbVez";
            this.tbVez.Size = new System.Drawing.Size(160, 30);
            this.tbVez.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(41, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Keresztnév:";
            // 
            // tbKer
            // 
            this.tbKer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKer.Location = new System.Drawing.Point(189, 104);
            this.tbKer.Name = "tbKer";
            this.tbKer.Size = new System.Drawing.Size(160, 30);
            this.tbKer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(88, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Város:";
            // 
            // tbVaros
            // 
            this.tbVaros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbVaros.Location = new System.Drawing.Point(189, 169);
            this.tbVaros.Name = "tbVaros";
            this.tbVaros.Size = new System.Drawing.Size(160, 30);
            this.tbVaros.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(27, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefonszám:";
            // 
            // tbTel
            // 
            this.tbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTel.Location = new System.Drawing.Point(189, 234);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(160, 30);
            this.tbTel.TabIndex = 1;
            // 
            // btnUj
            // 
            this.btnUj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUj.Location = new System.Drawing.Point(32, 324);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(317, 52);
            this.btnUj.TabIndex = 2;
            this.btnUj.Text = "Új túrázó rögzítése";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.BtnUj_Click);
            // 
            // UjTurazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 410);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbVaros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVez);
            this.Controls.Add(this.label1);
            this.Name = "UjTurazo";
            this.Text = "UjTurazo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVez;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVaros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Button btnUj;
    }
}