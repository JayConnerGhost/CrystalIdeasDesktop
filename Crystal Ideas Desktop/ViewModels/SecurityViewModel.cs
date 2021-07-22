using System;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Crystal_Ideas_Desktop.Models;

namespace Crystal_Ideas_Desktop.ViewModels
{
    public class SecurityViewModel: ObservableObject,ISecurityViewModel
    {
        private readonly ISecurityModel _model;

        public SecurityViewModel(ISecurityModel model)
        {
            _model = model;
            _model.Title = "populated";
            RegisterProfile = new RelayCommand(CreateProfile);
        }

        public SecurityViewModel() : this(new SecurityModel())
        {
        }

        public void CreateProfile()
        {
            throw new NotImplementedException();
        }

        public ICommand RegisterProfile { get; }

        public string Title
        {
            get => _model.Title;
            set => SetProperty(_model.Title, value, _model, (u, n) => u.Title = n);
        }
    }
}