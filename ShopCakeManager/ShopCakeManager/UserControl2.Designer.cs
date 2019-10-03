namespace ShopCakeManager
{
    partial class UserControl2
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
            this.calculator1 = new DevComponents.Editors.Calculator();
            this.SuspendLayout();
            // 
            // calculator1
            // 
            this.calculator1.AutoSize = true;
            this.calculator1.Location = new System.Drawing.Point(3, 0);
            this.calculator1.Name = "calculator1";
            this.calculator1.Size = new System.Drawing.Size(190, 211);
            this.calculator1.Text = "calculator1";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.calculator1);
            this.Name = "UserControl2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.Editors.Calculator calculator1;
    }
}
