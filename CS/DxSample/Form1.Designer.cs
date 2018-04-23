namespace DxSample
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAllowUpdate = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.pivotGrid1 = new DxSample.MyPivotGrid();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAllowUpdate
            // 
            this.btnAllowUpdate.Location = new System.Drawing.Point(93, 12);
            this.btnAllowUpdate.Name = "btnAllowUpdate";
            this.btnAllowUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAllowUpdate.TabIndex = 2;
            this.btnAllowUpdate.Text = "Update";
            this.btnAllowUpdate.UseVisualStyleBackColor = true;
            this.btnAllowUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(174, 12);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // pivotGrid1
            // 
            this.pivotGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGrid1.Location = new System.Drawing.Point(12, 41);
            this.pivotGrid1.Name = "pivotGrid1";
            this.pivotGrid1.Size = new System.Drawing.Size(698, 359);
            this.pivotGrid1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 412);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnAllowUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pivotGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyPivotGrid pivotGrid1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAllowUpdate;
        private System.Windows.Forms.Button btnRestore;

    }
}

