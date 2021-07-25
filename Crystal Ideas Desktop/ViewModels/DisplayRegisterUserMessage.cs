using Windows.System;
using Crystal_Ideas_Desktop.Dtos;
using Microsoft.Toolkit.Mvvm.Messaging.Messages;

namespace Crystal_Ideas_Desktop.ViewModels
{
    public class DisplayRegisterUserMessage: ValueChangedMessage<SystemUser>

    {
        public DisplayRegisterUserMessage(SystemUser value) : base(value)
        {
        }
    }
}