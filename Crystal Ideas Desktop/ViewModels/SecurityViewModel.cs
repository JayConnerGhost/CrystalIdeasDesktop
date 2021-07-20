using CommunityToolkit.Mvvm.ComponentModel;
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
        }

        public string Title
        {
            get => _model.Title;
            set => SetProperty(_model.Title, value, _model, (u, n) => u.Title = n);
        }
    }
}