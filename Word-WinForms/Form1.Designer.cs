namespace Word_WinForms
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
            WordTable = new RichTextBox();
            label1 = new Label();
            ComboBoxFont = new ComboBox();
            lblSize = new Label();
            ComboBoxSize = new ComboBox();
            label2 = new Label();
            btnBold = new Button();
            BtnUnderline = new Button();
            BtnItalic = new Button();
            label3 = new Label();
            ComboBoxColor = new ComboBox();
            TxtBoxLoad = new TextBox();
            BtnLoad = new Button();
            TxtBoxSave = new TextBox();
            BtnSave = new Button();
            SuspendLayout();
            // 
            // WordTable
            // 
            WordTable.Location = new Point(0, 88);
            WordTable.Margin = new Padding(3, 4, 3, 4);
            WordTable.Name = "WordTable";
            WordTable.Size = new Size(914, 509);
            WordTable.TabIndex = 1;
            WordTable.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 12);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 2;
            label1.Text = "Font";
            // 
            // ComboBoxFont
            // 
            ComboBoxFont.FormattingEnabled = true;
            ComboBoxFont.Location = new Point(14, 49);
            ComboBoxFont.Margin = new Padding(3, 4, 3, 4);
            ComboBoxFont.Name = "ComboBoxFont";
            ComboBoxFont.Size = new Size(138, 28);
            ComboBoxFont.TabIndex = 3;
            ComboBoxFont.Text = "Segoe UI";
            ComboBoxFont.SelectedIndexChanged += ComboBoxFont_SelectedIndexChanged;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSize.Location = new Point(173, 12);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(59, 32);
            lblSize.TabIndex = 4;
            lblSize.Text = "Size";
            // 
            // ComboBoxSize
            // 
            ComboBoxSize.FormattingEnabled = true;
            ComboBoxSize.Location = new Point(162, 49);
            ComboBoxSize.Margin = new Padding(3, 4, 3, 4);
            ComboBoxSize.Name = "ComboBoxSize";
            ComboBoxSize.Size = new Size(67, 28);
            ComboBoxSize.TabIndex = 5;
            ComboBoxSize.Text = "9";
            ComboBoxSize.SelectedIndexChanged += ComboBoxSize_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(259, 12);
            label2.Name = "label2";
            label2.Size = new Size(119, 32);
            label2.TabIndex = 6;
            label2.Text = "FontStyle";
            // 
            // btnBold
            // 
            btnBold.BackColor = Color.White;
            btnBold.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBold.ForeColor = Color.Black;
            btnBold.Location = new Point(259, 49);
            btnBold.Margin = new Padding(3, 4, 3, 4);
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(35, 31);
            btnBold.TabIndex = 7;
            btnBold.Text = "B";
            btnBold.TextAlign = ContentAlignment.TopCenter;
            btnBold.UseVisualStyleBackColor = false;
            btnBold.Click += btnBold_Click;
            // 
            // BtnUnderline
            // 
            BtnUnderline.BackColor = Color.White;
            BtnUnderline.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            BtnUnderline.Location = new Point(297, 49);
            BtnUnderline.Margin = new Padding(3, 4, 3, 4);
            BtnUnderline.Name = "BtnUnderline";
            BtnUnderline.Size = new Size(35, 31);
            BtnUnderline.TabIndex = 8;
            BtnUnderline.Text = "U";
            BtnUnderline.UseVisualStyleBackColor = false;
            BtnUnderline.Click += BtnUnderline_Click;
            // 
            // BtnItalic
            // 
            BtnItalic.BackColor = Color.White;
            BtnItalic.Font = new Font("Consolas", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            BtnItalic.Location = new Point(334, 49);
            BtnItalic.Margin = new Padding(3, 4, 3, 4);
            BtnItalic.Name = "BtnItalic";
            BtnItalic.Size = new Size(35, 31);
            BtnItalic.TabIndex = 9;
            BtnItalic.Text = "|";
            BtnItalic.UseVisualStyleBackColor = false;
            BtnItalic.Click += BtnItalic_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(425, 12);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 10;
            label3.Text = "Color";
            // 
            // ComboBoxColor
            // 
            ComboBoxColor.FormattingEnabled = true;
            ComboBoxColor.Location = new Point(391, 49);
            ComboBoxColor.Margin = new Padding(3, 4, 3, 4);
            ComboBoxColor.Name = "ComboBoxColor";
            ComboBoxColor.Size = new Size(138, 28);
            ComboBoxColor.TabIndex = 11;
            ComboBoxColor.Text = "Black";
            ComboBoxColor.SelectedIndexChanged += ComboBoxColor_SelectedIndexChanged;
            // 
            // TxtBoxLoad
            // 
            TxtBoxLoad.Location = new Point(545, 15);
            TxtBoxLoad.Margin = new Padding(3, 4, 3, 4);
            TxtBoxLoad.Name = "TxtBoxLoad";
            TxtBoxLoad.PlaceholderText = "Enter Name and load file";
            TxtBoxLoad.Size = new Size(250, 27);
            TxtBoxLoad.TabIndex = 12;
            // 
            // BtnLoad
            // 
            BtnLoad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLoad.Location = new Point(802, 12);
            BtnLoad.Margin = new Padding(3, 4, 3, 4);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(98, 33);
            BtnLoad.TabIndex = 13;
            BtnLoad.Text = "Load";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // TxtBoxSave
            // 
            TxtBoxSave.Location = new Point(545, 49);
            TxtBoxSave.Margin = new Padding(3, 4, 3, 4);
            TxtBoxSave.Name = "TxtBoxSave";
            TxtBoxSave.PlaceholderText = "Tap to enter name (.txt .json)";
            TxtBoxSave.Size = new Size(250, 27);
            TxtBoxSave.TabIndex = 14;
            // 
            // BtnSave
            // 
            BtnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSave.Location = new Point(802, 49);
            BtnSave.Margin = new Padding(3, 4, 3, 4);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(98, 33);
            BtnSave.TabIndex = 15;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(BtnSave);
            Controls.Add(TxtBoxSave);
            Controls.Add(BtnLoad);
            Controls.Add(TxtBoxLoad);
            Controls.Add(ComboBoxColor);
            Controls.Add(label3);
            Controls.Add(BtnItalic);
            Controls.Add(BtnUnderline);
            Controls.Add(btnBold);
            Controls.Add(label2);
            Controls.Add(ComboBoxSize);
            Controls.Add(lblSize);
            Controls.Add(ComboBoxFont);
            Controls.Add(label1);
            Controls.Add(WordTable);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Word";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox WordTable;
        private Label label1;
        private ComboBox ComboBoxFont;
        private Label lblSize;
        private ComboBox ComboBoxSize;
        private Label label2;
        private Button btnBold;
        private Button BtnUnderline;
        private Button BtnItalic;
        private Label label3;
        private ComboBox ComboBoxColor;
        private TextBox TxtBoxLoad;
        private Button BtnLoad;
        private TextBox TxtBoxSave;
        private Button BtnSave;
    }
}