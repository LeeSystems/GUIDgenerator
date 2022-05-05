namespace GUIDgenerate
{
    partial class GUIDgenerate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIDgenerate));
            this.button_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_GUID = new System.Windows.Forms.TextBox();
            this.button_Generate = new System.Windows.Forms.Button();
            this.checkBox_UpperCase = new System.Windows.Forms.CheckBox();
            this.checkBox_ClipBoard = new System.Windows.Forms.CheckBox();
            this.listBox_GUIDlist = new System.Windows.Forms.ListBox();
            this.numericUpDown_Count = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Count)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(278, 86);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 0;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GUID";
            // 
            // textBox_GUID
            // 
            this.textBox_GUID.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GUID.Location = new System.Drawing.Point(13, 30);
            this.textBox_GUID.Name = "textBox_GUID";
            this.textBox_GUID.Size = new System.Drawing.Size(340, 22);
            this.textBox_GUID.TabIndex = 2;
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(278, 57);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(75, 23);
            this.button_Generate.TabIndex = 4;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // checkBox_UpperCase
            // 
            this.checkBox_UpperCase.AutoSize = true;
            this.checkBox_UpperCase.Checked = true;
            this.checkBox_UpperCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_UpperCase.Location = new System.Drawing.Point(16, 57);
            this.checkBox_UpperCase.Name = "checkBox_UpperCase";
            this.checkBox_UpperCase.Size = new System.Drawing.Size(82, 17);
            this.checkBox_UpperCase.TabIndex = 5;
            this.checkBox_UpperCase.Text = "Upper Case";
            this.checkBox_UpperCase.UseVisualStyleBackColor = true;
            // 
            // checkBox_ClipBoard
            // 
            this.checkBox_ClipBoard.AutoSize = true;
            this.checkBox_ClipBoard.Checked = true;
            this.checkBox_ClipBoard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ClipBoard.Location = new System.Drawing.Point(16, 80);
            this.checkBox_ClipBoard.Name = "checkBox_ClipBoard";
            this.checkBox_ClipBoard.Size = new System.Drawing.Size(110, 17);
            this.checkBox_ClipBoard.TabIndex = 6;
            this.checkBox_ClipBoard.Text = "Place in Clipboers";
            this.checkBox_ClipBoard.UseVisualStyleBackColor = true;
            // 
            // listBox_GUIDlist
            // 
            this.listBox_GUIDlist.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_GUIDlist.FormattingEnabled = true;
            this.listBox_GUIDlist.ItemHeight = 16;
            this.listBox_GUIDlist.Location = new System.Drawing.Point(16, 120);
            this.listBox_GUIDlist.Name = "listBox_GUIDlist";
            this.listBox_GUIDlist.Size = new System.Drawing.Size(337, 132);
            this.listBox_GUIDlist.TabIndex = 7;
            this.listBox_GUIDlist.SelectedIndexChanged += new System.EventHandler(this.listBox_GUIDlist_SelectedIndexChanged);
            // 
            // numericUpDown_Count
            // 
            this.numericUpDown_Count.Location = new System.Drawing.Point(201, 59);
            this.numericUpDown_Count.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Count.Name = "numericUpDown_Count";
            this.numericUpDown_Count.Size = new System.Drawing.Size(73, 20);
            this.numericUpDown_Count.TabIndex = 8;
            this.numericUpDown_Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "GUID List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Count";
            // 
            // GUIDgenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 266);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_Count);
            this.Controls.Add(this.listBox_GUIDlist);
            this.Controls.Add(this.checkBox_ClipBoard);
            this.Controls.Add(this.checkBox_UpperCase);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.textBox_GUID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Clear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUIDgenerate";
            this.Text = "GUID Generate";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GUIDgenerate_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_GUID;
        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.CheckBox checkBox_UpperCase;
        private System.Windows.Forms.CheckBox checkBox_ClipBoard;
        private System.Windows.Forms.ListBox listBox_GUIDlist;
        private System.Windows.Forms.NumericUpDown numericUpDown_Count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

