namespace WinForms_Vsoft
{
    partial class FrmSelectDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectDocument));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue4 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule5 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue5 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule6 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue6 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            grdStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnSelect = new DevExpress.XtraBars.BarButtonItem();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            btnLoadData = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            grdCtrDocument = new DevExpress.XtraGrid.GridControl();
            grdViewDocument = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridId = new DevExpress.XtraGrid.Columns.GridColumn();
            grdDocumentSummary = new DevExpress.XtraGrid.Columns.GridColumn();
            grdFKey = new DevExpress.XtraGrid.Columns.GridColumn();
            grdCode = new DevExpress.XtraGrid.Columns.GridColumn();
            grdIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            grdSecurityLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            grdStatusMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdCtrDocument).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdViewDocument).BeginInit();
            SuspendLayout();
            // 
            // grdStatus
            // 
            grdStatus.Caption = "Trạng thái";
            grdStatus.FieldName = "Status";
            grdStatus.MinWidth = 30;
            grdStatus.Name = "grdStatus";
            grdStatus.Width = 112;
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, btnSelect, btnClose, btnLoadData });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 4;
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
            ribbonStatusBar.Location = new Point(0, 826);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1322, 36);
            // 
            // grdCtrDocument
            // 
            grdCtrDocument.Location = new Point(0, 237);
            grdCtrDocument.MainView = grdViewDocument;
            grdCtrDocument.MenuManager = ribbon;
            grdCtrDocument.Name = "grdCtrDocument";
            grdCtrDocument.Size = new Size(1322, 591);
            grdCtrDocument.TabIndex = 2;
            grdCtrDocument.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grdViewDocument });
            // 
            // grdViewDocument
            // 
            grdViewDocument.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridId, grdDocumentSummary, grdFKey, grdCode, grdIsActive, grdSecurityLevel, grdStatusMessage, grdStatus });
            gridFormatRule4.ApplyToRow = true;
            gridFormatRule4.Column = grdStatus;
            gridFormatRule4.Name = "Status0";
            formatConditionRuleValue4.Appearance.BackColor = Color.FromArgb(255, 224, 192);
            formatConditionRuleValue4.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue4.Value1 = (short)0;
            gridFormatRule4.Rule = formatConditionRuleValue4;
            gridFormatRule5.ApplyToRow = true;
            gridFormatRule5.Column = grdStatus;
            gridFormatRule5.Name = "Status2";
            formatConditionRuleValue5.Appearance.BackColor = Color.FromArgb(255, 224, 192);
            formatConditionRuleValue5.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue5.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue5.Value1 = (short)2;
            gridFormatRule5.Rule = formatConditionRuleValue5;
            gridFormatRule6.ApplyToRow = true;
            gridFormatRule6.Column = grdStatus;
            gridFormatRule6.Name = "Status4";
            formatConditionRuleValue6.Appearance.BackColor = Color.FromArgb(255, 224, 192);
            formatConditionRuleValue6.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue6.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue6.Value1 = (short)4;
            gridFormatRule6.Rule = formatConditionRuleValue6;
            grdViewDocument.FormatRules.Add(gridFormatRule4);
            grdViewDocument.FormatRules.Add(gridFormatRule5);
            grdViewDocument.FormatRules.Add(gridFormatRule6);
            grdViewDocument.GridControl = grdCtrDocument;
            grdViewDocument.Name = "grdViewDocument";
            // 
            // gridId
            // 
            gridId.Caption = "Id";
            gridId.FieldName = "Id";
            gridId.MinWidth = 30;
            gridId.Name = "gridId";
            gridId.OptionsColumn.AllowEdit = false;
            gridId.Width = 220;
            // 
            // grdDocumentSummary
            // 
            grdDocumentSummary.Caption = "Tóm tắt tài liệu";
            grdDocumentSummary.FieldName = "DocumentSummary";
            grdDocumentSummary.MinWidth = 30;
            grdDocumentSummary.Name = "grdDocumentSummary";
            grdDocumentSummary.OptionsColumn.AllowEdit = false;
            grdDocumentSummary.Visible = true;
            grdDocumentSummary.VisibleIndex = 1;
            grdDocumentSummary.Width = 202;
            // 
            // grdFKey
            // 
            grdFKey.Caption = "FKey";
            grdFKey.FieldName = "FKey";
            grdFKey.MinWidth = 30;
            grdFKey.Name = "grdFKey";
            grdFKey.OptionsColumn.AllowEdit = false;
            grdFKey.Width = 183;
            // 
            // grdCode
            // 
            grdCode.Caption = "Code";
            grdCode.FieldName = "Code";
            grdCode.MinWidth = 30;
            grdCode.Name = "grdCode";
            grdCode.OptionsColumn.AllowEdit = false;
            grdCode.Visible = true;
            grdCode.VisibleIndex = 0;
            grdCode.Width = 118;
            // 
            // grdIsActive
            // 
            grdIsActive.Caption = "Kích hoạt";
            grdIsActive.FieldName = "IsActive";
            grdIsActive.MinWidth = 30;
            grdIsActive.Name = "grdIsActive";
            grdIsActive.OptionsColumn.AllowEdit = false;
            grdIsActive.Visible = true;
            grdIsActive.VisibleIndex = 4;
            grdIsActive.Width = 95;
            // 
            // grdSecurityLevel
            // 
            grdSecurityLevel.Caption = "Cấp độ bảo mật";
            grdSecurityLevel.FieldName = "SecurityLevel";
            grdSecurityLevel.MinWidth = 30;
            grdSecurityLevel.Name = "grdSecurityLevel";
            grdSecurityLevel.OptionsColumn.AllowEdit = false;
            grdSecurityLevel.Visible = true;
            grdSecurityLevel.VisibleIndex = 3;
            grdSecurityLevel.Width = 106;
            // 
            // grdStatusMessage
            // 
            grdStatusMessage.Caption = "Trạng thái";
            grdStatusMessage.FieldName = "StatusMessage";
            grdStatusMessage.MinWidth = 30;
            grdStatusMessage.Name = "grdStatusMessage";
            grdStatusMessage.OptionsColumn.AllowEdit = false;
            grdStatusMessage.Visible = true;
            grdStatusMessage.VisibleIndex = 2;
            grdStatusMessage.Width = 121;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(128, 254);
            label1.Name = "label1";
            label1.Size = new Size(0, 34);
            label1.TabIndex = 5;
            // 
            // FrmSelectDocument
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 862);
            Controls.Add(label1);
            Controls.Add(grdCtrDocument);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "FrmSelectDocument";
            Ribbon = ribbon;
            StartPosition = FormStartPosition.CenterScreen;
            StatusBar = ribbonStatusBar;
            Text = "FrmSelectDocument";
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdCtrDocument).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdViewDocument).EndInit();
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
        private DevExpress.XtraGrid.GridControl grdCtrDocument;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewDocument;
        private DevExpress.XtraGrid.Columns.GridColumn gridId;
        private DevExpress.XtraGrid.Columns.GridColumn grdFKey;
        private DevExpress.XtraGrid.Columns.GridColumn grdCode;
        private DevExpress.XtraGrid.Columns.GridColumn grdIsActive;
        private DevExpress.XtraBars.BarButtonItem btnLoadData;
        private DevExpress.XtraGrid.Columns.GridColumn grdDocumentSummary;
        private DevExpress.XtraGrid.Columns.GridColumn grdSecurityLevel;
        private DevExpress.XtraGrid.Columns.GridColumn grdStatusMessage;
        private DevExpress.XtraGrid.Columns.GridColumn grdStatus;
        private Label label1;
    }
}