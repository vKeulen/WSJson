using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WSChallenge
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public Message GetRandomMessage()
        {
            Random rnd = new Random();
            List<Message> lstMessage = new List<Message>()
            {
                new Message { ID = 1, message = "Hello, how you doin'"},
                new Message { ID = 2, message = "You know who won the last nights game?"},
                new Message { ID = 3, message = "Thank you :-)"},
                new Message { ID = 4, message = "I'm having a big mac"},
                new Message { ID = 5, message = "No i want a diet coke"},
                new Message { ID = 6, message = "What's happening"},
                new Message { ID = 7, message = "Are you finishing this challenge?"},
                new Message { ID = 8, message = "Bless you"},
                new Message { ID = 9, message = "I have to be there at midnight"},
                new Message { ID = 10, message = "You saw homeland season 2?"},
                new Message { ID = 11, message = "Who are you?"},
                new Message { ID = 12, message = "I'm having breakfast right now"},
                new Message { ID = 13, message = "I need a drink"}
            };
            int r = rnd.Next(lstMessage.Count);
            return lstMessage[r];
        }

        public List<Message> GetMessages()
        {
            List<Message> lstMessage = new List<Message>()
            {
                new Message { ID = 1, message = "Hello, how you doin'"},
                new Message { ID = 2, message = "You know who won the last nights game?"},
                new Message { ID = 3, message = "Thank you :-)"},
                new Message { ID = 4, message = "I'm having a big mac"},
                new Message { ID = 5, message = "No i want a diet coke"},
                new Message { ID = 6, message = "What's happening"},
                new Message { ID = 7, message = "Are you finishing this challenge?"},
                new Message { ID = 8, message = "Bless you"},
                new Message { ID = 9, message = "I have to be there at midnight"},
                new Message { ID = 10, message = "You saw homeland season 2?"},
                new Message { ID = 11, message = "Who are you?"},
                new Message { ID = 12, message = "I'm having breakfast right now"},
                new Message { ID = 13, message = "I need a drink"}
            };
            return lstMessage;
        }
    }
}
