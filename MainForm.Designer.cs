
namespace Bubble_Project
{
    partial class MainForm
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
            this.iceCubePanel3 = new IceCubePanel();
            this.iceCubePanel2 = new IceCubePanel();
            this.iceCubePanel1 = new IceCubePanel();
            this.bubblePanel3 = new BubblePanel();
            this.bubblePanel1 = new BubblePanel();
            this.bubblePanel2 = new BubblePanel();
            this.SuspendLayout();
            // 
            // iceCubePanel3
            // 
            this.iceCubePanel3.BackColor = System.Drawing.Color.Transparent;
            this.iceCubePanel3.BC = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iceCubePanel3.Location = new System.Drawing.Point(524, 281);
            this.iceCubePanel3.Name = "iceCubePanel3";
            this.iceCubePanel3.Size = new System.Drawing.Size(250, 250);
            this.iceCubePanel3.TabIndex = 8;
            // 
            // iceCubePanel2
            // 
            this.iceCubePanel2.BackColor = System.Drawing.Color.Transparent;
            this.iceCubePanel2.BC = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.iceCubePanel2.Location = new System.Drawing.Point(268, 281);
            this.iceCubePanel2.Name = "iceCubePanel2";
            this.iceCubePanel2.Size = new System.Drawing.Size(250, 250);
            this.iceCubePanel2.TabIndex = 8;
            // 
            // iceCubePanel1
            // 
            this.iceCubePanel1.BackColor = System.Drawing.Color.Transparent;
            this.iceCubePanel1.BC = System.Drawing.Color.Aqua;
            this.iceCubePanel1.Location = new System.Drawing.Point(12, 281);
            this.iceCubePanel1.Name = "iceCubePanel1";
            this.iceCubePanel1.Size = new System.Drawing.Size(250, 250);
            this.iceCubePanel1.TabIndex = 7;
            // 
            // bubblePanel3
            // 
            this.bubblePanel3.BackColor = System.Drawing.Color.Transparent;
            this.bubblePanel3.BC = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bubblePanel3.Location = new System.Drawing.Point(516, 15);
            this.bubblePanel3.Name = "bubblePanel3";
            this.bubblePanel3.Size = new System.Drawing.Size(250, 250);
            this.bubblePanel3.TabIndex = 6;
            // 
            // bubblePanel1
            // 
            this.bubblePanel1.BackColor = System.Drawing.Color.Transparent;
            this.bubblePanel1.BC = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bubblePanel1.Location = new System.Drawing.Point(12, 12);
            this.bubblePanel1.Name = "bubblePanel1";
            this.bubblePanel1.Size = new System.Drawing.Size(250, 250);
            this.bubblePanel1.TabIndex = 5;
            // 
            // bubblePanel2
            // 
            this.bubblePanel2.BackColor = System.Drawing.Color.Transparent;
            this.bubblePanel2.BC = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bubblePanel2.Location = new System.Drawing.Point(268, 15);
            this.bubblePanel2.Name = "bubblePanel2";
            this.bubblePanel2.Size = new System.Drawing.Size(241, 247);
            this.bubblePanel2.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bubble_Project.Properties.Resources._728px_Personal_color_test;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 554);
            this.Controls.Add(this.iceCubePanel3);
            this.Controls.Add(this.iceCubePanel2);
            this.Controls.Add(this.iceCubePanel1);
            this.Controls.Add(this.bubblePanel3);
            this.Controls.Add(this.bubblePanel1);
            this.Controls.Add(this.bubblePanel2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private BubblePanel bubblePanel3;
        private BubblePanel bubblePanel1;
        private BubblePanel bubblePanel2;
        private IceCubePanel iceCubePanel1;
        private IceCubePanel iceCubePanel2;
        private IceCubePanel iceCubePanel3;
    }
}