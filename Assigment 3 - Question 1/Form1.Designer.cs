namespace Assigment_3___Question_1
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
            btnSort = new Button();
            btnSearch = new Button();
            richTextBoxArray = new RichTextBox();
            txtSearch = new TextBox();
            lableResult = new Label();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.Location = new Point(150, 115);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 0;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(260, 114);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // richTextBoxArray
            // 
            richTextBoxArray.Location = new Point(150, 163);
            richTextBoxArray.Name = "richTextBoxArray";
            richTextBoxArray.Size = new Size(399, 112);
            richTextBoxArray.TabIndex = 2;
            richTextBoxArray.Text = "";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(352, 115);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 3;
            // 
            // lableResult
            // 
            lableResult.AutoSize = true;
            lableResult.Location = new Point(473, 119);
            lableResult.Name = "lableResult";
            lableResult.Size = new Size(0, 15);
            lableResult.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lableResult);
            Controls.Add(txtSearch);
            Controls.Add(richTextBoxArray);
            Controls.Add(btnSearch);
            Controls.Add(btnSort);
            Name = "Form1";
            Text = "Binary Search of an Unordered Array";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSort;
        private Button btnSearch;
        private RichTextBox richTextBoxArray;
        private TextBox txtSearch;
        private Label lableResult;
    }
}
