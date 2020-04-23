using Flunt.Notifications;
using LunaPetShop.Domain.Commands.Contracts;

namespace LunaPetShop.Domain.Commands
{
    public class CommandResult : ICommandResult
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