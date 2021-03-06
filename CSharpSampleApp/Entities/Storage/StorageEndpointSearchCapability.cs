﻿using System.Runtime.Serialization;

namespace CSharpSampleApp.Entities
{
    [System.Xml.Serialization.XmlRoot(Namespace = "")]
    [DataContract(Namespace = "")]
    public class StorageEndpointSearchCapability
    {
        [DataMember(EmitDefaultValue = false, Order = 0)]
        public SearchEndpoint[] Endpoints;
    }
}