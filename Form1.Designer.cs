namespace DP_Sample01
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.lvwCategory = new System.Windows.Forms.ListView();
            this.chrCatID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chrDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chrCatName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "GetInfo";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lvwCategory
            // 
            this.lvwCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chrCatID,
            this.chrDescription,
            this.chrCatName});
            this.lvwCategory.FullRowSelect = true;
            this.lvwCategory.Location = new System.Drawing.Point(12, 54);
            this.lvwCategory.Name = "lvwCategory";
            this.lvwCategory.Size = new System.Drawing.Size(401, 195);
            this.lvwCategory.TabIndex = 1;
            this.lvwCategory.UseCompatibleStateImageBehavior = false;
            this.lvwCategory.View = System.Windows.Forms.View.Details;
            // 
            // chrCatID
            // 
            this.chrCatID.Text = "Mã Loại";
            // 
            // chrDescription
            // 
            this.chrDescription.DisplayIndex = 2;
            this.chrDescription.Text = "Mô Tả";
            this.chrDescription.Width = 210;
            // 
            // chrCatName
            // 
            this.chrCatName.DisplayIndex = 1;
            this.chrCatName.Text = "Tên Mặt Hàng";
            this.chrCatName.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 261);
            this.Controls.Add(this.lvwCategory);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Information";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListView lvwCategory;
        private System.Windows.Forms.ColumnHeader chrCatID;
        private System.Windows.Forms.ColumnHeader chrDescription;
        private System.Windows.Forms.ColumnHeader chrCatName;
    }
}

