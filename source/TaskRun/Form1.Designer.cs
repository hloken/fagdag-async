
namespace TaskRun
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
            this.buttonAwaitableTaskRun = new System.Windows.Forms.Button();
            this.buttonTaskRunOnAwaitable = new System.Windows.Forms.Button();
            this.buttonTaskRun = new System.Windows.Forms.Button();
            this.buttonBlocking = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAwaitableTaskRun
            // 
            this.buttonAwaitableTaskRun.Location = new System.Drawing.Point(294, 12);
            this.buttonAwaitableTaskRun.Name = "buttonAwaitableTaskRun";
            this.buttonAwaitableTaskRun.Size = new System.Drawing.Size(125, 23);
            this.buttonAwaitableTaskRun.TabIndex = 0;
            this.buttonAwaitableTaskRun.Text = "AwaitableTaskRun";
            this.buttonAwaitableTaskRun.UseVisualStyleBackColor = true;
            this.buttonAwaitableTaskRun.Click += new System.EventHandler(this.buttonAwaitableTaskRun_Click);
            // 
            // buttonTaskRunOnAwaitable
            // 
            this.buttonTaskRunOnAwaitable.Location = new System.Drawing.Point(425, 12);
            this.buttonTaskRunOnAwaitable.Name = "buttonTaskRunOnAwaitable";
            this.buttonTaskRunOnAwaitable.Size = new System.Drawing.Size(135, 23);
            this.buttonTaskRunOnAwaitable.TabIndex = 1;
            this.buttonTaskRunOnAwaitable.Text = "TaskRunOnAwaitable";
            this.buttonTaskRunOnAwaitable.UseVisualStyleBackColor = true;
            this.buttonTaskRunOnAwaitable.Click += new System.EventHandler(this.buttonTaskRunOnAwaitable_Click);
            // 
            // buttonTaskRun
            // 
            this.buttonTaskRun.Location = new System.Drawing.Point(153, 12);
            this.buttonTaskRun.Name = "buttonTaskRun";
            this.buttonTaskRun.Size = new System.Drawing.Size(135, 23);
            this.buttonTaskRun.TabIndex = 2;
            this.buttonTaskRun.Text = "TaskRun";
            this.buttonTaskRun.UseVisualStyleBackColor = true;
            this.buttonTaskRun.Click += new System.EventHandler(this.buttonTaskRun_Click);
            // 
            // buttonBlocking
            // 
            this.buttonBlocking.Location = new System.Drawing.Point(12, 12);
            this.buttonBlocking.Name = "buttonBlocking";
            this.buttonBlocking.Size = new System.Drawing.Size(135, 23);
            this.buttonBlocking.TabIndex = 3;
            this.buttonBlocking.Text = "Blocking";
            this.buttonBlocking.UseVisualStyleBackColor = true;
            this.buttonBlocking.Click += new System.EventHandler(this.buttonBlocking_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(773, 288);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonBlocking);
            this.Controls.Add(this.buttonTaskRun);
            this.Controls.Add(this.buttonTaskRunOnAwaitable);
            this.Controls.Add(this.buttonAwaitableTaskRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAwaitableTaskRun;
        private System.Windows.Forms.Button buttonTaskRunOnAwaitable;
        private System.Windows.Forms.Button buttonTaskRun;
        private System.Windows.Forms.Button buttonBlocking;
        private System.Windows.Forms.TextBox textBox1;
    }
}

