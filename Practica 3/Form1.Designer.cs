namespace Practica_3
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
            fifoBox = new ListBox();
            sjfBox = new ListBox();
            fileBox = new ListBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // fifoBox
            // 
            fifoBox.FormattingEnabled = true;
            fifoBox.Location = new Point(434, 38);
            fifoBox.Name = "fifoBox";
            fifoBox.Size = new Size(416, 464);
            fifoBox.TabIndex = 0;
            // 
            // sjfBox
            // 
            sjfBox.FormattingEnabled = true;
            sjfBox.Location = new Point(856, 38);
            sjfBox.Name = "sjfBox";
            sjfBox.Size = new Size(416, 464);
            sjfBox.TabIndex = 1;
            // 
            // fileBox
            // 
            fileBox.FormattingEnabled = true;
            fileBox.Location = new Point(12, 38);
            fileBox.Name = "fileBox";
            fileBox.Size = new Size(416, 464);
            fileBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 3;
            label1.Text = "Procesos";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(434, 15);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 5;
            label3.Text = "First in first out";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(856, 15);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 6;
            label2.Text = "Shortest Job First";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 521);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(fileBox);
            Controls.Add(sjfBox);
            Controls.Add(fifoBox);
            Name = "Form1";
            Text = "Practica 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox fifoBox;
        private ListBox sjfBox;
        private ListBox fileBox;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}
