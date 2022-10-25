using ChatApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    public class ChatController : Controller
    {
        private static List<KeyValuePair<string, string>> Messages = new List<KeyValuePair<string, string>>();

        
        public IActionResult Show()
        {
            if(Messages.Count < 1)
            {
                return View(new ChatViewModel());  
            }

            ChatViewModel chatModel = new ChatViewModel()
            {
                Messages = Messages.Select(x => new MessageViewModel()
                {
                    Sender = x.Key,
                    MessageText = x.Value
                })
                .ToList()
            };

            return View(chatModel);
        }

        [HttpPost]
        public IActionResult Send(ChatViewModel chat)
        {
            MessageViewModel newMessage = chat.CurrentMessage;
            Messages.Add(new KeyValuePair<string, string>(newMessage.Sender, newMessage.MessageText));

            return RedirectToAction("Show");
        }




    }
}
