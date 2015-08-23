namespace Target
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            GrapeCity.Win.Editors.ListItem listItem1 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem1 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem2 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem2 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem3 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem3 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem4 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem4 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem5 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem5 = new GrapeCity.Win.Editors.SubItem();
            GrapeCity.Win.Editors.ListItem listItem6 = new GrapeCity.Win.Editors.ListItem();
            GrapeCity.Win.Editors.SubItem subItem6 = new GrapeCity.Win.Editors.SubItem();
            this._textBox = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this._comboBox = new GrapeCity.Win.Editors.GcComboBox(this.components);
            this.dropDownButton1 = new GrapeCity.Win.Editors.DropDownButton();
            this.gcShortcut1 = new GrapeCity.Win.Editors.GcShortcut(this.components);
            this._comboBox_ShiftJIS = new GrapeCity.Win.Editors.GcComboBox(this.components);
            this.dropDownButton2 = new GrapeCity.Win.Editors.DropDownButton();
            this._multiLineText = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this._textBoxShiftJIS = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._textBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._comboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._comboBox_ShiftJIS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._multiLineText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._textBoxShiftJIS)).BeginInit();
            this.SuspendLayout();
            // 
            // _textBox
            // 
            this._textBox.Location = new System.Drawing.Point(13, 39);
            this._textBox.Name = "_textBox";
            this._textBox.Size = new System.Drawing.Size(120, 20);
            this._textBox.TabIndex = 0;
            // 
            // _comboBox
            // 
            subItem1.Value = "a";
            listItem1.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem1});
            subItem2.Value = "b";
            listItem2.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem2});
            subItem3.Value = "c";
            listItem3.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem3});
            this._comboBox.Items.AddRange(new GrapeCity.Win.Editors.ListItem[] {
            listItem1,
            listItem2,
            listItem3});
            this._comboBox.ListHeaderPane.Height = 19;
            this._comboBox.Location = new System.Drawing.Point(13, 65);
            this._comboBox.Name = "_comboBox";
            this.gcShortcut1.SetShortcuts(this._comboBox, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2,
                ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return)))}, new object[] {
                ((object)(this._comboBox)),
                ((object)(this._comboBox))}, new string[] {
                "ShortcutClear",
                "ApplyRecommendedValue"}));
            this._comboBox.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] {
            this.dropDownButton1});
            this._comboBox.Size = new System.Drawing.Size(120, 20);
            this._comboBox.TabIndex = 1;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Name = "dropDownButton1";
            // 
            // _comboBox_ShiftJIS
            // 
            subItem4.Value = "a";
            listItem4.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem4});
            subItem5.Value = "b";
            listItem5.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem5});
            subItem6.Value = "c";
            listItem6.SubItems.AddRange(new GrapeCity.Win.Editors.SubItem[] {
            subItem6});
            this._comboBox_ShiftJIS.Items.AddRange(new GrapeCity.Win.Editors.ListItem[] {
            listItem4,
            listItem5,
            listItem6});
            this._comboBox_ShiftJIS.ListHeaderPane.Height = 19;
            this._comboBox_ShiftJIS.Location = new System.Drawing.Point(232, 65);
            this._comboBox_ShiftJIS.MaxLength = 20;
            this._comboBox_ShiftJIS.MaxLengthCodePage = 932;
            this._comboBox_ShiftJIS.MaxLengthUnit = GrapeCity.Win.Editors.LengthUnit.Byte;
            this._comboBox_ShiftJIS.Name = "_comboBox_ShiftJIS";
            this.gcShortcut1.SetShortcuts(this._comboBox_ShiftJIS, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2,
                ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return)))}, new object[] {
                ((object)(this._comboBox_ShiftJIS)),
                ((object)(this._comboBox_ShiftJIS))}, new string[] {
                "ShortcutClear",
                "ApplyRecommendedValue"}));
            this._comboBox_ShiftJIS.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] {
            this.dropDownButton2});
            this._comboBox_ShiftJIS.Size = new System.Drawing.Size(120, 20);
            this._comboBox_ShiftJIS.TabIndex = 4;
            // 
            // dropDownButton2
            // 
            this.dropDownButton2.Name = "dropDownButton2";
            // 
            // _multiLineText
            // 
            this._multiLineText.Location = new System.Drawing.Point(13, 120);
            this._multiLineText.Multiline = true;
            this._multiLineText.Name = "_multiLineText";
            this._multiLineText.Size = new System.Drawing.Size(189, 99);
            this._multiLineText.TabIndex = 2;
            // 
            // _textBoxShiftJIS
            // 
            this._textBoxShiftJIS.Location = new System.Drawing.Point(232, 39);
            this._textBoxShiftJIS.MaxLength = 20;
            this._textBoxShiftJIS.MaxLengthCodePage = 932;
            this._textBoxShiftJIS.MaxLengthUnit = GrapeCity.Win.Editors.LengthUnit.Byte;
            this._textBoxShiftJIS.Name = "_textBoxShiftJIS";
            this._textBoxShiftJIS.Size = new System.Drawing.Size(120, 20);
            this._textBoxShiftJIS.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "UTF-8 Encoding";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "SHIFT-JIS Encoding";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._comboBox_ShiftJIS);
            this.Controls.Add(this._textBoxShiftJIS);
            this.Controls.Add(this._multiLineText);
            this.Controls.Add(this._comboBox);
            this.Controls.Add(this._textBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this._textBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._comboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._comboBox_ShiftJIS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._multiLineText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._textBoxShiftJIS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GrapeCity.Win.Editors.GcTextBox _textBox;
        private GrapeCity.Win.Editors.GcComboBox _comboBox;
        private GrapeCity.Win.Editors.GcShortcut gcShortcut1;
        private GrapeCity.Win.Editors.DropDownButton dropDownButton1;
        private GrapeCity.Win.Editors.GcTextBox _multiLineText;
        private GrapeCity.Win.Editors.GcComboBox _comboBox_ShiftJIS;
        private GrapeCity.Win.Editors.DropDownButton dropDownButton2;
        private GrapeCity.Win.Editors.GcTextBox _textBoxShiftJIS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

