using Crystal_Ideas_Desktop.Models;

namespace Crystal_Ideas_Desktop.ViewModels
{
    public class RegisterProfileViewModel:IRegisterProfileViewModel
    {
        private readonly IRegisterProfileModel _model;

        public  RegisterProfileViewModel(IRegisterProfileModel model)
        {
            _model = model;
        }
    }
}