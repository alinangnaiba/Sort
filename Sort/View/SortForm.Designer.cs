
namespace Sort
{
    partial class SortForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input3 = new System.Windows.Forms.TextBox();
            this.input4 = new System.Windows.Forms.TextBox();
            this.input5 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sort = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Value 4:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Value 5:";
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(65, 23);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(168, 23);
            this.input1.TabIndex = 5;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(65, 79);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(168, 23);
            this.input2.TabIndex = 6;
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(365, 23);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(168, 23);
            this.input3.TabIndex = 7;
            // 
            // input4
            // 
            this.input4.Location = new System.Drawing.Point(365, 82);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(168, 23);
            this.input4.TabIndex = 8;
            // 
            // input5
            // 
            this.input5.Location = new System.Drawing.Point(210, 140);
            this.input5.Name = "input5";
            this.input5.Size = new System.Drawing.Size(168, 23);
            this.input5.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(239, 379);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(75, 23);
            this.sort.TabIndex = 11;
            this.sort.Text = "Sort";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.output.Location = new System.Drawing.Point(12, 180);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(532, 179);
            this.output.TabIndex = 12;
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 422);
            this.Controls.Add(this.output);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.input5);
            this.Controls.Add(this.input4);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SortForm";
            this.Text = "Sort";
            //this.Load += new System.EventHandler(this.SortForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.TextBox input4;
        private System.Windows.Forms.TextBox input5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.TextBox output;
    }
}

