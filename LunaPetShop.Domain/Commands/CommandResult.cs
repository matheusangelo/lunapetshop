using System.Collections.Generic;
using Flunt.Notifications;
using Flunt.Validations;
using LunaPetShop.Domain.Commands.Contracts;
using LunaPetShop.Domain.Entities;

namespace LunaPetShop.Domain.Commands
{
    public class CommandResult : Notifiable, ICommandResult
    {
        public CommandResult(string message, bool success, object data)
        {
            Message = message;
            Success = success;
            Data = data;
        }

        public string Message { get;  set; }
        public bool Success { get; set; }
        public object Data { get; set; }

    }
}