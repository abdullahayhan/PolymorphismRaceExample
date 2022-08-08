
namespace Polymorphism_yarisOrnegi_
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
            this.lblHuman = new System.Windows.Forms.Label();
            this.lblElf = new System.Windows.Forms.Label();
            this.lblOrc = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblHuman
            // 
            this.lblHuman.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHuman.Location = new System.Drawing.Point(131, 66);
            this.lblHuman.Name = "lblHuman";
            this.lblHuman.Size = new System.Drawing.Size(181, 95);
            this.lblHuman.TabIndex = 0;
            this.lblHuman.Text = "Human";
            this.lblHuman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblElf
            // 
            this.lblElf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblElf.Location = new System.Drawing.Point(131, 337);
            this.lblElf.Name = "lblElf";
            this.lblElf.Size = new System.Drawing.Size(181, 95);
            this.lblElf.TabIndex = 0;
            this.lblElf.Text = "Elf";
            this.lblElf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrc
            // 
            this.lblOrc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOrc.Location = new System.Drawing.Point(131, 201);
            this.lblOrc.Name = "lblOrc";
            this.lblOrc.Size = new System.Drawing.Size(181, 95);
            this.lblOrc.TabIndex = 0;
            this.lblOrc.Text = "Orc";
            this.lblOrc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinish.Location = new System.Drawing.Point(753, 9);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(42, 450);
            this.lblFinish.TabIndex = 0;
            this.lblFinish.Text = "Finish";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(3, 497);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(213, 54);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tm
            // 
            this.tm.Interval = 1000;
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 563);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblOrc);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblElf);
            this.Controls.Add(this.lblHuman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHuman;
        private System.Windows.Forms.Label lblElf;
        private System.Windows.Forms.Label lblOrc;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tm;
    }
}

