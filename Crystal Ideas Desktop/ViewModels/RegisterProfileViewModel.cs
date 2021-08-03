using CommunityToolkit.Mvvm.ComponentModel;
using Crystal_Ideas_Desktop.Models;

namespace Crystal_Ideas_Desktop.ViewModels
{
    public class RegisterProfileViewModel: ObservableObject, IRegisterProfileViewModel
    {
        private readonly IRegisterProfileModel _model;

        public  RegisterProfileViewModel(IRegisterProfileModel model)
        {
            _model = model;
        }


        public string Email
        {
            get => _model.Email;
            set => SetProperty(_model.Email, value, _model,(u,n)=>u.Email=n);
        }


        public string LastName
        {
            get => _model.LastName;
            set => SetProperty(_model.LastName, value, _model, (u, n) => u.LastName = n);
        }
        public string FirstName
        {
            get => _model.FirstName;
            set => SetProperty(_model.FirstName, value, _model, (u, n) => u.FirstName = n);
        }
        public string Password
        {
            get => _model.Password;
            set => SetProperty(_model.Password, value, _model, (u, n) => u.Password = n);
        }

    }
}