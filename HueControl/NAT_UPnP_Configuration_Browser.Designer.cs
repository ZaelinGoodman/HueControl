namespace HueControl
{
    partial class NAT_UPnP_Configuration_Browser
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
            this.lbPortMappings = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbPortMappings
            // 
            this.lbPortMappings.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPortMappings.FormattingEnabled = true;
            this.lbPortMappings.ItemHeight = 11;
            this.lbPortMappings.Location = new System.Drawing.Point(12, 12);
            this.lbPortMappings.Name = "lbPortMappings";
            this.lbPortMappings.Size = new System.Drawing.Size(385, 367);
            this.lbPortMappings.TabIndex = 0;
            // 
            // NAT_UPnP_Configuration_Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 422);
            this.Controls.Add(this.lbPortMappings);
            this.Name = "NAT_UPnP_Configuration_Browser";
            this.Text = "NAT_UPnP_Configuration_Browser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPortMappings;
    }
}