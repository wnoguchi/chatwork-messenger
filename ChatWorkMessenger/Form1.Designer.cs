namespace ChatWorkMessenger
{
    partial class Form1
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
            this.sendButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.memberListBox = new System.Windows.Forms.ListBox();
            this.selectAllMemberButton = new System.Windows.Forms.Button();
            this.clearSelectionButton = new System.Windows.Forms.Button();
            this.clearMessageButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foregroundFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(12, 275);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(12, 67);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messageTextBox.Size = new System.Drawing.Size(384, 202);
            this.messageTextBox.TabIndex = 1;
            // 
            // roomComboBox
            // 
            this.roomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Location = new System.Drawing.Point(12, 41);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(384, 20);
            this.roomComboBox.TabIndex = 2;
            this.roomComboBox.SelectedIndexChanged += new System.EventHandler(this.roomComboBox_SelectedIndexChanged);
            // 
            // memberListBox
            // 
            this.memberListBox.FormattingEnabled = true;
            this.memberListBox.ItemHeight = 12;
            this.memberListBox.Location = new System.Drawing.Point(402, 41);
            this.memberListBox.Name = "memberListBox";
            this.memberListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.memberListBox.Size = new System.Drawing.Size(182, 220);
            this.memberListBox.TabIndex = 3;
            // 
            // selectAllMemberButton
            // 
            this.selectAllMemberButton.Location = new System.Drawing.Point(402, 275);
            this.selectAllMemberButton.Name = "selectAllMemberButton";
            this.selectAllMemberButton.Size = new System.Drawing.Size(80, 23);
            this.selectAllMemberButton.TabIndex = 4;
            this.selectAllMemberButton.Text = "Select All";
            this.selectAllMemberButton.UseVisualStyleBackColor = true;
            this.selectAllMemberButton.Click += new System.EventHandler(this.selectAllMemberButton_Click);
            // 
            // clearSelectionButton
            // 
            this.clearSelectionButton.Location = new System.Drawing.Point(488, 275);
            this.clearSelectionButton.Name = "clearSelectionButton";
            this.clearSelectionButton.Size = new System.Drawing.Size(75, 23);
            this.clearSelectionButton.TabIndex = 5;
            this.clearSelectionButton.Text = "Clear";
            this.clearSelectionButton.UseVisualStyleBackColor = true;
            this.clearSelectionButton.Click += new System.EventHandler(this.clearSelectionButton_Click);
            // 
            // clearMessageButton
            // 
            this.clearMessageButton.Location = new System.Drawing.Point(94, 275);
            this.clearMessageButton.Name = "clearMessageButton";
            this.clearMessageButton.Size = new System.Drawing.Size(75, 23);
            this.clearMessageButton.TabIndex = 6;
            this.clearMessageButton.Text = "Clear";
            this.clearMessageButton.UseVisualStyleBackColor = true;
            this.clearMessageButton.Click += new System.EventHandler(this.clearMessageButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.viewVToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 26);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitXToolStripMenuItem});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.fileFToolStripMenuItem.Text = "File(&F)";
            // 
            // exitXToolStripMenuItem
            // 
            this.exitXToolStripMenuItem.Name = "exitXToolStripMenuItem";
            this.exitXToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitXToolStripMenuItem.Text = "Exit(&X)";
            this.exitXToolStripMenuItem.Click += new System.EventHandler(this.exitXToolStripMenuItem_Click);
            // 
            // viewVToolStripMenuItem
            // 
            this.viewVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foregroundFToolStripMenuItem});
            this.viewVToolStripMenuItem.Name = "viewVToolStripMenuItem";
            this.viewVToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.viewVToolStripMenuItem.Text = "View(&V)";
            // 
            // foregroundFToolStripMenuItem
            // 
            this.foregroundFToolStripMenuItem.Name = "foregroundFToolStripMenuItem";
            this.foregroundFToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.foregroundFToolStripMenuItem.Text = "Foreground(&F)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 313);
            this.Controls.Add(this.clearMessageButton);
            this.Controls.Add(this.clearSelectionButton);
            this.Controls.Add(this.selectAllMemberButton);
            this.Controls.Add(this.memberListBox);
            this.Controls.Add(this.roomComboBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ChatWorkMessenger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.ListBox memberListBox;
        private System.Windows.Forms.Button selectAllMemberButton;
        private System.Windows.Forms.Button clearSelectionButton;
        private System.Windows.Forms.Button clearMessageButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foregroundFToolStripMenuItem;
    }
}

