namespace Paintpro
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.karandash = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.Allcolors = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 320);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // karandash
            // 
            this.karandash.Location = new System.Drawing.Point(0, 12);
            this.karandash.Name = "karandash";
            this.karandash.Size = new System.Drawing.Size(75, 23);
            this.karandash.TabIndex = 1;
            this.karandash.Text = "pen";
            this.karandash.UseVisualStyleBackColor = true;
            this.karandash.Click += new System.EventHandler(this.karandash_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(243, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // circle
            // 
            this.circle.Location = new System.Drawing.Point(162, 12);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(75, 23);
            this.circle.TabIndex = 3;
            this.circle.Text = "circle";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // line
            // 
            this.line.Location = new System.Drawing.Point(81, 12);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(75, 23);
            this.line.TabIndex = 4;
            this.line.Text = "line";
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(307, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(275, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(339, 12);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 7;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Allcolors
            // 
            this.Allcolors.Location = new System.Drawing.Point(387, 56);
            this.Allcolors.Name = "Allcolors";
            this.Allcolors.Size = new System.Drawing.Size(45, 23);
            this.Allcolors.TabIndex = 8;
            this.Allcolors.Text = "allclrs";
            this.Allcolors.UseVisualStyleBackColor = true;
            this.Allcolors.Click += new System.EventHandler(this.Allcolors_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(387, 85);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(45, 23);
            this.save.TabIndex = 9;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(387, 114);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(45, 23);
            this.load.TabIndex = 10;
            this.load.Text = "load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 373);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Allcolors);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.karandash);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button karandash;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button Allcolors;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
    }
}

