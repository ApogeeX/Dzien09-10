namespace MauiExample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Naciśnięto {count} raz";
            else
                CounterBtn.Text = $"Naciśnięto {count} razy";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}