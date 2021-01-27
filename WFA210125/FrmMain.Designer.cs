
namespace WFA210125
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTurazok = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRef = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUj = new System.Windows.Forms.Button();
            this.pbPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurazok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Természetjárók nyilvántartása";
            // 
            // dgvTurazok
            // 
            this.dgvTurazok.AllowUserToAddRows = false;
            this.dgvTurazok.AllowUserToDeleteRows = false;
            this.dgvTurazok.AllowUserToResizeColumns = false;
            this.dgvTurazok.AllowUserToResizeRows = false;
            this.dgvTurazok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurazok.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTurazok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTurazok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurazok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvTurazok.Location = new System.Drawing.Point(12, 219);
            this.dgvTurazok.Name = "dgvTurazok";
            this.dgvTurazok.RowHeadersVisible = false;
            this.dgvTurazok.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dgvTurazok.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTurazok.RowTemplate.Height = 24;
            this.dgvTurazok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurazok.Size = new System.Drawing.Size(911, 207);
            this.dgvTurazok.TabIndex = 1;
            this.dgvTurazok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTurazok_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Név";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Város";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefon";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // btnRef
            // 
            this.btnRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRef.Location = new System.Drawing.Point(487, 432);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(436, 65);
            this.btnRef.TabIndex = 2;
            this.btnRef.Text = "Frissítés";
            this.btnRef.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(25, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "nyilvántartásban szereplő túrázók:";
            // 
            // btnUj
            // 
            this.btnUj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUj.Location = new System.Drawing.Point(12, 432);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(436, 65);
            this.btnUj.TabIndex = 2;
            this.btnUj.Text = "Új személy";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.BtnUj_Click);
            // 
            // pbPic
            // 
            this.pbPic.Image = global::WFA210125.Properties.Resources.rndPic;
            this.pbPic.Location = new System.Drawing.Point(746, 12);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(177, 201);
            this.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPic.TabIndex = 3;
            this.pbPic.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 509);
            this.Controls.Add(this.pbPic);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.dgvTurazok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Túrázók";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurazok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTurazok;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.PictureBox pbPic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

