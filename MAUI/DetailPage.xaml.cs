using MAUI.ViewModel;

namespace MAUI
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(DetailViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
