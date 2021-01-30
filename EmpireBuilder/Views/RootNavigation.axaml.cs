using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace EmpireBuilder.Views
{
    public class RootNavigation : UserControl
    {
        public RootNavigation()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
