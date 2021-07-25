using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crystal_Ideas_Desktop.ViewModels;

namespace Crystal_Ideas_Desktop.Views
{
    public class ProfileRegister
    {
        private readonly IRegisterProfileViewModel _viewModel;

        public ProfileRegister(IRegisterProfileViewModel viewModel)
        {
            _viewModel = viewModel;
        }
    }
}
