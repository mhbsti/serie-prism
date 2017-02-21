using Prism.Unity;
using appMhbsPrism.Views;

namespace appMhbsPrism
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("Inicial/Navegacao/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<Inicial>();            
            Container.RegisterTypeForNavigation<Detalhes>();
            Container.RegisterTypeForNavigation<Navegacao>();
        }
    }
}
