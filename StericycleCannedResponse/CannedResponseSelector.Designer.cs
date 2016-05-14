namespace StericycleCannedResponse
{
    partial class CannedResponseSelector
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
            this.CannedResponseTree = new System.Windows.Forms.TreeView();
            this.canned_response_ok_button = new System.Windows.Forms.Button();
            this.canned_response_cancel_button = new System.Windows.Forms.Button();
            this.ResponseTextName = new System.Windows.Forms.TextBox();
            this.CannedResponseName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.instruction_text = new System.Windows.Forms.Label();
            this.canned_response_text = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // CannedResponseTree
            // 
            this.CannedResponseTree.Location = new System.Drawing.Point(12, 58);
            this.CannedResponseTree.Name = "CannedResponseTree";
            this.CannedResponseTree.Size = new System.Drawing.Size(222, 454);
            this.CannedResponseTree.TabIndex = 0;
            this.CannedResponseTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CannedResponseTree_AfterSelect);
            // 
            // canned_response_ok_button
            // 
            this.canned_response_ok_button.Location = new System.Drawing.Point(580, 520);
            this.canned_response_ok_button.Name = "canned_response_ok_button";
            this.canned_response_ok_button.Size = new System.Drawing.Size(75, 23);
            this.canned_response_ok_button.TabIndex = 1;
            this.canned_response_ok_button.Text = "OK";
            this.canned_response_ok_button.UseVisualStyleBackColor = true;
            this.canned_response_ok_button.Click += new System.EventHandler(this.canned_response_ok_button_Click);
            // 
            // canned_response_cancel_button
            // 
            this.canned_response_cancel_button.Location = new System.Drawing.Point(661, 520);
            this.canned_response_cancel_button.Name = "canned_response_cancel_button";
            this.canned_response_cancel_button.Size = new System.Drawing.Size(75, 23);
            this.canned_response_cancel_button.TabIndex = 2;
            this.canned_response_cancel_button.Text = "Cancel";
            this.canned_response_cancel_button.UseVisualStyleBackColor = true;
            this.canned_response_cancel_button.Click += new System.EventHandler(this.canned_response_cancel_button_Click);
            // 
            // ResponseTextName
            // 
            this.ResponseTextName.Location = new System.Drawing.Point(259, 58);
            this.ResponseTextName.Name = "ResponseTextName";
            this.ResponseTextName.Size = new System.Drawing.Size(477, 20);
            this.ResponseTextName.TabIndex = 3;
            this.ResponseTextName.TextChanged += new System.EventHandler(this.ResponseTextName_TextChanged);
            // 
            // CannedResponseName
            // 
            this.CannedResponseName.AutoSize = true;
            this.CannedResponseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CannedResponseName.Location = new System.Drawing.Point(256, 39);
            this.CannedResponseName.Name = "CannedResponseName";
            this.CannedResponseName.Size = new System.Drawing.Size(51, 16);
            this.CannedResponseName.TabIndex = 4;
            this.CannedResponseName.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Preview :";
            // 
            // instruction_text
            // 
            this.instruction_text.AutoSize = true;
            this.instruction_text.Location = new System.Drawing.Point(13, 13);
            this.instruction_text.Name = "instruction_text";
            this.instruction_text.Size = new System.Drawing.Size(35, 13);
            this.instruction_text.TabIndex = 7;
            this.instruction_text.Text = "label2";
            // 
            // canned_response_text
            // 
            this.canned_response_text.Location = new System.Drawing.Point(262, 105);
            this.canned_response_text.MinimumSize = new System.Drawing.Size(20, 20);
            this.canned_response_text.Name = "canned_response_text";
            this.canned_response_text.ScrollBarsEnabled = false;
            this.canned_response_text.Size = new System.Drawing.Size(474, 407);
            this.canned_response_text.TabIndex = 8;
            this.canned_response_text.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.canned_response_text_DocumentCompleted);
            // 
            // CannedResponseSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 555);
            this.Controls.Add(this.canned_response_text);
            this.Controls.Add(this.instruction_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CannedResponseName);
            this.Controls.Add(this.ResponseTextName);
            this.Controls.Add(this.canned_response_cancel_button);
            this.Controls.Add(this.canned_response_ok_button);
            this.Controls.Add(this.CannedResponseTree);
            this.Name = "CannedResponseSelector";
            this.Text = "CannedResponseSelector";
            this.Load += new System.EventHandler(this.CannedResponseSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TreeView CannedResponseTree;
        private System.Windows.Forms.Button canned_response_ok_button;
        private System.Windows.Forms.Button canned_response_cancel_button;
        private System.Windows.Forms.TextBox ResponseTextName;
        private System.Windows.Forms.Label CannedResponseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label instruction_text;
        public System.Windows.Forms.WebBrowser canned_response_text;
    }
}