namespace SpringFeildReactor
{
    partial class SpringFeildReactor
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.ReactorHeader1 = new System.Windows.Forms.Label();
            this.ReactorHeader2 = new System.Windows.Forms.Label();
            this.reactor1StateLable = new System.Windows.Forms.Label();
            this.reactor2StateLable = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Kabel Ult BT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(141, 34);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(463, 48);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nuclear Reactor Control";
            this.titleLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ReactorHeader1
            // 
            this.ReactorHeader1.AutoSize = true;
            this.ReactorHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReactorHeader1.Location = new System.Drawing.Point(144, 224);
            this.ReactorHeader1.Name = "ReactorHeader1";
            this.ReactorHeader1.Size = new System.Drawing.Size(108, 26);
            this.ReactorHeader1.TabIndex = 1;
            this.ReactorHeader1.Text = "Reactor1";
            // 
            // ReactorHeader2
            // 
            this.ReactorHeader2.AutoSize = true;
            this.ReactorHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReactorHeader2.Location = new System.Drawing.Point(496, 224);
            this.ReactorHeader2.Name = "ReactorHeader2";
            this.ReactorHeader2.Size = new System.Drawing.Size(108, 26);
            this.ReactorHeader2.TabIndex = 2;
            this.ReactorHeader2.Text = "Reactor2";
            // 
            // reactor1StateLable
            // 
            this.reactor1StateLable.BackColor = System.Drawing.Color.Green;
            this.reactor1StateLable.Location = new System.Drawing.Point(125, 260);
            this.reactor1StateLable.Name = "reactor1StateLable";
            this.reactor1StateLable.Size = new System.Drawing.Size(141, 131);
            this.reactor1StateLable.TabIndex = 3;
            // 
            // reactor2StateLable
            // 
            this.reactor2StateLable.BackColor = System.Drawing.Color.Green;
            this.reactor2StateLable.Location = new System.Drawing.Point(479, 260);
            this.reactor2StateLable.Name = "reactor2StateLable";
            this.reactor2StateLable.Size = new System.Drawing.Size(141, 131);
            this.reactor2StateLable.TabIndex = 4;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Gold;
            this.start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Millenium BdEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(334, 310);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 81);
            this.start.TabIndex = 5;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.Start_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.Font = new System.Drawing.Font("Machine BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OutputLabel.Location = new System.Drawing.Point(299, 415);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(151, 30);
            this.OutputLabel.TabIndex = 6;
            this.OutputLabel.Text = "Reactors Stable";
            this.OutputLabel.Click += new System.EventHandler(this.OutputLabel_Click);
            // 
            // SpringFeildReactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.start);
            this.Controls.Add(this.reactor2StateLable);
            this.Controls.Add(this.reactor1StateLable);
            this.Controls.Add(this.ReactorHeader2);
            this.Controls.Add(this.ReactorHeader1);
            this.Controls.Add(this.titleLabel);
            this.Name = "SpringFeildReactor";
            this.Text = "ControlPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label ReactorHeader1;
        private System.Windows.Forms.Label ReactorHeader2;
        private System.Windows.Forms.Label reactor1StateLable;
        private System.Windows.Forms.Label reactor2StateLable;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label OutputLabel;
    }
}

