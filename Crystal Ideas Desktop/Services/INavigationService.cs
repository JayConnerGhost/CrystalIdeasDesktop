using System;

namespace Crystal_Ideas_Desktop.Services
{
    public interface INavigationService
    {
        bool NavigateTo(Type objective);
    }
}