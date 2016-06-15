﻿using System.ServiceModel.Channels;
using System.Xml;


namespace AmazonModule
{
    public class AmazonHeader : MessageHeader
    {
        private readonly string _name;
        private readonly string _value;

        public AmazonHeader(string name, string value)
        {
            _name = name;
            _value = value;
        }

        public override string Name { get { return _name; } }
        public override string Namespace { get { return "http://security.amazonaws.com/doc/2007-01-01/"; } }

        protected override void OnWriteHeaderContents(XmlDictionaryWriter xmlDictionaryWriter, MessageVersion messageVersion)
        {
            xmlDictionaryWriter.WriteString(_value);
        }
    }
}
