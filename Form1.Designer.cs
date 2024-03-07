
namespace pytaniaBadowski4c
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pyt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.odp44 = new System.Windows.Forms.RadioButton();
            this.odp33 = new System.Windows.Forms.RadioButton();
            this.odp22 = new System.Windows.Forms.RadioButton();
            this.odp11 = new System.Windows.Forms.RadioButton();
            this.back = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pyt
            // 
            this.pyt.AutoSize = true;
            this.pyt.Location = new System.Drawing.Point(309, 52);
            this.pyt.Name = "pyt";
            this.pyt.Size = new System.Drawing.Size(38, 15);
            this.pyt.TabIndex = 0;
            this.pyt.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.odp44);
            this.groupBox1.Controls.Add(this.odp33);
            this.groupBox1.Controls.Add(this.odp22);
            this.groupBox1.Controls.Add(this.odp11);
            this.groupBox1.Location = new System.Drawing.Point(127, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // odp44
            // 
            this.odp44.AutoSize = true;
            this.odp44.Location = new System.Drawing.Point(11, 130);
            this.odp44.Name = "odp44";
            this.odp44.Size = new System.Drawing.Size(14, 13);
            this.odp44.TabIndex = 3;
            this.odp44.UseVisualStyleBackColor = true;
            this.odp44.CheckedChanged += new System.EventHandler(this.odp44_CheckedChanged);
            // 
            // odp33
            // 
            this.odp33.AutoSize = true;
            this.odp33.Location = new System.Drawing.Point(11, 94);
            this.odp33.Name = "odp33";
            this.odp33.Size = new System.Drawing.Size(14, 13);
            this.odp33.TabIndex = 2;
            this.odp33.UseVisualStyleBackColor = true;
            this.odp33.CheckedChanged += new System.EventHandler(this.odp33_CheckedChanged);
            // 
            // odp22
            // 
            this.odp22.AutoSize = true;
            this.odp22.Location = new System.Drawing.Point(11, 58);
            this.odp22.Name = "odp22";
            this.odp22.Size = new System.Drawing.Size(14, 13);
            this.odp22.TabIndex = 1;
            this.odp22.UseVisualStyleBackColor = true;
            this.odp22.CheckedChanged += new System.EventHandler(this.odp22_CheckedChanged);
            // 
            // odp11
            // 
            this.odp11.AutoSize = true;
            this.odp11.Location = new System.Drawing.Point(11, 22);
            this.odp11.Name = "odp11";
            this.odp11.Size = new System.Drawing.Size(14, 13);
            this.odp11.TabIndex = 0;
            this.odp11.UseVisualStyleBackColor = true;
            this.odp11.CheckedChanged += new System.EventHandler(this.odp11_CheckedChanged);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(56, 331);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 4;
            this.back.Text = "Poprzednie";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(594, 331);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 5;
            this.next.Text = "Następne";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(688, 370);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(75, 23);
            this.end.TabIndex = 4;
            this.end.Text = "Zakończ";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(387, 352);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(0, 15);
            this.test.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(792, 431);
            this.Controls.Add(this.test);
            this.Controls.Add(this.end);
            this.Controls.Add(this.back);
            this.Controls.Add(this.next);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pyt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pyt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.RadioButton odp44;
        private System.Windows.Forms.RadioButton odp33;
        private System.Windows.Forms.RadioButton odp22;
        private System.Windows.Forms.RadioButton odp11;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Label test;
    }
}

