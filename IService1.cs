using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WSChallenge
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    public class Message
    {

        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string message { get; set; }

    }

    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate = "/GetRandomMessage",
                ResponseFormat = WebMessageFormat.Json,
                RequestFormat = WebMessageFormat.Json)]
        Message GetRandomMessage();

        [WebGet(UriTemplate = "/GetMessages",
                ResponseFormat = WebMessageFormat.Json,
                RequestFormat = WebMessageFormat.Json)]
        List<Message> GetMessages();

    }
}


