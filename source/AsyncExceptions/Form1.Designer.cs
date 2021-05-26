
namespace AsyncExceptions
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
            this.buttonNormalException = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAsyncException = new System.Windows.Forms.Button();
            this.buttonTaskRunException = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonTaskRunAsyncException = new System.Windows.Forms.Button();
            this.buttonMultipleAsyncExceptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNormalException
            // 
            this.buttonNormalException.Location = new System.Drawing.Point(15, 12);
            this.buttonNormalException.Name = "buttonNormalException";
            this.buttonNormalException.Size = new System.Drawing.Size(115, 23);
            this.buttonNormalException.TabIndex = 0;
            this.buttonNormalException.Text = "NormalException";
            this.buttonNormalException.UseVisualStyleBackColor = true;
            this.buttonNormalException.Click += new System.EventHandler(this.buttonNormalException_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 134);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(773, 288);
            this.textBox1.TabIndex = 1;
            // 
            // buttonAsyncException
            // 
            this.buttonAsyncException.Location = new System.Drawing.Point(136, 12);
            this.buttonAsyncException.Name = "buttonAsyncException";
            this.buttonAsyncException.Size = new System.Drawing.Size(152, 23);
            this.buttonAsyncException.TabIndex = 2;
            this.buttonAsyncException.Text = "AsyncException";
            this.buttonAsyncException.UseVisualStyleBackColor = true;
            this.buttonAsyncException.Click += new System.EventHandler(this.buttonAsyncException_Click);
            // 
            // buttonTaskRunException
            // 
            this.buttonTaskRunException.Location = new System.Drawing.Point(15, 41);
            this.buttonTaskRunException.Name = "buttonTaskRunException";
            this.buttonTaskRunException.Size = new System.Drawing.Size(115, 23);
            this.buttonTaskRunException.TabIndex = 3;
            this.buttonTaskRunException.Text = "TaskRunException";
            this.buttonTaskRunException.UseVisualStyleBackColor = true;
            this.buttonTaskRunException.Click += new System.EventHandler(this.buttonTaskRunException_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(327, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "AsyncTaskRunAsyncException";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonAsyncTaskRunAsyncException_Click);
            // 
            // buttonTaskRunAsyncException
            // 
            this.buttonTaskRunAsyncException.Location = new System.Drawing.Point(136, 41);
            this.buttonTaskRunAsyncException.Name = "buttonTaskRunAsyncException";
            this.buttonTaskRunAsyncException.Size = new System.Drawing.Size(185, 23);
            this.buttonTaskRunAsyncException.TabIndex = 5;
            this.buttonTaskRunAsyncException.Text = "TaskRunAsyncException";
            this.buttonTaskRunAsyncException.UseVisualStyleBackColor = true;
            this.buttonTaskRunAsyncException.Click += new System.EventHandler(this.buttonTaskRunAsyncException_Click);
            // 
            // buttonMultipleAsyncExceptions
            // 
            this.buttonMultipleAsyncExceptions.Location = new System.Drawing.Point(327, 12);
            this.buttonMultipleAsyncExceptions.Name = "buttonMultipleAsyncExceptions";
            this.buttonMultipleAsyncExceptions.Size = new System.Drawing.Size(185, 23);
            this.buttonMultipleAsyncExceptions.TabIndex = 6;
            this.buttonMultipleAsyncExceptions.Text = "MultipleAsyncExceptions";
            this.buttonMultipleAsyncExceptions.UseVisualStyleBackColor = true;
            this.buttonMultipleAsyncExceptions.Click += new System.EventHandler(this.buttonMultipleAsyncExceptions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.buttonMultipleAsyncExceptions);
            this.Controls.Add(this.buttonTaskRunAsyncException);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonTaskRunException);
            this.Controls.Add(this.buttonAsyncException);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonNormalException);
            this.Name = "Form1";
            this.Text = "TaskRunAsyncException";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNormalException;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAsyncException;
        private System.Windows.Forms.Button buttonTaskRunException;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonTaskRunAsyncException;
        private System.Windows.Forms.Button buttonMultipleAsyncExceptions;
    }
}

