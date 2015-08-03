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
            this._textBox = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this._comboBox = new GrapeCity.Win.Editors.GcComboBox(this.components);
            this.dropDownButton1 = new GrapeCity.Win.Editors.DropDownButton();
            this.gcShortcut1 = new GrapeCity.Win.Editors.GcShortcut(this.components);
            this._multiLineText = new GrapeCity.Win.Editors.GcTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._textBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._comboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._multiLineText)).BeginInit();
            this.SuspendLayout();
            // 
            // _textBox
            // 
            this._textBox.Location = new System.Drawing.Point(13, 13);
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
            this._comboBox.Location = new System.Drawing.Point(13, 39);
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
            // _multiLineText
            // 
            this._multiLineText.Location = new System.Drawing.Point(13, 120);
            this._multiLineText.Multiline = true;
            this._multiLineText.Name = "_multiLineText";
            this._multiLineText.Size = new System.Drawing.Size(189, 99);
            this._multiLineText.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this._multiLineText);
            this.Controls.Add(this._comboBox);
            this.Controls.Add(this._textBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this._textBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._comboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._multiLineText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GrapeCity.Win.Editors.GcTextBox _textBox;
        private GrapeCity.Win.Editors.GcComboBox _comboBox;
        private GrapeCity.Win.Editors.GcShortcut gcShortcut1;
        private GrapeCity.Win.Editors.DropDownButton dropDownButton1;
        private GrapeCity.Win.Editors.GcTextBox _multiLineText;
    }
}

