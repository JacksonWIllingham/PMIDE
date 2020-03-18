using PMIDE.data.Data.Common;
using System.Collections.Generic;
using MessageContentType = System.String;

namespace PMIDE.data.Data.Task
{
    public class TaskComment
    {
        public User commenter { get; set; }

        private MessageContentType currentMessage { get; set; }
        public MessageContentType message {
            get {
                return currentMessage;
            }
            set {
                if (currentMessage != null) {
                    messageHistory.Add(currentMessage);
                }
                currentMessage = value;
            }
        }
        public ICollection<MessageContentType> messageHistory { get; set; }
    }
}
