//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Diagnostic
{
    public class AddDiagnosticsRequest : Message
    {
        public const string RosMessageName = "diagnostic_msgs/AddDiagnostics";

        //  This service is used as part of the process for loading analyzers at runtime,
        //  and should be used by a loader script or program, not as a standalone service.
        //  Information about dynamic addition of analyzers can be found at
        //  http://wiki.ros.org/diagnostics/Tutorials/Adding%20Analyzers%20at%20Runtime
        //  The load_namespace parameter defines the namespace where parameters for the
        //  initialization of analyzers in the diagnostic aggregator have been loaded. The
        //  value should be a global name (i.e. /my/name/space), not a relative
        //  (my/name/space) or private (~my/name/space) name. Analyzers will not be added
        //  if a non-global name is used. The call will also fail if the namespace
        //  contains parameters that follow a namespace structure that does not conform to
        //  that expected by the analyzer definitions. See
        //  http://wiki.ros.org/diagnostics/Tutorials/Configuring%20Diagnostic%20Aggregators
        //  and http://wiki.ros.org/diagnostics/Tutorials/Using%20the%20GenericAnalyzer
        //  for examples of the structure of yaml files which are expected to have been
        //  loaded into the namespace.
        public string load_namespace;

        public AddDiagnosticsRequest()
        {
            this.load_namespace = "";
        }

        public AddDiagnosticsRequest(string load_namespace)
        {
            this.load_namespace = load_namespace;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.Add(SerializeString(this.load_namespace));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            var load_namespaceStringBytesLength = DeserializeLength(data, offset);
            offset += 4;
            this.load_namespace = DeserializeString(data, offset, load_namespaceStringBytesLength);
            offset += load_namespaceStringBytesLength;

            return offset;
        }

        public override string ToString()
        {
            return "AddDiagnosticsRequest: " +
            "\nload_namespace: " + load_namespace.ToString();
        }
    }
}
