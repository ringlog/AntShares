﻿using AntShares.IO;
using AntShares.IO.Json;
using System.IO;

namespace AntShares.Core.Scripts
{
    public class Script : ISerializable
    {
        public byte[] StackScript;
        public byte[] RedeemScript;

        void ISerializable.Deserialize(BinaryReader reader)
        {
            StackScript = reader.ReadVarBytes();
            RedeemScript = reader.ReadVarBytes();
        }

        void ISerializable.Serialize(BinaryWriter writer)
        {
            writer.WriteVarBytes(StackScript);
            writer.WriteVarBytes(RedeemScript);
        }

        public JObject ToJson()
        {
            JObject json = new JObject();
            json["stack"] = StackScript.ToHexString();
            json["redeem"] = RedeemScript.ToHexString();
            return json;
        }
    }
}
