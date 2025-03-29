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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSort = new Button();
            btnSearch = new Button();
            richTextBoxJustToShowArray = new RichTextBox();
            txtSearch = new TextBox();
            lableResult = new Label();
            richTextBoxSortedArray = new RichTextBox();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.Location = new Point(31, 40);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 0;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(141, 39);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // richTextBoxJustToShowArray
            // 
            richTextBoxJustToShowArray.Location = new Point(31, 88);
            richTextBoxJustToShowArray.Name = "richTextBoxJustToShowArray";
            richTextBoxJustToShowArray.ReadOnly = true;
            richTextBoxJustToShowArray.Size = new Size(513, 42);
            richTextBoxJustToShowArray.TabIndex = 2;
            richTextBoxJustToShowArray.Text = resources.GetString("richTextBoxJustToShowArray.Text");
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(233, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 3;
            // 
            // lableResult
            // 
            lableResult.AutoSize = true;
            lableResult.Location = new Point(354, 44);
            lableResult.Name = "lableResult";
            lableResult.Size = new Size(0, 15);
            lableResult.TabIndex = 4;
            // 
            // richTextBoxSortedArray
            // 
            richTextBoxSortedArray.Location = new Point(31, 152);
            richTextBoxSortedArray.Name = "richTextBoxSortedArray";
            richTextBoxSortedArray.ReadOnly = true;
            richTextBoxSortedArray.Size = new Size(513, 42);
            richTextBoxSortedArray.TabIndex = 5;
            richTextBoxSortedArray.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 247);
            Controls.Add(richTextBoxSortedArray);
            Controls.Add(lableResult);
            Controls.Add(txtSearch);
            Controls.Add(richTextBoxJustToShowArray);
            Controls.Add(btnSearch);
            Controls.Add(btnSort);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Binary Search of an Unordered Array";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSort;
        private Button btnSearch;
        private RichTextBox richTextBoxJustToShowArray;
        private TextBox txtSearch;
        private Label lableResult;
        private RichTextBox richTextBoxSortedArray;
    }
}
