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
            grbCau1 = new GroupBox();
            cbbLuaChon = new ComboBox();
            txtThongdiep = new TextBox();
            lbLuaChon = new Label();
            lbThongDiep = new Label();
            btnLoad = new Button();
            btnThongBao = new Button();
            grbCau2 = new GroupBox();
            txtCau2 = new TextBox();
            btnGhi = new Button();
            btndoc = new Button();
            grbCau1.SuspendLayout();
            grbCau2.SuspendLayout();
            SuspendLayout();
            // 
            // grbCau1
            // 
            grbCau1.Controls.Add(cbbLuaChon);
            grbCau1.Controls.Add(txtThongdiep);
            grbCau1.Controls.Add(lbLuaChon);
            grbCau1.Controls.Add(lbThongDiep);
            grbCau1.Controls.Add(btnLoad);
            grbCau1.Controls.Add(btnThongBao);
            grbCau1.Location = new Point(12, 12);
            grbCau1.Name = "grbCau1";
            grbCau1.Size = new Size(294, 217);
            grbCau1.TabIndex = 0;
            grbCau1.TabStop = false;
            grbCau1.Text = "Câu 1";
            // 
            // cbbLuaChon
            // 
            cbbLuaChon.FormattingEnabled = true;
            cbbLuaChon.Location = new Point(23, 158);
            cbbLuaChon.Name = "cbbLuaChon";
            cbbLuaChon.Size = new Size(222, 28);
            cbbLuaChon.TabIndex = 5;
            // 
            // txtThongdiep
            // 
            txtThongdiep.Location = new Point(16, 92);
            txtThongdiep.Name = "txtThongdiep";
            txtThongdiep.Size = new Size(229, 27);
            txtThongdiep.TabIndex = 4;
            // 
            // lbLuaChon
            // 
            lbLuaChon.AutoSize = true;
            lbLuaChon.Location = new Point(16, 135);
            lbLuaChon.Name = "lbLuaChon";
            lbLuaChon.Size = new Size(70, 20);
            lbLuaChon.TabIndex = 3;
            lbLuaChon.Text = "Lua Chon";
            // 
            // lbThongDiep
            // 
            lbThongDiep.AutoSize = true;
            lbThongDiep.Location = new Point(16, 69);
            lbThongDiep.Name = "lbThongDiep";
            lbThongDiep.Size = new Size(87, 20);
            lbThongDiep.TabIndex = 2;
            lbThongDiep.Text = "Thong Diep";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(182, 34);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnThongBao
            // 
            btnThongBao.Location = new Point(8, 34);
            btnThongBao.Name = "btnThongBao";
            btnThongBao.Size = new Size(94, 29);
            btnThongBao.TabIndex = 0;
            btnThongBao.Text = "Thong Bao";
            btnThongBao.UseVisualStyleBackColor = true;
            btnThongBao.Click += btnThongBao_Click;
            // 
            // grbCau2
            // 
            grbCau2.Controls.Add(txtCau2);
            grbCau2.Controls.Add(btnGhi);
            grbCau2.Controls.Add(btndoc);
            grbCau2.Location = new Point(12, 232);
            grbCau2.Name = "grbCau2";
            grbCau2.Size = new Size(294, 217);
            grbCau2.TabIndex = 6;
            grbCau2.TabStop = false;
            grbCau2.Text = "Câu 2";
            // 
            // txtCau2
            // 
            txtCau2.Location = new Point(16, 83);
            txtCau2.Multiline = true;
            txtCau2.Name = "txtCau2";
            txtCau2.Size = new Size(246, 128);
            txtCau2.TabIndex = 4;
            // 
            // btnGhi
            // 
            btnGhi.Location = new Point(182, 34);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(94, 29);
            btnGhi.TabIndex = 1;
            btnGhi.Text = "Ghi";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // btndoc
            // 
            btndoc.Location = new Point(8, 34);
            btndoc.Name = "btndoc";
            btndoc.Size = new Size(94, 29);
            btndoc.TabIndex = 0;
            btndoc.Text = "Doc";
            btndoc.UseVisualStyleBackColor = true;
            btndoc.Click += btndoc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(grbCau2);
            Controls.Add(grbCau1);
            Name = "Form1";
            Text = "Form1";
            grbCau1.ResumeLayout(false);
            grbCau1.PerformLayout();
            grbCau2.ResumeLayout(false);
            grbCau2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbCau1;
        private ComboBox cbbLuaChon;
        private TextBox txtThongdiep;
        private Label lbLuaChon;
        private Label lbThongDiep;
        private Button btnLoad;
        private Button btnThongBao;
        private GroupBox grbCau2;
        private TextBox txtCau2;
        private Button btnGhi;
        private Button btndoc;
    }
}
