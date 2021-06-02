
namespace WhichThreadWinForms
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
            this.buttonbuttonAwaitConfigureAwaitFalse = new System.Windows.Forms.Button();
            this.buttonAwaitConfigureAwaitTrue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonbuttonAwaitConfigureAwaitFalse
            // 
            this.buttonbuttonAwaitConfigureAwaitFalse.Location = new System.Drawing.Point(182, 12);
            this.buttonbuttonAwaitConfigureAwaitFalse.Name = "buttonbuttonAwaitConfigureAwaitFalse";
            this.buttonbuttonAwaitConfigureAwaitFalse.Size = new System.Drawing.Size(164, 23);
            this.buttonbuttonAwaitConfigureAwaitFalse.TabIndex = 0;
            this.buttonbuttonAwaitConfigureAwaitFalse.Text = "Await.ConfigureAwait(false)";
            this.buttonbuttonAwaitConfigureAwaitFalse.UseVisualStyleBackColor = true;
            this.buttonbuttonAwaitConfigureAwaitFalse.Click += new System.EventHandler(this.buttonbuttonAwaitConfigureAwaitFalse_Click);
            // 
            // buttonAwaitConfigureAwaitTrue
            // 
            this.buttonAwaitConfigureAwaitTrue.Location = new System.Drawing.Point(12, 12);
            this.buttonAwaitConfigureAwaitTrue.Name = "buttonAwaitConfigureAwaitTrue";
            this.buttonAwaitConfigureAwaitTrue.Size = new System.Drawing.Size(164, 23);
            this.buttonAwaitConfigureAwaitTrue.TabIndex = 1;
            this.buttonAwaitConfigureAwaitTrue.Text = "Await.ConfigureAwait(true)";
            this.buttonAwaitConfigureAwaitTrue.UseVisualStyleBackColor = true;
            this.buttonAwaitConfigureAwaitTrue.Click += new System.EventHandler(this.buttonAwaitConfigureAwaitTrue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAwaitConfigureAwaitTrue);
            this.Controls.Add(this.buttonbuttonAwaitConfigureAwaitFalse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonbuttonAwaitConfigureAwaitFalse;
        private System.Windows.Forms.Button buttonAwaitConfigureAwaitTrue;
    }
}

