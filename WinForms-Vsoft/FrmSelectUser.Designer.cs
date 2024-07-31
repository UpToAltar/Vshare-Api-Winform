namespace WinForms_Vsoft
{
    partial class FrmSelectUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectUser));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnSelect = new DevExpress.XtraBars.BarButtonItem();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            btnLoadData = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            grdCtrUser = new DevExpress.XtraGrid.GridControl();
            gridViewUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridId = new DevExpress.XtraGrid.Columns.GridColumn();
            grdEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            grdFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            grdIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdCtrUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewUser).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, btnSelect, btnClose, btnLoadData });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 5;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new Size(1322, 231);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // btnSelect
            // 
            btnSelect.Caption = "Chọn";
            btnSelect.Id = 1;
            btnSelect.ImageOptions.Image = (Image)resources.GetObject("btnSelect.ImageOptions.Image");
            btnSelect.ImageOptions.LargeImage = (Image)resources.GetObject("btnSelect.ImageOptions.LargeImage");
            btnSelect.Name = "btnSelect";
            btnSelect.ItemClick += btnSelect_ItemClick;
            // 
            // btnClose
            // 
            btnClose.Caption = "Đóng";
            btnClose.Id = 2;
            btnClose.ImageOptions.Image = (Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.ImageOptions.LargeImage = (Image)resources.GetObject("btnClose.ImageOptions.LargeImage");
            btnClose.Name = "btnClose";
            btnClose.ItemClick += btnClose_ItemClick;
            // 
            // btnLoadData
            // 
            btnLoadData.Caption = "Nạp lại";
            btnLoadData.Id = 3;
            btnLoadData.ImageOptions.Image = (Image)resources.GetObject("btnLoadData.ImageOptions.Image");
            btnLoadData.ImageOptions.LargeImage = (Image)resources.GetObject("btnLoadData.ImageOptions.LargeImage");
            btnLoadData.Name = "btnLoadData";
            btnLoadData.ItemClick += btnLoadData_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Thao tác";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btnSelect);
            ribbonPageGroup1.ItemLinks.Add(btnLoadData);
            ribbonPageGroup1.ItemLinks.Add(btnClose);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Lấy dữ liệu";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 730);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1322, 36);
            // 
            // grdCtrUser
            // 
            grdCtrUser.Location = new Point(0, 237);
            grdCtrUser.MainView = gridViewUser;
            grdCtrUser.MenuManager = ribbon;
            grdCtrUser.Name = "grdCtrUser";
            grdCtrUser.Size = new Size(1322, 487);
            grdCtrUser.TabIndex = 2;
            grdCtrUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewUser });
            // 
            // gridViewUser
            // 
            gridViewUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridId, grdEmail, grdFullName, grdIsActive });
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = grdIsActive;
            gridFormatRule1.Name = "IsActive";
            formatConditionRuleValue1.Appearance.BackColor = Color.FromArgb(255, 224, 192);
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = false;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridViewUser.FormatRules.Add(gridFormatRule1);
            gridViewUser.GridControl = grdCtrUser;
            gridViewUser.Name = "gridViewUser";
            // 
            // gridId
            // 
            gridId.Caption = "Id";
            gridId.FieldName = "Id";
            gridId.MinWidth = 30;
            gridId.Name = "gridId";
            gridId.OptionsColumn.AllowEdit = false;
            gridId.Width = 322;
            // 
            // grdEmail
            // 
            grdEmail.Caption = "Email";
            grdEmail.FieldName = "Email";
            grdEmail.MinWidth = 30;
            grdEmail.Name = "grdEmail";
            grdEmail.OptionsColumn.AllowEdit = false;
            grdEmail.Visible = true;
            grdEmail.VisibleIndex = 0;
            grdEmail.Width = 298;
            // 
            // grdFullName
            // 
            grdFullName.Caption = "Tên đầy đủ";
            grdFullName.FieldName = "FullName";
            grdFullName.MinWidth = 30;
            grdFullName.Name = "grdFullName";
            grdFullName.OptionsColumn.AllowEdit = false;
            grdFullName.Visible = true;
            grdFullName.VisibleIndex = 1;
            grdFullName.Width = 260;
            // 
            // grdIsActive
            // 
            grdIsActive.Caption = "Kích hoạt";
            grdIsActive.FieldName = "IsActive";
            grdIsActive.MinWidth = 30;
            grdIsActive.Name = "grdIsActive";
            grdIsActive.OptionsColumn.AllowEdit = false;
            grdIsActive.Visible = true;
            grdIsActive.VisibleIndex = 2;
            grdIsActive.Width = 165;
            // 
            // FrmSelectUser
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 766);
            Controls.Add(grdCtrUser);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "FrmSelectUser";
            Ribbon = ribbon;
            StartPosition = FormStartPosition.CenterScreen;
            StatusBar = ribbonStatusBar;
            Text = "FrmSelectUser";
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdCtrUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnSelect;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraGrid.GridControl grdCtrUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUser;
        private DevExpress.XtraGrid.Columns.GridColumn gridId;
        private DevExpress.XtraGrid.Columns.GridColumn grdEmail;
        private DevExpress.XtraGrid.Columns.GridColumn grdFullName;
        private DevExpress.XtraGrid.Columns.GridColumn grdIsActive;
        private DevExpress.XtraBars.BarButtonItem btnLoadData;
    }
}