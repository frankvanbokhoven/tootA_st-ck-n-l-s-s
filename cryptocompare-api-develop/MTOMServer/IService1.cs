// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IService1.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IService1 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.IO;

namespace TestMTOM
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.ServiceModel;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]

    public interface IService1
    {
        [OperationContract]
        Result GetData(string value);  //see: https://social.msdn.microsoft.com/Forums/vstudio/en-US/e647042b-a3c9-4d93-a6f5-6ca583b5babc/send-stream-type-as-a-datamember-in-the-datacontract?forum=wcf

        [OperationContract]
        bool SetMessage(string _message, string _severity, string _component);

        [OperationContract]
        List<Model.tootAMessage> getMessages();



    }

    [DataContract]
    public class Result
    {
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public byte[] FileContent { get; set; }


    };
}
