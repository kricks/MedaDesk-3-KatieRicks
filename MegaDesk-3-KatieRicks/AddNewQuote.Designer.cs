namespace MegaDesk_3_KatieRicks
{
    partial class AddNewQuote
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
            this.material = new System.Windows.Forms.ComboBox();
            this.depth = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.numDrawers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // material
            // 
            this.material.AllowDrop = true;
            this.material.FormattingEnabled = true;
            this.material.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.material.Location = new System.Drawing.Point(20, 161);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(121, 24);
            this.material.TabIndex = 1;
            this.material.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(20, 74);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(121, 22);
            this.depth.TabIndex = 3;
            this.depth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(20, 24);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(121, 22);
            this.width.TabIndex = 4;
            this.width.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // numDrawers
            // 
            this.numDrawers.Location = new System.Drawing.Point(20, 118);
            this.numDrawers.Name = "numDrawers";
            this.numDrawers.Size = new System.Drawing.Size(121, 22);
            this.numDrawers.TabIndex = 5;
            this.numDrawers.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Width in Inches";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Depth in Inches";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of Drawers";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Material Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Display Quote";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AddNewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDrawers);
            this.Controls.Add(this.width);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.material);
            this.Name = "AddNewQuote";
            this.Text = "AddNewQuote";
            this.Load += new System.EventHandler(this.AddNewQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox material;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox numDrawers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}