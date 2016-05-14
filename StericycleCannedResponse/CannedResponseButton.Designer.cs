namespace StericycleCannedResponse
{
    partial class CannedResponseButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canned_response_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // canned_response_button
            // 
            this.canned_response_button.Location = new System.Drawing.Point(0, 3);
            this.canned_response_button.Name = "canned_response_button";
            this.canned_response_button.Size = new System.Drawing.Size(114, 24);
            this.canned_response_button.TabIndex = 0;
            this.canned_response_button.Text = "Canned Responses";
            this.canned_response_button.UseVisualStyleBackColor = true;
            this.canned_response_button.Click += new System.EventHandler(this.canned_response_button_Click);
            // 
            // CannedResponseButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.canned_response_button);
            this.Name = "CannedResponseButton";
            this.Size = new System.Drawing.Size(117, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button canned_response_button;
    }
}
