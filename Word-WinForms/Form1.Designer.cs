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
            WordTable.Location = new Point(0, 66);
            WordTable.Name = "WordTable";
            WordTable.Size = new Size(800, 383);
            WordTable.TabIndex = 1;
            WordTable.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 2;
            label1.Text = "Font";
            // 
            // ComboBoxFont
            // 
            ComboBoxFont.FormattingEnabled = true;
            ComboBoxFont.Location = new Point(12, 37);
            ComboBoxFont.Name = "ComboBoxFont";
            ComboBoxFont.Size = new Size(121, 23);
            ComboBoxFont.TabIndex = 3;
            ComboBoxFont.Text = "Segoe UI";
            ComboBoxFont.SelectedIndexChanged += ComboBoxFont_SelectedIndexChanged;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSize.Location = new Point(151, 9);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(47, 25);
            lblSize.TabIndex = 4;
            lblSize.Text = "Size";
            // 
            // ComboBoxSize
            // 
            ComboBoxSize.FormattingEnabled = true;
            ComboBoxSize.Location = new Point(142, 37);
            ComboBoxSize.Name = "ComboBoxSize";
            ComboBoxSize.Size = new Size(59, 23);
            ComboBoxSize.TabIndex = 5;
            ComboBoxSize.Text = "9";
            ComboBoxSize.SelectedIndexChanged += ComboBoxSize_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(227, 9);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 6;
            label2.Text = "FontStyle";
            // 
            // btnBold
            // 
            btnBold.BackColor = Color.White;
            btnBold.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBold.ForeColor = Color.Black;
            btnBold.Location = new Point(227, 37);
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(31, 23);
            btnBold.TabIndex = 7;
            btnBold.Text = "B";
            btnBold.TextAlign = ContentAlignment.TopCenter;
            btnBold.UseVisualStyleBackColor = false;
            btnBold.Click += btnB_Click;
            // 
            // BtnUnderline
            // 
            BtnUnderline.BackColor = Color.White;
            BtnUnderline.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            BtnUnderline.Location = new Point(260, 37);
            BtnUnderline.Name = "BtnUnderline";
            BtnUnderline.Size = new Size(31, 23);
            BtnUnderline.TabIndex = 8;
            BtnUnderline.Text = "U";
            BtnUnderline.UseVisualStyleBackColor = false;
            // 
            // BtnItalic
            // 
            BtnItalic.BackColor = Color.White;
            BtnItalic.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            BtnItalic.Location = new Point(292, 37);
            BtnItalic.Name = "BtnItalic";
            BtnItalic.Size = new Size(31, 23);
            BtnItalic.TabIndex = 9;
            BtnItalic.Text = "/";
            BtnItalic.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(372, 9);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 10;
            label3.Text = "Color";
            // 
            // ComboBoxColor
            // 
            ComboBoxColor.FormattingEnabled = true;
            ComboBoxColor.Location = new Point(342, 37);
            ComboBoxColor.Name = "ComboBoxColor";
            ComboBoxColor.Size = new Size(121, 23);
            ComboBoxColor.TabIndex = 11;
            ComboBoxColor.Text = "Black";
            ComboBoxColor.SelectedIndexChanged += ComboBoxColor_SelectedIndexChanged;
            // 
            // TxtBoxLoad
            // 
            TxtBoxLoad.Location = new Point(477, 11);
            TxtBoxLoad.Name = "TxtBoxLoad";
            TxtBoxLoad.Size = new Size(219, 23);
            TxtBoxLoad.TabIndex = 12;
            // 
            // BtnLoad
            // 
            BtnLoad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLoad.Location = new Point(702, 9);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(86, 25);
            BtnLoad.TabIndex = 13;
            BtnLoad.Text = "Load";
            BtnLoad.UseVisualStyleBackColor = true;
            // 
            // TxtBoxSave
            // 
            TxtBoxSave.Location = new Point(477, 37);
            TxtBoxSave.Name = "TxtBoxSave";
            TxtBoxSave.Size = new Size(219, 23);
            TxtBoxSave.TabIndex = 14;
            // 
            // BtnSave
            // 
            BtnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSave.Location = new Point(702, 37);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(86, 25);
            BtnSave.TabIndex = 15;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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