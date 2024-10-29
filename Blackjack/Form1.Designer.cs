namespace OpenTKHello
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
            this.glControl = new OpenTK.GLControl();
            this.buttonDondur1 = new System.Windows.Forms.Button();
            this.buttonDondur2 = new System.Windows.Forms.Button();
            this.buttonDondur3 = new System.Windows.Forms.Button();
            this.buttonDondur4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // glControl
            // 
            this.glControl.BackColor = System.Drawing.Color.Black;
            this.glControl.Location = new System.Drawing.Point(13, 28);
            this.glControl.Margin = new System.Windows.Forms.Padding(4);
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(550, 550);
            this.glControl.TabIndex = 0;
            this.glControl.VSync = false;
            this.glControl.Load += new System.EventHandler(this.glControl_Load);
            this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_Paint);
            // 
            // buttonDondur1
            // 
            this.buttonDondur1.Location = new System.Drawing.Point(587, 50);
            this.buttonDondur1.Name = "buttonDondur1";
            this.buttonDondur1.Size = new System.Drawing.Size(107, 44);
            this.buttonDondur1.TabIndex = 1;
            this.buttonDondur1.Text = "Döndür 1";
            this.buttonDondur1.UseVisualStyleBackColor = true;
            this.buttonDondur1.Click += new System.EventHandler(this.buttonDondur1_Click);
            // 
            // buttonDondur2
            // 
            this.buttonDondur2.Location = new System.Drawing.Point(587, 128);
            this.buttonDondur2.Name = "buttonDondur2";
            this.buttonDondur2.Size = new System.Drawing.Size(107, 44);
            this.buttonDondur2.TabIndex = 2;
            this.buttonDondur2.Text = "Döndür 2";
            this.buttonDondur2.UseVisualStyleBackColor = true;
            this.buttonDondur2.Click += new System.EventHandler(this.buttonDondur2_Click);
            // 
            // buttonDondur3
            // 
            this.buttonDondur3.Location = new System.Drawing.Point(587, 207);
            this.buttonDondur3.Name = "buttonDondur3";
            this.buttonDondur3.Size = new System.Drawing.Size(107, 44);
            this.buttonDondur3.TabIndex = 3;
            this.buttonDondur3.Text = "Döndür3";
            this.buttonDondur3.UseVisualStyleBackColor = true;
            this.buttonDondur3.Click += new System.EventHandler(this.buttonDondur3_Click);
            // 
            // buttonDonudr4
            // 
            this.buttonDondur4.Location = new System.Drawing.Point(587, 287);
            this.buttonDondur4.Name = "buttonDondur4";
            this.buttonDondur4.Size = new System.Drawing.Size(107, 44);
            this.buttonDondur4.TabIndex = 4;
            this.buttonDondur4.Text = "Döndür 4";
            this.buttonDondur4.UseVisualStyleBackColor = true;
            this.buttonDondur4.Click += new System.EventHandler(this.buttonDondur4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 590);
            this.Controls.Add(this.buttonDondur4);
            this.Controls.Add(this.buttonDondur3);
            this.Controls.Add(this.buttonDondur2);
            this.Controls.Add(this.buttonDondur1);
            this.Controls.Add(this.glControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "OpenGL Örnek";
            this.ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl glControl;
        private System.Windows.Forms.Button buttonDondur1;
        private System.Windows.Forms.Button buttonDondur2;
        private System.Windows.Forms.Button buttonDondur3;
        private System.Windows.Forms.Button buttonDondur4;
    }
}

