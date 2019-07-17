namespace ConvertCSVToHashTable
{
    partial class ConvertCSVToDictionary
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
            this.label1 = new System.Windows.Forms.Label();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.PreviewButton = new System.Windows.Forms.Button();
            this.CarListView = new System.Windows.Forms.ListView();
            this.CarMakeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CarModelColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CarYearColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConvertButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.MakeDictionaryTextBox = new System.Windows.Forms.TextBox();
            this.ModelDictionaryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select File: ";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(120, 17);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(455, 34);
            this.FilePathTextBox.TabIndex = 1;
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(525, 57);
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.Size = new System.Drawing.Size(108, 34);
            this.PreviewButton.TabIndex = 3;
            this.PreviewButton.Text = "Preview";
            this.PreviewButton.UseVisualStyleBackColor = true;
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // CarListView
            // 
            this.CarListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CarMakeColumnHeader,
            this.CarModelColumnHeader,
            this.CarYearColumnHeader});
            this.CarListView.Location = new System.Drawing.Point(23, 106);
            this.CarListView.Name = "CarListView";
            this.CarListView.Size = new System.Drawing.Size(610, 465);
            this.CarListView.TabIndex = 4;
            this.CarListView.UseCompatibleStateImageBehavior = false;
            this.CarListView.View = System.Windows.Forms.View.Details;
            // 
            // CarMakeColumnHeader
            // 
            this.CarMakeColumnHeader.Text = "Make";
            this.CarMakeColumnHeader.Width = 200;
            // 
            // CarModelColumnHeader
            // 
            this.CarModelColumnHeader.Text = "Model";
            this.CarModelColumnHeader.Width = 200;
            // 
            // CarYearColumnHeader
            // 
            this.CarYearColumnHeader.Text = "Year";
            this.CarYearColumnHeader.Width = 200;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(399, 587);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(108, 34);
            this.ConvertButton.TabIndex = 5;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(523, 587);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(108, 34);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(581, 16);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(52, 34);
            this.ImportButton.TabIndex = 9;
            this.ImportButton.Text = "...";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // MakeDictionaryTextBox
            // 
            this.MakeDictionaryTextBox.Location = new System.Drawing.Point(640, 106);
            this.MakeDictionaryTextBox.Multiline = true;
            this.MakeDictionaryTextBox.Name = "MakeDictionaryTextBox";
            this.MakeDictionaryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MakeDictionaryTextBox.Size = new System.Drawing.Size(274, 465);
            this.MakeDictionaryTextBox.TabIndex = 10;
            // 
            // ModelDictionaryTextBox
            // 
            this.ModelDictionaryTextBox.Location = new System.Drawing.Point(938, 106);
            this.ModelDictionaryTextBox.Multiline = true;
            this.ModelDictionaryTextBox.Name = "ModelDictionaryTextBox";
            this.ModelDictionaryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ModelDictionaryTextBox.Size = new System.Drawing.Size(280, 465);
            this.ModelDictionaryTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(738, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "MAKE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1043, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "MODEL";
            // 
            // ConvertCSVToDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 633);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModelDictionaryTextBox);
            this.Controls.Add(this.MakeDictionaryTextBox);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.CarListView);
            this.Controls.Add(this.PreviewButton);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConvertCSVToDictionary";
            this.Text = "Convert CSV file to Dictionary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Button PreviewButton;
        private System.Windows.Forms.ListView CarListView;
        private System.Windows.Forms.ColumnHeader CarMakeColumnHeader;
        private System.Windows.Forms.ColumnHeader CarModelColumnHeader;
        private System.Windows.Forms.ColumnHeader CarYearColumnHeader;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.TextBox MakeDictionaryTextBox;
        private System.Windows.Forms.TextBox ModelDictionaryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

