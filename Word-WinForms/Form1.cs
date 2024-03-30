using System.Text.RegularExpressions;

namespace Word_WinForms;

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

    string? selectedFontName;
    int selectedSize = 9;
    string? selectedColorName;

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


    private void btnBold_Click(object sender, EventArgs e)
    {

        bool isBold = WordTable.SelectionFont.Bold;
        Font selectionFont = WordTable.SelectionFont;
        if (isBold) btnBold.BackColor = Color.White;
        else btnBold.BackColor = Color.Gray;
        if (!(selectionFont is null))
            WordTable.SelectionFont = new(selectedColorName, selectedSize, selectionFont.Style ^ FontStyle.Bold);

        // ^ bitwise operatorudur Eger Boldursa Oz Styleni qayidayacaq eger Bold deyilse Style Bold elave edecek

    }
    private void BtnUnderline_Click(object sender, EventArgs e)
    {
        bool isUnderline = WordTable.SelectionFont.Underline;
        Font selectionFont = WordTable.SelectionFont;
        if (isUnderline) BtnUnderline.BackColor = Color.White;
        else BtnUnderline.BackColor = Color.Gray;
        if (!(selectionFont is null))
            WordTable.SelectionFont = new(selectedColorName, selectedSize, selectionFont.Style ^ FontStyle.Underline);
    }
    private void BtnItalic_Click(object sender, EventArgs e)
    {
        bool isItalic = WordTable.SelectionFont.Italic;
        Font selectionFont = WordTable.SelectionFont;
        if (isItalic) BtnItalic.BackColor = Color.White;
        else BtnItalic.BackColor = Color.Gray;
        if (!(selectionFont is null))
            WordTable.SelectionFont = new(selectedColorName, selectedSize, selectionFont.Style ^ FontStyle.Italic);
    }

    private void ComboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
    {
        selectedColorName = ComboBoxColor.SelectedItem.ToString();
        Color color = Color.FromName(selectedColorName);
        WordTable.SelectionColor = color;
    }

    private void BtnLoad_Click(object sender, EventArgs e)
    {
        string? fileName = $@"{TxtBoxLoad.Text}";

        if (File.Exists(fileName))
            WordTable.Text = File.ReadAllText(fileName);
        else
            MessageBox.Show("Not Found File", "Eror Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        string? fileName = TxtBoxSave.Text;
        string? regexFileName = @"(\.json|\.txt)$";
        if(Regex.IsMatch(fileName, regexFileName))
        {
            File.WriteAllText(fileName, WordTable.Text);
            MessageBox.Show("File Name is not correct", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
            MessageBox.Show("File Name is not correct", "Eror Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}