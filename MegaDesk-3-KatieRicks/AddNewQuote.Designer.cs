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
            this.customerNameForm = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.customerName = new System.Windows.Forms.Label();
            this.Delivery = new System.Windows.Forms.Label();
            this.orderSpeed = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // material
            // 
            this.material.AllowDrop = true;
            this.material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.material.FormattingEnabled = true;
            this.material.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.material.Location = new System.Drawing.Point(20, 200);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(121, 24);
            this.material.TabIndex = 1;
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(20, 107);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(121, 22);
            this.depth.TabIndex = 3;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(20, 62);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(121, 22);
            this.width.TabIndex = 4;
            // 
            // numDrawers
            // 
            this.numDrawers.Location = new System.Drawing.Point(20, 153);
            this.numDrawers.Name = "numDrawers";
            this.numDrawers.Size = new System.Drawing.Size(121, 22);
            this.numDrawers.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Width in Inches";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Depth in Inches";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of Drawers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Material Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Display Quote";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // customerNameForm
            // 
            this.customerNameForm.Location = new System.Drawing.Point(20, 23);
            this.customerNameForm.Name = "customerNameForm";
            this.customerNameForm.Size = new System.Drawing.Size(121, 22);
            this.customerNameForm.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 49);
            this.button2.TabIndex = 13;
            this.button2.Text = "Go Back to Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(160, 23);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(83, 17);
            this.customerName.TabIndex = 14;
            this.customerName.Text = "Enter Name";
            // 
            // Delivery
            // 
            this.Delivery.AutoSize = true;
            this.Delivery.Location = new System.Drawing.Point(160, 250);
            this.Delivery.Name = "Delivery";
            this.Delivery.Size = new System.Drawing.Size(108, 17);
            this.Delivery.TabIndex = 15;
            this.Delivery.Text = "Shipping Speed";
            // 
            // orderSpeed
            // 
            this.orderSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderSpeed.FormattingEnabled = true;
            this.orderSpeed.Location = new System.Drawing.Point(20, 250);
            this.orderSpeed.Name = "orderSpeed";
            this.orderSpeed.Size = new System.Drawing.Size(121, 24);
            this.orderSpeed.TabIndex = 16;
            // 
            // AddNewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 368);
            this.Controls.Add(this.orderSpeed);
            this.Controls.Add(this.Delivery);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.customerNameForm);
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
        private System.Windows.Forms.TextBox customerNameForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label Delivery;
        private System.Windows.Forms.ComboBox orderSpeed;
    }
}