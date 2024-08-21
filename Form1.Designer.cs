
namespace Bubble_Project
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
            this.bubblePanel2 = new BubblePanel();
            this.bubblePanel1 = new BubblePanel();
            this.SuspendLayout();
            // 
            // bubblePanel2
            // 
            this.bubblePanel2.Location = new System.Drawing.Point(410, 159);
            this.bubblePanel2.Name = "bubblePanel2";
            this.bubblePanel2.Size = new System.Drawing.Size(248, 245);
            this.bubblePanel2.TabIndex = 1;
            // 
            // bubblePanel1
            // 
            this.bubblePanel1.Location = new System.Drawing.Point(31, 1);
            this.bubblePanel1.Name = "bubblePanel1";
            this.bubblePanel1.Size = new System.Drawing.Size(313, 330);
            this.bubblePanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bubblePanel2);
            this.Controls.Add(this.bubblePanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private BubblePanel bubblePanel1;
        private BubblePanel bubblePanel2;
    }
}

