namespace WinForms_Vsoft
{
    partial class FrmSelectEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectEmail));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnSave = new DevExpress.XtraBars.BarButtonItem();
            btnAdd = new DevExpress.XtraBars.BarButtonItem();
            btnDelete = new DevExpress.XtraBars.BarButtonItem();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            flpSelectEmail = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, btnSave, btnAdd, btnDelete, btnClose });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 5;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new Size(1057, 231);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // btnSave
            // 
            btnSave.Caption = "Lấy dữ liệu và đóng";
            btnSave.Id = 1;
            btnSave.ImageOptions.Image = (Image)resources.GetObject("btnSave.ImageOptions.Image");
            btnSave.ImageOptions.LargeImage = (Image)resources.GetObject("btnSave.ImageOptions.LargeImage");
            btnSave.Name = "btnSave";
            btnSave.ItemClick += btnSave_ItemClick;
            // 
            // btnAdd
            // 
            btnAdd.Caption = "Thêm 1 trường";
            btnAdd.Id = 2;
            btnAdd.ImageOptions.Image = (Image)resources.GetObject("btnAdd.ImageOptions.Image");
            btnAdd.ImageOptions.LargeImage = (Image)resources.GetObject("btnAdd.ImageOptions.LargeImage");
            btnAdd.Name = "btnAdd";
            btnAdd.ItemClick += btnAdd_ItemClick;
            // 
            // btnDelete
            // 
            btnDelete.Caption = "Xóa 1 trường đã chọn";
            btnDelete.Id = 3;
            btnDelete.ImageOptions.Image = (Image)resources.GetObject("btnDelete.ImageOptions.Image");
            btnDelete.ImageOptions.LargeImage = (Image)resources.GetObject("btnDelete.ImageOptions.LargeImage");
            btnDelete.Name = "btnDelete";
            btnDelete.ItemClick += btnDelete_ItemClick;
            // 
            // btnClose
            // 
            btnClose.Caption = "Đóng";
            btnClose.Id = 4;
            btnClose.ImageOptions.Image = (Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.ImageOptions.LargeImage = (Image)resources.GetObject("btnClose.ImageOptions.LargeImage");
            btnClose.Name = "btnClose";
            btnClose.ItemClick += btnClose_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Thao tác";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btnSave);
            ribbonPageGroup1.ItemLinks.Add(btnAdd);
            ribbonPageGroup1.ItemLinks.Add(btnDelete);
            ribbonPageGroup1.ItemLinks.Add(btnClose);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Thao tác";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 705);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1057, 36);
            // 
            // flpSelectEmail
            // 
            flpSelectEmail.Location = new Point(12, 237);
            flpSelectEmail.Name = "flpSelectEmail";
            flpSelectEmail.Size = new Size(1034, 462);
            flpSelectEmail.TabIndex = 2;
            // 
            // FrmSelectEmail
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 741);
            Controls.Add(flpSelectEmail);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "FrmSelectEmail";
            Ribbon = ribbon;
            StartPosition = FormStartPosition.CenterScreen;
            StatusBar = ribbonStatusBar;
            Text = "FrmSelectEmail";
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private FlowLayoutPanel flpSelectEmail;
    }
}