namespace VrWebAppliucationWeek2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private void ViewButton_OnClicked(object sender, EventArgs e)
        {
            bool isUsernameEmpty = string.IsNullOrEmpty(userInvoering.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(wwInvoering.Text);

            if (isUsernameEmpty || isPasswordEmpty)
            {
                nameView.Text = "Beide velden moeten worden ingevuld.";
            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}
