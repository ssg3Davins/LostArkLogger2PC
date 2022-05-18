using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class NpcStruct
    {
        public NpcStruct(BitReader reader)
        {
            field0 = reader.ReadUInt64();
            field1 = new Struct12(reader);
            field2 = reader.ReadUInt16();
            hasfield3 = reader.ReadByte();
            if (hasfield3 == 1)
                field3 = reader.ReadByte();
            hasfield4 = reader.ReadByte();
            if (hasfield4 == 1)
                field4 = reader.ReadByte();
            hasfield5 = reader.ReadByte();
            if (hasfield5 == 1)
                field5 = new Struct23(reader);
            field6 = reader.ReadByte();
            NpcType = reader.ReadUInt32();
            field8 = reader.ReadByte();
            hasfield9 = reader.ReadByte();
            if (hasfield9 == 1)
                field9 = reader.ReadByte();
            hasfield10 = reader.ReadByte();
            if (hasfield10 == 1)
                field10 = reader.ReadUInt32();
            hasfield11 = reader.ReadByte();
            if (hasfield11 == 1)
                field11 = reader.ReadUInt32();
            hasfield12 = reader.ReadByte();
            if (hasfield12 == 1)
                field12 = reader.ReadByte();
            field13 = reader.ReadByte();
            hasfield14 = reader.ReadByte();
            if (hasfield14 == 1)
                field14 = reader.ReadByte();
            hasfield15 = reader.ReadByte();
            if (hasfield15 == 1)
                field15 = new Struct24(reader);
            field16 = new Struct15(reader);
            hasfield17 = reader.ReadByte();
            if (hasfield17 == 1)
                field17 = reader.ReadByte();
            hasfield18 = reader.ReadByte();
            if (hasfield18 == 1)
                field18 = reader.ReadUInt32();
            hasfield19 = reader.ReadByte();
            if (hasfield19 == 1)
                field19 = reader.ReadUInt32();
            field20 = reader.ReadByte();
            NpcId = reader.ReadUInt64();
            field22 = reader.ReadUInt16();
            hasfield23 = reader.ReadByte();
            if (hasfield23 == 1)
                field23 = reader.ReadUInt64();
            hasfield24 = reader.ReadByte();
            if (hasfield24 == 1)
                field24 = reader.ReadUInt16();
            field25 = new Struct20(reader);
            field26 = reader.ReadUInt32();
            field27 = reader.ReadByte();
            hasfield28 = reader.ReadByte();
            if (hasfield28 == 1)
                field28 = reader.ReadUInt32();
            hasfield29 = reader.ReadByte();
            if (hasfield29 == 1)
                field29 = reader.ReadUInt16();
            field30 = reader.ReadByte();
            hasfield31 = reader.ReadByte();
            if (hasfield31 == 1)
                field31 = reader.ReadByte();
        }
        public UInt64 field0; //0
        public Struct12 field1; //8
        public UInt16 field2; //10890
        public Byte hasfield3; //10893
        public Byte field3; //10892
        public Byte hasfield4; //10895
        public Byte field4; //10894
        public Byte hasfield5; //10986
        public Struct23 field5; //10896
        public Byte field6; //10987
        public UInt32 NpcType; //10988
        public Byte field8; //10992
        public Byte hasfield9; //10994
        public Byte field9; //10993
        public Byte hasfield10; //10999
        public UInt32 field10; //10995
        public Byte hasfield11; //11004
        public UInt32 field11; //11000
        public Byte hasfield12; //11006
        public Byte field12; //11005
        public Byte field13; //11007
        public Byte hasfield14; //11009
        public Byte field14; //11008
        public Byte hasfield15; //11108
        public Struct24 field15; //11010
        public Struct15 field16; //11109
        public Byte hasfield17; //11392
        public Byte field17; //11391
        public Byte hasfield18; //11397
        public UInt32 field18; //11393
        public Byte hasfield19; //11402
        public UInt32 field19; //11398
        public Byte field20; //11403
        public UInt64 NpcId; //11408
        public UInt16 field22; //11416
        public Byte hasfield23; //11426
        public UInt64 field23; //11418
        public Byte hasfield24; //11429
        public UInt16 field24; //11427
        public Struct20 field25; //64
        public UInt32 field26; //15080
        public Byte field27; //15084
        public Byte hasfield28; //15089
        public UInt32 field28; //15085
        public Byte hasfield29; //15092
        public UInt16 field29; //15090
        public Byte field30; //15093
        public Byte hasfield31; //1
        public Byte field31; //0
    }
}
