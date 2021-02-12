//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Octomap
{
    public class GetOctomapResponse : Message
    {
        public const string RosMessageName = "octomap_msgs-melodic-devel/GetOctomap";

        public Octomap map;

        public GetOctomapResponse()
        {
            this.map = new Octomap();
        }

        public GetOctomapResponse(Octomap map)
        {
            this.map = map;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(map.SerializationStatements());

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.map.Deserialize(data, offset);

            return offset;
        }

        public override string ToString()
        {
            return "GetOctomapResponse: " +
            "\nmap: " + map.ToString();
        }
    }
}
