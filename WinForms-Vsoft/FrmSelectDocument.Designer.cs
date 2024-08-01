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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue3 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue4 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            grdStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnSelect = new DevExpress.XtraBars.BarButtonItem();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            btnLoadData = new DevExpress.XtraBars.BarButtonItem();
            btnSelectUser = new DevExpress.XtraBars.BarButtonItem();
            btnSelectEmail = new DevExpress.XtraBars.BarButtonItem();
            barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            btnDeleteAnUser = new DevExpress.XtraBars.BarButtonItem();
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
            grdCtrSelectedUser = new DevExpress.XtraGrid.GridControl();
            grdViewSelectedUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            grdEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            grdFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            dateExpiredIn = new DevExpress.XtraEditors.DateEdit();
            label2 = new Label();
            cbIsActive = new CheckBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdCtrDocument).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdViewDocument).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdCtrSelectedUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdViewSelectedUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateExpiredIn.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateExpiredIn.Properties.CalendarTimeProperties).BeginInit();
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
            // gridColumn2
            // 
            gridColumn2.Caption = "Kích hoạt";
            gridColumn2.FieldName = "IsActive";
            gridColumn2.MinWidth = 30;
            gridColumn2.Name = "gridColumn2";
            gridColumn2.OptionsColumn.AllowEdit = false;
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 2;
            gridColumn2.Width = 165;
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, btnSelect, btnClose, btnLoadData, btnSelectUser, btnSelectEmail, barStaticItem1, btnDeleteAnUser });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 8;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new Size(1492, 231);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // btnSelect
            // 
            btnSelect.Caption = "Chia sẻ";
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
            // btnSelectUser
            // 
            btnSelectUser.Caption = "Chọn người dùng trong hệ thống";
            btnSelectUser.Id = 4;
            btnSelectUser.ImageOptions.Image = (Image)resources.GetObject("btnSelectUser.ImageOptions.Image");
            btnSelectUser.ImageOptions.LargeImage = (Image)resources.GetObject("btnSelectUser.ImageOptions.LargeImage");
            btnSelectUser.Name = "btnSelectUser";
            btnSelectUser.ItemClick += btnSelectUser_ItemClick;
            // 
            // btnSelectEmail
            // 
            btnSelectEmail.Caption = "Chọn người dùng ngoài hệ thống";
            btnSelectEmail.Id = 5;
            btnSelectEmail.ImageOptions.Image = (Image)resources.GetObject("btnSelectEmail.ImageOptions.Image");
            btnSelectEmail.ImageOptions.LargeImage = (Image)resources.GetObject("btnSelectEmail.ImageOptions.LargeImage");
            btnSelectEmail.Name = "btnSelectEmail";
            btnSelectEmail.ItemClick += btnSelectEmail_ItemClick;
            // 
            // barStaticItem1
            // 
            barStaticItem1.Caption = "barStaticItem1";
            barStaticItem1.Id = 6;
            barStaticItem1.Name = "barStaticItem1";
            // 
            // btnDeleteAnUser
            // 
            btnDeleteAnUser.Caption = "Xóa 1 người dùng đã chọn";
            btnDeleteAnUser.Id = 7;
            btnDeleteAnUser.ImageOptions.Image = (Image)resources.GetObject("btnDeleteAnUser.ImageOptions.Image");
            btnDeleteAnUser.ImageOptions.LargeImage = (Image)resources.GetObject("btnDeleteAnUser.ImageOptions.LargeImage");
            btnDeleteAnUser.Name = "btnDeleteAnUser";
            btnDeleteAnUser.ItemClick += btnDeleteAnUser_ItemClick;
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
            ribbonPageGroup1.ItemLinks.Add(btnSelectUser);
            ribbonPageGroup1.ItemLinks.Add(btnSelectEmail);
            ribbonPageGroup1.ItemLinks.Add(btnDeleteAnUser);
            ribbonPageGroup1.ItemLinks.Add(btnLoadData);
            ribbonPageGroup1.ItemLinks.Add(btnClose);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Lấy dữ liệu";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 924);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1492, 36);
            // 
            // grdCtrDocument
            // 
            grdCtrDocument.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grdCtrDocument.Location = new Point(0, 274);
            grdCtrDocument.MainView = grdViewDocument;
            grdCtrDocument.MenuManager = ribbon;
            grdCtrDocument.Name = "grdCtrDocument";
            grdCtrDocument.Size = new Size(1492, 395);
            grdCtrDocument.TabIndex = 2;
            grdCtrDocument.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grdViewDocument });
            // 
            // grdViewDocument
            // 
            grdViewDocument.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridId, grdDocumentSummary, grdFKey, grdCode, grdIsActive, grdSecurityLevel, grdStatusMessage, grdStatus });
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = grdStatus;
            gridFormatRule1.Name = "Status0";
            formatConditionRuleValue1.Appearance.BackColor = Color.FromArgb(255, 224, 192);
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = (short)0;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = grdStatus;
            gridFormatRule2.Name = "Status2";
            formatConditionRuleValue2.Appearance.BackColor = Color.FromArgb(255, 224, 192);
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.Value1 = (short)2;
            gridFormatRule2.Rule = formatConditionRuleValue2;
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Column = grdStatus;
            gridFormatRule3.Name = "Status4";
            formatConditionRuleValue3.Appearance.BackColor = Color.FromArgb(255, 224, 192);
            formatConditionRuleValue3.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue3.Value1 = (short)4;
            gridFormatRule3.Rule = formatConditionRuleValue3;
            grdViewDocument.FormatRules.Add(gridFormatRule1);
            grdViewDocument.FormatRules.Add(gridFormatRule2);
            grdViewDocument.FormatRules.Add(gridFormatRule3);
            grdViewDocument.GridControl = grdCtrDocument;
            grdViewDocument.Name = "grdViewDocument";
            grdViewDocument.ViewCaption = "Danh sách tài liệu";
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
            // grdCtrSelectedUser
            // 
            grdCtrSelectedUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grdCtrSelectedUser.Location = new Point(0, 675);
            grdCtrSelectedUser.MainView = grdViewSelectedUser;
            grdCtrSelectedUser.MenuManager = ribbon;
            grdCtrSelectedUser.Name = "grdCtrSelectedUser";
            grdCtrSelectedUser.Size = new Size(1492, 249);
            grdCtrSelectedUser.TabIndex = 11;
            grdCtrSelectedUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grdViewSelectedUser });
            // 
            // grdViewSelectedUser
            // 
            grdViewSelectedUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, grdEmail, grdFullName, gridColumn2 });
            gridFormatRule4.ApplyToRow = true;
            gridFormatRule4.Column = gridColumn2;
            gridFormatRule4.Name = "IsActive";
            formatConditionRuleValue4.Appearance.BackColor = Color.FromArgb(255, 224, 192);
            formatConditionRuleValue4.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue4.Value1 = false;
            gridFormatRule4.Rule = formatConditionRuleValue4;
            grdViewSelectedUser.FormatRules.Add(gridFormatRule4);
            grdViewSelectedUser.GridControl = grdCtrSelectedUser;
            grdViewSelectedUser.Name = "grdViewSelectedUser";
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Id";
            gridColumn1.FieldName = "Id";
            gridColumn1.MinWidth = 30;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.OptionsColumn.AllowEdit = false;
            gridColumn1.Width = 322;
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
            // dateExpiredIn
            // 
            dateExpiredIn.EditValue = null;
            dateExpiredIn.Location = new Point(134, 242);
            dateExpiredIn.MenuManager = ribbon;
            dateExpiredIn.Name = "dateExpiredIn";
            dateExpiredIn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateExpiredIn.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateExpiredIn.Size = new Size(271, 26);
            dateExpiredIn.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Location = new Point(12, 245);
            label2.Name = "label2";
            label2.Size = new Size(103, 19);
            label2.TabIndex = 15;
            label2.Text = "Ngày hết hạn";
            // 
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.BackColor = Color.WhiteSmoke;
            cbIsActive.Checked = true;
            cbIsActive.CheckState = CheckState.Checked;
            cbIsActive.Location = new Point(472, 245);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(100, 23);
            cbIsActive.TabIndex = 16;
            cbIsActive.Text = "Kích hoạt";
            cbIsActive.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(110, 245);
            label3.Name = "label3";
            label3.Size = new Size(18, 19);
            label3.TabIndex = 17;
            label3.Text = "*";
            // 
            // FrmSelectDocument
            // 
            Appearance.BackColor = Color.FromArgb(224, 224, 224);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 960);
            Controls.Add(label3);
            Controls.Add(cbIsActive);
            Controls.Add(label2);
            Controls.Add(dateExpiredIn);
            Controls.Add(grdCtrSelectedUser);
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
            ((System.ComponentModel.ISupportInitialize)grdCtrSelectedUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdViewSelectedUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateExpiredIn.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateExpiredIn.Properties).EndInit();
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
        private DevExpress.XtraGrid.GridControl grdCtrSelectedUser;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewSelectedUser;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn grdEmail;
        private DevExpress.XtraGrid.Columns.GridColumn grdFullName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.BarButtonItem btnSelectUser;
        private DevExpress.XtraBars.BarButtonItem btnSelectEmail;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem btnDeleteAnUser;
        private DevExpress.XtraEditors.DateEdit dateExpiredIn;
        private Label label2;
        private CheckBox cbIsActive;
        private Label label3;
    }
}