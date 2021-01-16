
namespace CSharpOopPractise
{
    partial class AsyncAwaitThread
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
            this.button1 = new System.Windows.Forms.Button();
            this.startThreadBtn = new System.Windows.Forms.Button();
            this.countLbl = new System.Windows.Forms.Label();
            this.startTaskBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // startThreadBtn
            // 
            this.startThreadBtn.Location = new System.Drawing.Point(163, 54);
            this.startThreadBtn.Name = "startThreadBtn";
            this.startThreadBtn.Size = new System.Drawing.Size(218, 65);
            this.startThreadBtn.TabIndex = 1;
            this.startThreadBtn.Text = "Start Thread";
            this.startThreadBtn.UseVisualStyleBackColor = true;
            this.startThreadBtn.Click += new System.EventHandler(this.startThreadBtn_Click);
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLbl.Location = new System.Drawing.Point(160, 182);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(0, 29);
            this.countLbl.TabIndex = 2;
            // 
            // startTaskBtn
            // 
            this.startTaskBtn.Location = new System.Drawing.Point(432, 54);
            this.startTaskBtn.Name = "startTaskBtn";
            this.startTaskBtn.Size = new System.Drawing.Size(227, 64);
            this.startTaskBtn.TabIndex = 3;
            this.startTaskBtn.Text = "Start Task";
            this.startTaskBtn.UseVisualStyleBackColor = true;
            this.startTaskBtn.Click += new System.EventHandler(this.startTaskBtn_ClickAsync);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startTaskBtn);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.startThreadBtn);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button startThreadBtn;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Button startTaskBtn;
    }
}

