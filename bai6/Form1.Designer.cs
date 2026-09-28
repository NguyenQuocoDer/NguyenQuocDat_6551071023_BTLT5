namespace QuanLyGhiChu
{
    partial class FormChinh
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
            menuStrip1 = new MenuStrip();
            tệpToolStripMenuItem = new ToolStripMenuItem();
            mnuTepMoGhiChu = new ToolStripMenuItem();
            mnuTepSapXep = new ToolStripMenuItem();
            mnuTepThoat = new ToolStripMenuItem();
            cửaSổToolStripMenuItem = new ToolStripMenuItem();
            mnuCuaSoXepTang = new ToolStripMenuItem();
            mnuCuaSoXepNgang = new ToolStripMenuItem();
            mnuCuaSoXepDoc = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblSoGhiChu = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tệpToolStripMenuItem, cửaSổToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuTepMoGhiChu, mnuTepSapXep, mnuTepThoat });
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(48, 24);
            tệpToolStripMenuItem.Text = "Tệp";
            // 
            // mnuTepMoGhiChu
            // 
            mnuTepMoGhiChu.Name = "mnuTepMoGhiChu";
            mnuTepMoGhiChu.Size = new Size(196, 26);
            mnuTepMoGhiChu.Text = "Mở ghi chú mới";
            mnuTepMoGhiChu.Click += mnuTepMoGhiChu_Click;
            // 
            // mnuTepSapXep
            // 
            mnuTepSapXep.Name = "mnuTepSapXep";
            mnuTepSapXep.Size = new Size(196, 26);
            mnuTepSapXep.Text = "Sắp xếp cửa sổ";
            mnuTepSapXep.Click += mnuTepSapXep_Click;
            // 
            // mnuTepThoat
            // 
            mnuTepThoat.Name = "mnuTepThoat";
            mnuTepThoat.Size = new Size(196, 26);
            mnuTepThoat.Text = "Thoát";
            mnuTepThoat.Click += mnuTepThoat_Click;
            // 
            // cửaSổToolStripMenuItem
            // 
            cửaSổToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuCuaSoXepTang, mnuCuaSoXepNgang, mnuCuaSoXepDoc });
            cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            cửaSổToolStripMenuItem.Size = new Size(68, 24);
            cửaSổToolStripMenuItem.Text = "Cửa sổ";
            // 
            // mnuCuaSoXepTang
            // 
            mnuCuaSoXepTang.Name = "mnuCuaSoXepTang";
            mnuCuaSoXepTang.Size = new Size(164, 26);
            mnuCuaSoXepTang.Text = "Xếp tầng ";
            mnuCuaSoXepTang.Click += mnuCuaSoXepTang_Click;
            // 
            // mnuCuaSoXepNgang
            // 
            mnuCuaSoXepNgang.Name = "mnuCuaSoXepNgang";
            mnuCuaSoXepNgang.Size = new Size(164, 26);
            mnuCuaSoXepNgang.Text = "Xếp ngang";
            mnuCuaSoXepNgang.Click += mnuCuaSoXepNgang_Click;
            // 
            // mnuCuaSoXepDoc
            // 
            mnuCuaSoXepDoc.Name = "mnuCuaSoXepDoc";
            mnuCuaSoXepDoc.Size = new Size(164, 26);
            mnuCuaSoXepDoc.Text = "Xếp dọc";
            mnuCuaSoXepDoc.Click += mnuCuaSoXepDoc_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblSoGhiChu });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // lblSoGhiChu
            // 
            lblSoGhiChu.Name = "lblSoGhiChu";
            lblSoGhiChu.Size = new Size(122, 20);
            lblSoGhiChu.Text = "Ghi chú đang mở";
            // 
            // FormChinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormChinh";
            Text = "FormChinh";
            MdiChildActivate += FormMain_MdiChildActivate;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tệpToolStripMenuItem;
        private ToolStripMenuItem mnuTepMoGhiChu;
        private ToolStripMenuItem mnuTepSapXep;
        private ToolStripMenuItem mnuTepThoat;
        private ToolStripMenuItem cửaSổToolStripMenuItem;
        private ToolStripMenuItem mnuCuaSoXepTang;
        private ToolStripMenuItem mnuCuaSoXepNgang;
        private ToolStripMenuItem mnuCuaSoXepDoc;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblSoGhiChu;
    }
}
