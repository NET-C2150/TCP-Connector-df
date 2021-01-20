//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using RosMessageGeneration;

namespace RosMessageTypes.RosTcpEndpoint
{
    public class RosUnityError : Message
    {
        public const string RosMessageName = "ros_tcp_endpoint/RosUnityError";

        public string message;

        public RosUnityError()
        {
            this.message = "";
        }

        public RosUnityError(string message)
        {
            this.message = message;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.Add(SerializeString(this.message));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            var messageStringBytesLength = DeserializeLength(data, offset);
            offset += 4;
            this.message = DeserializeString(data, offset, messageStringBytesLength);
            offset += messageStringBytesLength;

            return offset;
        }

        public override string ToString()
        {
            return "RosUnityError: " +
            "\nmessage: " + message.ToString();
        }
    }
}
