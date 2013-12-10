namespace Music
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
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lstbxInstruments = new System.Windows.Forms.ListBox();
            this.grpTypes = new System.Windows.Forms.GroupBox();
            this.btnSlctAll = new System.Windows.Forms.Button();
            this.btnClearSlct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.Location = new System.Drawing.Point(213, 9);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(68, 30);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "Music";
            // 
            // lstbxInstruments
            // 
            this.lstbxInstruments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbxInstruments.FormattingEnabled = true;
            this.lstbxInstruments.Location = new System.Drawing.Point(193, 67);
            this.lstbxInstruments.Name = "lstbxInstruments";
            this.lstbxInstruments.Size = new System.Drawing.Size(334, 381);
            this.lstbxInstruments.TabIndex = 2;
            // 
            // grpTypes
            // 
            this.grpTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpTypes.Location = new System.Drawing.Point(12, 61);
            this.grpTypes.Name = "grpTypes";
            this.grpTypes.Size = new System.Drawing.Size(175, 358);
            this.grpTypes.TabIndex = 3;
            this.grpTypes.TabStop = false;
            this.grpTypes.Text = "Types";
            // 
            // btnSlctAll
            // 
            this.btnSlctAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSlctAll.Location = new System.Drawing.Point(12, 425);
            this.btnSlctAll.Name = "btnSlctAll";
            this.btnSlctAll.Size = new System.Drawing.Size(75, 23);
            this.btnSlctAll.TabIndex = 4;
            this.btnSlctAll.Text = "Select All";
            this.btnSlctAll.UseVisualStyleBackColor = true;
            this.btnSlctAll.Click += new System.EventHandler(this.btnSlctAll_Click);
            // 
            // btnClearSlct
            // 
            this.btnClearSlct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearSlct.Location = new System.Drawing.Point(93, 425);
            this.btnClearSlct.Name = "btnClearSlct";
            this.btnClearSlct.Size = new System.Drawing.Size(75, 23);
            this.btnClearSlct.TabIndex = 5;
            this.btnClearSlct.Text = "Deselect All";
            this.btnClearSlct.UseVisualStyleBackColor = true;
            this.btnClearSlct.Click += new System.EventHandler(this.btnClearSlct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 516);
            this.Controls.Add(this.btnClearSlct);
            this.Controls.Add(this.btnSlctAll);
            this.Controls.Add(this.grpTypes);
            this.Controls.Add(this.lstbxInstruments);
            this.Controls.Add(this.lblAppTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.ListBox lstbxInstruments;
        private System.Windows.Forms.GroupBox grpTypes;
        private System.Windows.Forms.Button btnSlctAll;
        private System.Windows.Forms.Button btnClearSlct;
    }
}

