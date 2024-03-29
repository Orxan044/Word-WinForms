namespace Word_WinForms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            foreach (FontFamily font in FontFamily.Families)
                ComboBoxFont.Items.Add(font.Name);

            for (int i = 8; i <= 72; i += 2)
                ComboBoxSize.Items.Add(i);

            foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
                if (!color.ToString().StartsWith("Inactive"))
                    ComboBoxColor.Items.Add(color);
        }

        string? selectedColorName;
        int selectedSize;
        string? selectedFontName;

        private void btnB_Click(object sender, EventArgs e)
        {

            bool isBold = WordTable.SelectionFont.Bold;

            if (isBold)
            {
                btnBold.BackColor = Color.White;
                //WordTable.SelectionFont = new(selectedColorName, selectedSize, WordTable.Font.Style);
                //WordTable.SelectionFont = new(selectedColorName, selectedSize, FontStyle.Italic);
                //WordTable.SelectionFont = new(selectedColorName, selectedSize, FontStyle.Underline);
            }
            else
            {
                btnBold.BackColor = Color.Gray;
                WordTable.SelectionFont = new(selectedColorName, selectedSize, FontStyle.Bold);
                //WordTable.SelectionFont = new(selectedColorName, selectedSize, FontStyle.Italic);
                //WordTable.SelectionFont = new(selectedColorName, selectedSize, FontStyle.Underline);
            }


        }

        private void ComboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFontName = ComboBoxFont.SelectedItem.ToString();
            Font newFont = new(selectedFontName, selectedSize);
            WordTable.SelectionFont = newFont;
        }
        private void ComboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSize = Convert.ToInt32(ComboBoxSize.SelectedItem);
            Font newFont = new(selectedFontName, selectedSize);
            WordTable.SelectionFont = newFont;
        }

        private void ComboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedColorName = ComboBoxColor.SelectedItem.ToString();
            Color color = Color.FromName(selectedColorName);
            WordTable.SelectionColor = color;
        }


    }
}