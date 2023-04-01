namespace Extension_Filter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.selectPath_btn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.filter_btn = new System.Windows.Forms.Button();
            this.folderPathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectPath_btn
            // 
            this.selectPath_btn.ImageIndex = 1;
            this.selectPath_btn.ImageList = this.imageList1;
            this.selectPath_btn.Location = new System.Drawing.Point(71, 66);
            this.selectPath_btn.Name = "selectPath_btn";
            this.selectPath_btn.Size = new System.Drawing.Size(247, 101);
            this.selectPath_btn.TabIndex = 1;
            this.selectPath_btn.UseVisualStyleBackColor = true;
            this.selectPath_btn.Click += new System.EventHandler(this.selectPath_btn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-filter-16.png");
            this.imageList1.Images.SetKeyName(1, "icons8-add-folder-16.png");
            // 
            // filter_btn
            // 
            this.filter_btn.ImageIndex = 0;
            this.filter_btn.ImageList = this.imageList1;
            this.filter_btn.Location = new System.Drawing.Point(71, 195);
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Size = new System.Drawing.Size(247, 101);
            this.filter_btn.TabIndex = 2;
            this.filter_btn.UseVisualStyleBackColor = true;
            this.filter_btn.Click += new System.EventHandler(this.filter_btn_Click);
            // 
            // folderPathLabel
            // 
            this.folderPathLabel.AutoSize = true;
            this.folderPathLabel.Location = new System.Drawing.Point(42, 24);
            this.folderPathLabel.Name = "folderPathLabel";
            this.folderPathLabel.Size = new System.Drawing.Size(0, 16);
            this.folderPathLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(389, 329);
            this.Controls.Add(this.folderPathLabel);
            this.Controls.Add(this.filter_btn);
            this.Controls.Add(this.selectPath_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extension Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectPath_btn;
        private System.Windows.Forms.Button filter_btn;
        private System.Windows.Forms.Label folderPathLabel;
        private System.Windows.Forms.ImageList imageList1;
    }
}

