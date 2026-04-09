using System.Runtime.InteropServices;

namespace CodeBEhind
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            stackLayout.Add(CreateButton());
        }

        private Button CreateButton()
        {
            Button myButton = new Button()
            {
                Text="כפתור מקוד",
                HeightRequest = 80,
                Margin = new Thickness(15),
                WidthRequest = 150
            };
            return myButton;

        }
		private void Button_Clicked(object sender, EventArgs e)
		{
            Button btn = (Button)sender;
            if (btn == sababa_btn)
            {
                achla_btn.Text = "סבבה";
                title_lbl.TextColor = Colors.Blue;

            }

            else if (btn == achla_btn)
                sababa_btn.Text = "אחלה";
        }

		
	}
}
