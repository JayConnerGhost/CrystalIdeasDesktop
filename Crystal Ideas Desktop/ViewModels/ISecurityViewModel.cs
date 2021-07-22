using System.Windows.Input;

namespace Crystal_Ideas_Desktop.ViewModels
{
    public interface ISecurityViewModel
    {
       string Title { get; set; }
       ICommand RegisterProfile { get; }
    }
}