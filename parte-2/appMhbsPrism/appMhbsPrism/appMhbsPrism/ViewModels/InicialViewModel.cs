using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace appMhbsPrism.ViewModels
{
    public class InicialViewModel : BindableBase
    {
        public DelegateCommand NavigateCommand { get; set; }
        private readonly INavigationService _navigationService;

        public InicialViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand(Inicial);
        }

        private void Inicial()
        {
            _navigationService.NavigateAsync("Inicial/Navegacao/MainPage");
        }
    }
}
