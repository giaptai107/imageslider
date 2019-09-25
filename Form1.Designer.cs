namespace ImgSliderOfficial
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.mainPic = new System.Windows.Forms.PictureBox();
            this.pre = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pic3
            // 
            this.pic3.ErrorImage = global::ImgSliderOfficial.Properties.Resources._2;
            this.pic3.Image = global::ImgSliderOfficial.Properties.Resources._1;
            this.pic3.Location = new System.Drawing.Point(526, 294);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(142, 109);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 0;
            this.pic3.TabStop = false;
            this.pic3.Click += new System.EventHandler(this.Pic3_Click);
            // 
            // pic2
            // 
            this.pic2.Image = global::ImgSliderOfficial.Properties.Resources._10;
            this.pic2.Location = new System.Drawing.Point(318, 294);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(142, 109);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 0;
            this.pic2.TabStop = false;
            this.pic2.Click += new System.EventHandler(this.Pic2_Click);
            // 
            // pic1
            // 
            this.pic1.ErrorImage = global::ImgSliderOfficial.Properties.Resources._10;
            this.pic1.Image = global::ImgSliderOfficial.Properties.Resources._9;
            this.pic1.Location = new System.Drawing.Point(105, 294);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(142, 109);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.Pic1_Click);
            // 
            // mainPic
            // 
            this.mainPic.Image = global::ImgSliderOfficial.Properties.Resources._10;
            this.mainPic.Location = new System.Drawing.Point(208, 12);
            this.mainPic.Name = "mainPic";
            this.mainPic.Size = new System.Drawing.Size(363, 276);
            this.mainPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPic.TabIndex = 0;
            this.mainPic.TabStop = false;
            this.mainPic.Click += new System.EventHandler(this.MainPic_Click);
            // 
            // pre
            // 
            this.pre.Location = new System.Drawing.Point(105, 143);
            this.pre.Name = "pre";
            this.pre.Size = new System.Drawing.Size(75, 23);
            this.pre.TabIndex = 1;
            this.pre.Text = "Previous";
            this.pre.UseVisualStyleBackColor = true;
            this.pre.Click += new System.EventHandler(this.Pre_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(593, 143);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 1;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.next);
            this.Controls.Add(this.pre);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.mainPic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPic;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button pre;
        private System.Windows.Forms.Button next;
    }
}

