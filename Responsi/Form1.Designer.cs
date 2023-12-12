namespace Responsi
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
            components = new System.ComponentModel.Container();
            lblNama = new Label();
            lblDept = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtNama = new TextBox();
            txtDep = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label3 = new Label();
            dgvData = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(84, 85);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(93, 15);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama Karyawan";
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Location = new Point(84, 133);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(85, 15);
            lblDept.TabIndex = 1;
            lblDept.Text = "Dep. Karyawan";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtNama
            // 
            txtNama.Location = new Point(200, 82);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(160, 23);
            txtNama.TabIndex = 3;
            // 
            // txtDep
            // 
            txtDep.Location = new Point(200, 130);
            txtDep.Name = "txtDep";
            txtDep.Size = new Size(160, 23);
            txtDep.TabIndex = 4;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(84, 177);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(363, 177);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Edit";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(644, 177);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(617, 30);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 8;
            label3.Text = "ID Departemen:";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(84, 215);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(635, 186);
            dgvData.TabIndex = 9;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(617, 55);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 10;
            label1.Text = "HR : HR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(617, 70);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 11;
            label2.Text = "ENG : Engineer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(617, 115);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 12;
            label4.Text = "FIN : Finance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(617, 100);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 13;
            label5.Text = "PM : Product M";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(617, 85);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 14;
            label6.Text = "DEV : Developer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 30);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 15;
            label7.Text = "logo";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(644, 415);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 16;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoaddata_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvData);
            Controls.Add(label3);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtDep);
            Controls.Add(txtNama);
            Controls.Add(lblDept);
            Controls.Add(lblNama);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNama;
        private Label lblDept;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtNama;
        private TextBox txtDep;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label3;
        private DataGridView dgvData;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnLoad;
    }
}