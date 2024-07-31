namespace WinForms_Vsoft
{
    partial class FrmAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdd));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnSave = new DevExpress.XtraBars.BarButtonItem();
            btnShowDocument = new DevExpress.XtraBars.BarButtonItem();
            btnShowUser = new DevExpress.XtraBars.BarButtonItem();
            btnCloseAddForm = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            label1 = new Label();
            txtDocumentId = new DevExpress.XtraEditors.TextEdit();
            label2 = new Label();
            txtUserId = new DevExpress.XtraEditors.TextEdit();
            label4 = new Label();
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dateExpiredIn = new DevExpress.XtraEditors.DateEdit();
            cbIsActive = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDocumentId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUserId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateExpiredIn.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateExpiredIn.Properties.CalendarTimeProperties).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, btnSave, btnShowDocument, btnShowUser, btnCloseAddForm });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 5;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new Size(1180, 231);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // btnSave
            // 
            btnSave.Caption = "Lưu và đóng";
            btnSave.Id = 1;
            btnSave.ImageOptions.Image = (Image)resources.GetObject("btnSave.ImageOptions.Image");
            btnSave.ImageOptions.LargeImage = (Image)resources.GetObject("btnSave.ImageOptions.LargeImage");
            btnSave.Name = "btnSave";
            btnSave.ItemClick += btnSave_ItemClick;
            // 
            // btnShowDocument
            // 
            btnShowDocument.Caption = "Lấy Id Tài liệu từ danh sách";
            btnShowDocument.Id = 2;
            btnShowDocument.ImageOptions.Image = (Image)resources.GetObject("btnShowDocument.ImageOptions.Image");
            btnShowDocument.ImageOptions.LargeImage = (Image)resources.GetObject("btnShowDocument.ImageOptions.LargeImage");
            btnShowDocument.Name = "btnShowDocument";
            btnShowDocument.ItemClick += btnShowDocument_ItemClick;
            // 
            // btnShowUser
            // 
            btnShowUser.Caption = "Lấy Id Người dùng từ danh sách";
            btnShowUser.Id = 3;
            btnShowUser.ImageOptions.Image = (Image)resources.GetObject("btnShowUser.ImageOptions.Image");
            btnShowUser.ImageOptions.LargeImage = (Image)resources.GetObject("btnShowUser.ImageOptions.LargeImage");
            btnShowUser.Name = "btnShowUser";
            btnShowUser.ItemClick += btnShowUser_ItemClick;
            // 
            // btnCloseAddForm
            // 
            btnCloseAddForm.Caption = "Đóng";
            btnCloseAddForm.Id = 4;
            btnCloseAddForm.ImageOptions.Image = (Image)resources.GetObject("btnCloseAddForm.ImageOptions.Image");
            btnCloseAddForm.ImageOptions.LargeImage = (Image)resources.GetObject("btnCloseAddForm.ImageOptions.LargeImage");
            btnCloseAddForm.Name = "btnCloseAddForm";
            btnCloseAddForm.ItemClick += btnCloseAddForm_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Bảng chọn";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btnSave);
            ribbonPageGroup1.ItemLinks.Add(btnShowDocument);
            ribbonPageGroup1.ItemLinks.Add(btnShowUser);
            ribbonPageGroup1.ItemLinks.Add(btnCloseAddForm);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Thao tác";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 700);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1180, 36);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 298);
            label1.Name = "label1";
            label1.Size = new Size(156, 34);
            label1.TabIndex = 2;
            label1.Text = "Id Tài liệu";
            // 
            // txtDocumentId
            // 
            txtDocumentId.Location = new Point(391, 295);
            txtDocumentId.MenuManager = ribbon;
            txtDocumentId.Name = "txtDocumentId";
            txtDocumentId.Properties.Appearance.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumentId.Properties.Appearance.Options.UseFont = true;
            txtDocumentId.Size = new Size(553, 40);
            txtDocumentId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(212, 298);
            label2.Name = "label2";
            label2.Size = new Size(23, 24);
            label2.TabIndex = 4;
            label2.Text = "*";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(391, 371);
            txtUserId.MenuManager = ribbon;
            txtUserId.Name = "txtUserId";
            txtUserId.Properties.Appearance.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserId.Properties.Appearance.Options.UseFont = true;
            txtUserId.Size = new Size(553, 40);
            txtUserId.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(65, 374);
            label4.Name = "label4";
            label4.Size = new Size(221, 34);
            label4.TabIndex = 5;
            label4.Text = "Id Người dùng";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(391, 453);
            txtEmail.MenuManager = ribbon;
            txtEmail.Name = "txtEmail";
            txtEmail.Properties.Appearance.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Properties.Appearance.Options.UseFont = true;
            txtEmail.Size = new Size(553, 40);
            txtEmail.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(65, 456);
            label6.Name = "label6";
            label6.Size = new Size(262, 34);
            label6.TabIndex = 8;
            label6.Text = "Email người dùng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(263, 538);
            label7.Name = "label7";
            label7.Size = new Size(23, 24);
            label7.TabIndex = 13;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(65, 538);
            label8.Name = "label8";
            label8.Size = new Size(204, 34);
            label8.TabIndex = 11;
            label8.Text = "Ngày hết hạn";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(212, 619);
            label9.Name = "label9";
            label9.Size = new Size(23, 24);
            label9.TabIndex = 16;
            label9.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(65, 619);
            label10.Name = "label10";
            label10.Size = new Size(148, 34);
            label10.TabIndex = 14;
            label10.Text = "Kích hoạt";
            // 
            // dateExpiredIn
            // 
            dateExpiredIn.EditValue = null;
            dateExpiredIn.Location = new Point(391, 535);
            dateExpiredIn.MenuManager = ribbon;
            dateExpiredIn.Name = "dateExpiredIn";
            dateExpiredIn.Properties.Appearance.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            dateExpiredIn.Properties.Appearance.Options.UseFont = true;
            dateExpiredIn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateExpiredIn.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateExpiredIn.Size = new Size(553, 40);
            dateExpiredIn.TabIndex = 17;
            // 
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.Checked = true;
            cbIsActive.CheckState = CheckState.Checked;
            cbIsActive.Location = new Point(391, 622);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(22, 21);
            cbIsActive.TabIndex = 18;
            cbIsActive.UseVisualStyleBackColor = true;
            // 
            // FrmAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 736);
            Controls.Add(cbIsActive);
            Controls.Add(dateExpiredIn);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(txtUserId);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtDocumentId);
            Controls.Add(label1);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "FrmAdd";
            Ribbon = ribbon;
            StartPosition = FormStartPosition.CenterScreen;
            StatusBar = ribbonStatusBar;
            Text = "FrmAdd";
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDocumentId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUserId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
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
        private Label label1;
        private DevExpress.XtraEditors.TextEdit txtDocumentId;
        private Label label2;
        private DevExpress.XtraEditors.TextEdit txtUserId;
        private Label label4;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DevExpress.XtraEditors.DateEdit dateExpiredIn;
        private CheckBox cbIsActive;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnShowDocument;
        private DevExpress.XtraBars.BarButtonItem btnShowUser;
        private DevExpress.XtraBars.BarButtonItem btnCloseAddForm;
    }
}