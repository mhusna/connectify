using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Domain.Entities.Concrete
{
    public class Message
    {
        public int MessageID { get; set; }
        public string MessageContent { get; set; }
        public DateTime SendTime { get; set; }
        public DateTime ReadTime { get; set; }

        // Mesaji gonderen
        public string SenderID { get; set; }
        public User Sender { get; set; }

        // Mesaji alan
        public string ReceiverID { get; set; }
        public User Receiver { get; set; }
    }
}
