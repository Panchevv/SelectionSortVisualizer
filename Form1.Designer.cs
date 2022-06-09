
namespace Selection_Sort_Visualizer
{
    partial class SelectionForm
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
            this.textBoxNums = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelSwap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNums
            // 
            this.textBoxNums.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNums.Location = new System.Drawing.Point(36, 20);
            this.textBoxNums.Name = "textBoxNums";
            this.textBoxNums.Size = new System.Drawing.Size(1095, 27);
            this.textBoxNums.TabIndex = 1;
            this.textBoxNums.Text = "29, 72, 98, 13, 87, 66, 52, 51, 36";
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(1171, 12);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(176, 42);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelSwap
            // 
            this.labelSwap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSwap.Location = new System.Drawing.Point(513, 86);
            this.labelSwap.Name = "labelSwap";
            this.labelSwap.Size = new System.Drawing.Size(291, 50);
            this.labelSwap.TabIndex = 3;
            this.labelSwap.Text = "Swap";
            this.labelSwap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSwap.Visible = false;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 450);
            this.Controls.Add(this.labelSwap);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBoxNums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection Sort Visualizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNums;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelSwap;
    }
}

