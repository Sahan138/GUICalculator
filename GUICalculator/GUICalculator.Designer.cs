namespace GUICalculator
{
    partial class GUICalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUICalculator));
            this.lblDisplay = new System.Windows.Forms.Label();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.funcadd = new System.Windows.Forms.Button();
            this.funcsub = new System.Windows.Forms.Button();
            this.funcmul = new System.Windows.Forms.Button();
            this.funcdiv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(12, 9);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(320, 70);
            this.lblDisplay.TabIndex = 0;
            // 
            // textNum1
            // 
            this.textNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNum1.Location = new System.Drawing.Point(120, 111);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(208, 29);
            this.textNum1.TabIndex = 1;
            // 
            // textNum2
            // 
            this.textNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNum2.Location = new System.Drawing.Point(120, 159);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(208, 29);
            this.textNum2.TabIndex = 2;
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.Location = new System.Drawing.Point(15, 114);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(99, 24);
            this.lblnum1.TabIndex = 3;
            this.lblnum1.Text = "Number 1:";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum2.Location = new System.Drawing.Point(15, 161);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(99, 24);
            this.lblnum2.TabIndex = 4;
            this.lblnum2.Text = "Number 2:";
            // 
            // funcadd
            // 
            this.funcadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcadd.Location = new System.Drawing.Point(15, 226);
            this.funcadd.Name = "funcadd";
            this.funcadd.Size = new System.Drawing.Size(70, 70);
            this.funcadd.TabIndex = 5;
            this.funcadd.Text = "+";
            this.funcadd.UseVisualStyleBackColor = true;
            this.funcadd.Click += new System.EventHandler(this.funcadd_Click);
            // 
            // funcsub
            // 
            this.funcsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcsub.Location = new System.Drawing.Point(96, 226);
            this.funcsub.Name = "funcsub";
            this.funcsub.Size = new System.Drawing.Size(70, 70);
            this.funcsub.TabIndex = 6;
            this.funcsub.Text = "-";
            this.funcsub.UseVisualStyleBackColor = true;
            this.funcsub.Click += new System.EventHandler(this.funcsub_Click);
            // 
            // funcmul
            // 
            this.funcmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcmul.Location = new System.Drawing.Point(177, 226);
            this.funcmul.Name = "funcmul";
            this.funcmul.Size = new System.Drawing.Size(70, 70);
            this.funcmul.TabIndex = 7;
            this.funcmul.Text = "*";
            this.funcmul.UseVisualStyleBackColor = true;
            this.funcmul.Click += new System.EventHandler(this.funcmul_Click);
            // 
            // funcdiv
            // 
            this.funcdiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcdiv.Location = new System.Drawing.Point(258, 226);
            this.funcdiv.Name = "funcdiv";
            this.funcdiv.Size = new System.Drawing.Size(70, 70);
            this.funcdiv.TabIndex = 8;
            this.funcdiv.Text = "/";
            this.funcdiv.UseVisualStyleBackColor = true;
            this.funcdiv.Click += new System.EventHandler(this.funcdiv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "GUICalculator v1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUICalculator.Properties.Resources.calborderline_01;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::GUICalculator.Properties.Resources.calborderline_01;
            this.pictureBox1.Location = new System.Drawing.Point(15, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(15, 302);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(313, 31);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // GUICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(344, 381);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.funcdiv);
            this.Controls.Add(this.funcmul);
            this.Controls.Add(this.funcsub);
            this.Controls.Add(this.funcadd);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.lblDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUICalculator";
            this.Text = "GUICalculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Button funcadd;
        private System.Windows.Forms.Button funcsub;
        private System.Windows.Forms.Button funcmul;
        private System.Windows.Forms.Button funcdiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClear;
    }
}

