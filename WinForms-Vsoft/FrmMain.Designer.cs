namespace WinForms_Vsoft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnAdd = new DevExpress.XtraBars.BarButtonItem();
            btnLoad = new DevExpress.XtraBars.BarButtonItem();
            btnDelete = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            grdCtrDocumentWatchers = new DevExpress.XtraGrid.GridControl();
            grdViewDocumentWatchers = new DevExpress.XtraGrid.Views.Grid.GridView();
            grdId = new DevExpress.XtraGrid.Columns.GridColumn();
            grdDocumentId = new DevExpress.XtraGrid.Columns.GridColumn();
            grdUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            grdDocumentSummary = new DevExpress.XtraGrid.Columns.GridColumn();
            grdEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            grdExpiredIn = new DevExpress.XtraGrid.Columns.GridColumn();
            grdSecurityLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            grdStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            grdIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            grdCreatedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            grdCheckSum = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdCtrDocumentWatchers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdViewDocumentWatchers).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, btnAdd, btnLoad, btnDelete });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 4;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new Size(1596, 231);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // btnAdd
            // 
            btnAdd.Caption = "Thêm mới";
            btnAdd.Id = 1;
            btnAdd.ImageOptions.Image = (Image)resources.GetObject("btnAdd.ImageOptions.Image");
            btnAdd.ImageOptions.LargeImage = (Image)resources.GetObject("btnAdd.ImageOptions.LargeImage");
            btnAdd.Name = "btnAdd";
            btnAdd.ItemClick += btnAdd_ItemClick;
            // 
            // btnLoad
            // 
            btnLoad.Caption = "Nạp lại";
            btnLoad.Id = 2;
            btnLoad.ImageOptions.Image = (Image)resources.GetObject("btnLoad.ImageOptions.Image");
            btnLoad.ImageOptions.LargeImage = (Image)resources.GetObject("btnLoad.ImageOptions.LargeImage");
            btnLoad.Name = "btnLoad";
            btnLoad.ItemClick += btnLoad_ItemClick;
            // 
            // btnDelete
            // 
            btnDelete.Caption = "Xóa dòng";
            btnDelete.Id = 3;
            btnDelete.ImageOptions.Image = (Image)resources.GetObject("btnDelete.ImageOptions.Image");
            btnDelete.ImageOptions.LargeImage = (Image)resources.GetObject("btnDelete.ImageOptions.LargeImage");
            btnDelete.Name = "btnDelete";
            btnDelete.ItemClick += btnDelete_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Quản trị";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btnAdd);
            ribbonPageGroup1.ItemLinks.Add(btnLoad);
            ribbonPageGroup1.ItemLinks.Add(btnDelete);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Thao tác";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 814);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1596, 36);
            // 
            // grdCtrDocumentWatchers
            // 
            grdCtrDocumentWatchers.Location = new Point(0, 229);
            grdCtrDocumentWatchers.MainView = grdViewDocumentWatchers;
            grdCtrDocumentWatchers.MenuManager = ribbon;
            grdCtrDocumentWatchers.Name = "grdCtrDocumentWatchers";
            grdCtrDocumentWatchers.Size = new Size(1596, 621);
            grdCtrDocumentWatchers.TabIndex = 2;
            grdCtrDocumentWatchers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grdViewDocumentWatchers });
            // 
            // grdViewDocumentWatchers
            // 
            grdViewDocumentWatchers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { grdId, grdDocumentId, grdUserId, grdDocumentSummary, grdEmail, grdExpiredIn, grdSecurityLevel, grdStatus, grdIsActive, grdCreatedOn, grdCheckSum });
            grdViewDocumentWatchers.GridControl = grdCtrDocumentWatchers;
            grdViewDocumentWatchers.GroupCount = 1;
            grdViewDocumentWatchers.Name = "grdViewDocumentWatchers";
            grdViewDocumentWatchers.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            grdViewDocumentWatchers.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(grdDocumentSummary, DevExpress.Data.ColumnSortOrder.Ascending) });
            // 
            // grdId
            // 
            grdId.Caption = "Id";
            grdId.FieldName = "Id";
            grdId.MinWidth = 30;
            grdId.Name = "grdId";
            grdId.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            grdId.Width = 124;
            // 
            // grdDocumentId
            // 
            grdDocumentId.Caption = "Id Tài liệu";
            grdDocumentId.FieldName = "DocumentId";
            grdDocumentId.MinWidth = 30;
            grdDocumentId.Name = "grdDocumentId";
            grdDocumentId.OptionsColumn.AllowEdit = false;
            grdDocumentId.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            grdDocumentId.Visible = true;
            grdDocumentId.VisibleIndex = 0;
            grdDocumentId.Width = 211;
            // 
            // grdUserId
            // 
            grdUserId.Caption = "Id Người dùng";
            grdUserId.FieldName = "UserId";
            grdUserId.MinWidth = 30;
            grdUserId.Name = "grdUserId";
            grdUserId.OptionsColumn.AllowEdit = false;
            grdUserId.Width = 149;
            // 
            // grdDocumentSummary
            // 
            grdDocumentSummary.Caption = "Tài liệu";
            grdDocumentSummary.FieldName = "DocumentSummary";
            grdDocumentSummary.MinWidth = 30;
            grdDocumentSummary.Name = "grdDocumentSummary";
            grdDocumentSummary.OptionsColumn.AllowEdit = false;
            grdDocumentSummary.Visible = true;
            grdDocumentSummary.VisibleIndex = 1;
            grdDocumentSummary.Width = 125;
            // 
            // grdEmail
            // 
            grdEmail.Caption = "Email người được chia sẻ";
            grdEmail.FieldName = "Email";
            grdEmail.MinWidth = 30;
            grdEmail.Name = "grdEmail";
            grdEmail.OptionsColumn.AllowEdit = false;
            grdEmail.Visible = true;
            grdEmail.VisibleIndex = 1;
            grdEmail.Width = 185;
            // 
            // grdExpiredIn
            // 
            grdExpiredIn.Caption = "Ngày hết hạn";
            grdExpiredIn.FieldName = "ExpiredIn";
            grdExpiredIn.MinWidth = 30;
            grdExpiredIn.Name = "grdExpiredIn";
            grdExpiredIn.OptionsColumn.AllowEdit = false;
            grdExpiredIn.Visible = true;
            grdExpiredIn.VisibleIndex = 4;
            grdExpiredIn.Width = 104;
            // 
            // grdSecurityLevel
            // 
            grdSecurityLevel.Caption = "Cấp độ bảo mật";
            grdSecurityLevel.FieldName = "SecurityLevel";
            grdSecurityLevel.MinWidth = 30;
            grdSecurityLevel.Name = "grdSecurityLevel";
            grdSecurityLevel.OptionsColumn.AllowEdit = false;
            grdSecurityLevel.Visible = true;
            grdSecurityLevel.VisibleIndex = 2;
            grdSecurityLevel.Width = 125;
            // 
            // grdStatus
            // 
            grdStatus.Caption = "Trạng thái";
            grdStatus.FieldName = "StatusMessage";
            grdStatus.MinWidth = 30;
            grdStatus.Name = "grdStatus";
            grdStatus.OptionsColumn.AllowEdit = false;
            grdStatus.Visible = true;
            grdStatus.VisibleIndex = 3;
            grdStatus.Width = 113;
            // 
            // grdIsActive
            // 
            grdIsActive.Caption = "Kích hoạt";
            grdIsActive.FieldName = "IsActive";
            grdIsActive.MinWidth = 30;
            grdIsActive.Name = "grdIsActive";
            grdIsActive.OptionsColumn.AllowEdit = false;
            grdIsActive.Visible = true;
            grdIsActive.VisibleIndex = 5;
            grdIsActive.Width = 77;
            // 
            // grdCreatedOn
            // 
            grdCreatedOn.Caption = "Ngày tạo";
            grdCreatedOn.FieldName = "CreatedOn";
            grdCreatedOn.MinWidth = 30;
            grdCreatedOn.Name = "grdCreatedOn";
            grdCreatedOn.OptionsColumn.AllowEdit = false;
            grdCreatedOn.Visible = true;
            grdCreatedOn.VisibleIndex = 6;
            grdCreatedOn.Width = 76;
            // 
            // grdCheckSum
            // 
            grdCheckSum.Caption = "Mã hóa";
            grdCheckSum.FieldName = "CheckSum";
            grdCheckSum.MinWidth = 30;
            grdCheckSum.Name = "grdCheckSum";
            grdCheckSum.OptionsColumn.AllowEdit = false;
            grdCheckSum.Visible = true;
            grdCheckSum.VisibleIndex = 7;
            grdCheckSum.Width = 154;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1596, 850);
            Controls.Add(grdCtrDocumentWatchers);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "FrmMain";
            Ribbon = ribbon;
            StartPosition = FormStartPosition.CenterScreen;
            StatusBar = ribbonStatusBar;
            Text = "FrmMain";
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdCtrDocumentWatchers).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdViewDocumentWatchers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl grdCtrDocumentWatchers;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewDocumentWatchers;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnLoad;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn grdId;
        private DevExpress.XtraGrid.Columns.GridColumn grdDocumentId;
        private DevExpress.XtraGrid.Columns.GridColumn grdUserId;
        private DevExpress.XtraGrid.Columns.GridColumn grdEmail;
        private DevExpress.XtraGrid.Columns.GridColumn grdExpiredIn;
        private DevExpress.XtraGrid.Columns.GridColumn grdIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn grdCreatedOn;
        private DevExpress.XtraGrid.Columns.GridColumn grdCheckSum;
        private DevExpress.XtraGrid.Columns.GridColumn grdDocumentSummary;
        private DevExpress.XtraGrid.Columns.GridColumn grdSecurityLevel;
        private DevExpress.XtraGrid.Columns.GridColumn grdStatus;
    }
}