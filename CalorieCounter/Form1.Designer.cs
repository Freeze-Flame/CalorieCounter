namespace CalorieCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBanana = new System.Windows.Forms.Button();
            this.btnApple = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnPear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Calories";
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCalories.Location = new System.Drawing.Point(293, 56);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(112, 26);
            this.lblTotalCalories.TabIndex = 1;
            this.lblTotalCalories.Text = "0";
            this.lblTotalCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalCalories.Click += new System.EventHandler(this.lblTotalCalories_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(302, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(302, 294);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPear);
            this.groupBox1.Controls.Add(this.btnOrange);
            this.groupBox1.Controls.Add(this.btnApple);
            this.groupBox1.Controls.Add(this.btnBanana);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 343);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnBanana
            // 
            this.btnBanana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBanana.BackgroundImage")));
            this.btnBanana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBanana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanana.Location = new System.Drawing.Point(6, 19);
            this.btnBanana.Name = "btnBanana";
            this.btnBanana.Size = new System.Drawing.Size(130, 156);
            this.btnBanana.TabIndex = 0;
            this.btnBanana.UseVisualStyleBackColor = true;
            this.btnBanana.Click += new System.EventHandler(this.btnBanana_Click);
            // 
            // btnApple
            // 
            this.btnApple.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApple.BackgroundImage")));
            this.btnApple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApple.Location = new System.Drawing.Point(142, 19);
            this.btnApple.Name = "btnApple";
            this.btnApple.Size = new System.Drawing.Size(127, 156);
            this.btnApple.TabIndex = 0;
            this.btnApple.UseVisualStyleBackColor = true;
            this.btnApple.Click += new System.EventHandler(this.btnApple_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrange.BackgroundImage")));
            this.btnOrange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrange.Location = new System.Drawing.Point(6, 181);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(130, 156);
            this.btnOrange.TabIndex = 0;
            this.btnOrange.UseVisualStyleBackColor = true;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // btnPear
            // 
            this.btnPear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPear.BackgroundImage")));
            this.btnPear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPear.Location = new System.Drawing.Point(142, 181);
            this.btnPear.Name = "btnPear";
            this.btnPear.Size = new System.Drawing.Size(127, 156);
            this.btnPear.TabIndex = 0;
            this.btnPear.UseVisualStyleBackColor = true;
            this.btnPear.Click += new System.EventHandler(this.btnPear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 358);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPear;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnApple;
        private System.Windows.Forms.Button btnBanana;
    }
}

