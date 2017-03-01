namespace WindowsFormsApplication3
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
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.bunifuImageButton2 = new ns1.BunifuImageButton();
            this.LoadButton = new ns1.BunifuFlatButton();
            this.SearchButton = new ns1.BunifuMetroTextbox();
            this.LogInEmailLabel = new ns1.BunifuCustomLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(669, 39);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 0;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(726, 11);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(18, 23);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 11;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(755, 11);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(22, 23);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 12;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LoadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LoadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadButton.BorderRadius = 0;
            this.LoadButton.ButtonText = "Load Response";
            this.LoadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadButton.DisabledColor = System.Drawing.Color.Gray;
            this.LoadButton.Font = new System.Drawing.Font("Garamond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.Iconcolor = System.Drawing.Color.Transparent;
            this.LoadButton.Iconimage = null;
            this.LoadButton.Iconimage_right = null;
            this.LoadButton.Iconimage_right_Selected = null;
            this.LoadButton.Iconimage_Selected = null;
            this.LoadButton.IconMarginLeft = 0;
            this.LoadButton.IconMarginRight = 0;
            this.LoadButton.IconRightVisible = true;
            this.LoadButton.IconRightZoom = 0D;
            this.LoadButton.IconVisible = true;
            this.LoadButton.IconZoom = 90D;
            this.LoadButton.IsTab = true;
            this.LoadButton.Location = new System.Drawing.Point(321, 447);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LoadButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LoadButton.OnHoverTextColor = System.Drawing.Color.White;
            this.LoadButton.selected = false;
            this.LoadButton.Size = new System.Drawing.Size(113, 37);
            this.LoadButton.TabIndex = 13;
            this.LoadButton.Text = "Load Response";
            this.LoadButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoadButton.Textcolor = System.Drawing.Color.White;
            this.LoadButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BorderColorFocused = System.Drawing.Color.Silver;
            this.SearchButton.BorderColorIdle = System.Drawing.Color.Silver;
            this.SearchButton.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.SearchButton.BorderThickness = 3;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchButton.Font = new System.Drawing.Font("Garamond", 10F);
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.isPassword = false;
            this.SearchButton.Location = new System.Drawing.Point(194, 351);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(387, 44);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchButton.OnValueChanged += new System.EventHandler(this.SearchButton_OnValueChanged);
            // 
            // LogInEmailLabel
            // 
            this.LogInEmailLabel.AutoSize = true;
            this.LogInEmailLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInEmailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogInEmailLabel.Location = new System.Drawing.Point(318, 329);
            this.LogInEmailLabel.Name = "LogInEmailLabel";
            this.LogInEmailLabel.Size = new System.Drawing.Size(136, 18);
            this.LogInEmailLabel.TabIndex = 15;
            this.LogInEmailLabel.Text = "Search file on server";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(75, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(642, 207);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(788, 562);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.LogInEmailLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.doubleBitmapControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuImageButton bunifuImageButton2;
        private ns1.BunifuFlatButton LoadButton;
        private ns1.BunifuMetroTextbox SearchButton;
        private ns1.BunifuCustomLabel LogInEmailLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

