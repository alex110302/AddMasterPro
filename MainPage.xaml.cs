namespace AddMaster;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        Title = "add Master Pro";
    }

    private void Add_OnClicked(object sender, EventArgs e)
    {
        double dblFirst, dblSecond;
        double.TryParse(txtFirstNumber.Text, out dblFirst);
        double.TryParse(txtSecondNumber.Text, out dblSecond);

        lblDisplay.Text = (dblFirst + dblSecond).ToString();
    }
    
    private void Clear_OnClicked(object sender, EventArgs e)
    {
        txtFirstNumber.Text = string.Empty;
        txtSecondNumber.Text = string.Empty;
        lblDisplay.Text = "0";
    }

}