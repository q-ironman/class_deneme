
namespace class_deneme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_start = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.UpDown_horseNum = new System.Windows.Forms.NumericUpDown();
            this.picBox_horse1 = new System.Windows.Forms.PictureBox();
            this.picBox_horse2 = new System.Windows.Forms.PictureBox();
            this.picBox_horse3 = new System.Windows.Forms.PictureBox();
            this.picBox_horse4 = new System.Windows.Forms.PictureBox();
            this.picBox_horse5 = new System.Windows.Forms.PictureBox();
            this.picBox_finishLine = new System.Windows.Forms.PictureBox();
            this.scoreBoard = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_horseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_horse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_horse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_horse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_horse4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_horse5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_finishLine)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(26, 21);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(113, 41);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(26, 68);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(113, 41);
            this.button_reset.TabIndex = 1;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // UpDown_horseNum
            // 
            this.UpDown_horseNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpDown_horseNum.Location = new System.Drawing.Point(169, 21);
            this.UpDown_horseNum.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.UpDown_horseNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.UpDown_horseNum.Name = "UpDown_horseNum";
            this.UpDown_horseNum.Size = new System.Drawing.Size(40, 29);
            this.UpDown_horseNum.TabIndex = 2;
            this.UpDown_horseNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.UpDown_horseNum.ValueChanged += new System.EventHandler(this.UpDown_horseNum_ValueChanged);
            // 
            // picBox_horse1
            // 
            this.picBox_horse1.Image = ((System.Drawing.Image)(resources.GetObject("picBox_horse1.Image")));
            this.picBox_horse1.Location = new System.Drawing.Point(26, 115);
            this.picBox_horse1.Name = "picBox_horse1";
            this.picBox_horse1.Size = new System.Drawing.Size(100, 50);
            this.picBox_horse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_horse1.TabIndex = 3;
            this.picBox_horse1.TabStop = false;
            this.picBox_horse1.Visible = false;
            // 
            // picBox_horse2
            // 
            this.picBox_horse2.Image = ((System.Drawing.Image)(resources.GetObject("picBox_horse2.Image")));
            this.picBox_horse2.Location = new System.Drawing.Point(26, 171);
            this.picBox_horse2.Name = "picBox_horse2";
            this.picBox_horse2.Size = new System.Drawing.Size(100, 50);
            this.picBox_horse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_horse2.TabIndex = 4;
            this.picBox_horse2.TabStop = false;
            this.picBox_horse2.Visible = false;
            // 
            // picBox_horse3
            // 
            this.picBox_horse3.Image = ((System.Drawing.Image)(resources.GetObject("picBox_horse3.Image")));
            this.picBox_horse3.Location = new System.Drawing.Point(26, 227);
            this.picBox_horse3.Name = "picBox_horse3";
            this.picBox_horse3.Size = new System.Drawing.Size(100, 50);
            this.picBox_horse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_horse3.TabIndex = 5;
            this.picBox_horse3.TabStop = false;
            this.picBox_horse3.Visible = false;
            // 
            // picBox_horse4
            // 
            this.picBox_horse4.Image = ((System.Drawing.Image)(resources.GetObject("picBox_horse4.Image")));
            this.picBox_horse4.Location = new System.Drawing.Point(26, 283);
            this.picBox_horse4.Name = "picBox_horse4";
            this.picBox_horse4.Size = new System.Drawing.Size(100, 50);
            this.picBox_horse4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_horse4.TabIndex = 6;
            this.picBox_horse4.TabStop = false;
            this.picBox_horse4.Visible = false;
            // 
            // picBox_horse5
            // 
            this.picBox_horse5.Image = ((System.Drawing.Image)(resources.GetObject("picBox_horse5.Image")));
            this.picBox_horse5.Location = new System.Drawing.Point(26, 339);
            this.picBox_horse5.Name = "picBox_horse5";
            this.picBox_horse5.Size = new System.Drawing.Size(100, 50);
            this.picBox_horse5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_horse5.TabIndex = 7;
            this.picBox_horse5.TabStop = false;
            this.picBox_horse5.Visible = false;
            // 
            // picBox_finishLine
            // 
            this.picBox_finishLine.Image = ((System.Drawing.Image)(resources.GetObject("picBox_finishLine.Image")));
            this.picBox_finishLine.Location = new System.Drawing.Point(630, 115);
            this.picBox_finishLine.Name = "picBox_finishLine";
            this.picBox_finishLine.Size = new System.Drawing.Size(132, 274);
            this.picBox_finishLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_finishLine.TabIndex = 8;
            this.picBox_finishLine.TabStop = false;
            // 
            // scoreBoard
            // 
            this.scoreBoard.Location = new System.Drawing.Point(630, 21);
            this.scoreBoard.Multiline = true;
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.Size = new System.Drawing.Size(132, 88);
            this.scoreBoard.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 400);
            this.Controls.Add(this.scoreBoard);
            this.Controls.Add(this.picBox_finishLine);
            this.Controls.Add(this.picBox_horse5);
            this.Controls.Add(this.picBox_horse4);
            this.Controls.Add(this.picBox_horse3);
            this.Controls.Add(this.picBox_horse2);
            this.Controls.Add(this.picBox_horse1);
            this.Controls.Add(this.UpDown_horseNum);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_start);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_horseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_horse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_horse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_horse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_horse4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_horse5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_finishLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.NumericUpDown UpDown_horseNum;
        private System.Windows.Forms.PictureBox picBox_horse1;
        private System.Windows.Forms.PictureBox picBox_horse2;
        private System.Windows.Forms.PictureBox picBox_horse3;
        private System.Windows.Forms.PictureBox picBox_horse4;
        private System.Windows.Forms.PictureBox picBox_horse5;
        private System.Windows.Forms.PictureBox picBox_finishLine;
        private System.Windows.Forms.TextBox scoreBoard;
        private System.Windows.Forms.Timer timer1;
    }
}

