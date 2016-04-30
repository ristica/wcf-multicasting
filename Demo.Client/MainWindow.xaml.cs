using System.Windows;

namespace Demo.Client
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnDoSomething(object sender, RoutedEventArgs e)
        {
            if (TxtInput.Text.Length < 1)
            {
                MessageBox.Show("No input to send...");
                return;
            }

            var proxy = new Proxies.ProcessClient("DemoProcessRouting");
            this.lblOutput.Content = proxy.DoSomething(this.TxtInput.Text);
            proxy.Close();
        }

        private void BtnBroadcastClicked(object sender, RoutedEventArgs e)
        {
            var proxy = new Proxies.ProcessClient("DemoProcessMulticast");
            proxy.Broadcast();

            // do not put => proxy.Close() here 
            // because if a host goes down the client will throw an exception
            // due to not existing host anymore
        }
    }
}
