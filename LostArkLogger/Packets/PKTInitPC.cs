using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class PKTInitPC
    {
        public PKTInitPC(BitReader reader)
        {
            field0 = reader.ReadByte();
            field1 = reader.ReadUInt32();
            field2 = reader.ReadByte();
            field3 = reader.ReadByte();
            field4 = reader.ReadByte();
            field5 = reader.ReadUInt16();
            field6 = reader.ReadByte();
            field7 = reader.ReadUInt32();
            field8 = reader.ReadUInt64();
            field9 = reader.ReadByte();
            field10 = reader.ReadByte();
            field11 = reader.ReadUInt32();
            field12 = reader.ReadUInt16();
            field13 = reader.ReadUInt32();
            field14 = reader.ReadUInt32();
            field15 = reader.ReadUInt32();
            field16 = reader.ReadUInt32();
            field17 = reader.ReadByte();
            field18 = reader.ReadUInt64();
            field19 = reader.ReadUInt32();
            field20 = new Struct43(reader);
            field21 = reader.ReadByte();
            field22 = reader.ReadByte();
            field23 = reader.ReadByte();
            field24 = new Struct44(reader);
            field25 = reader.ReadByte();
            field26 = reader.ReadUInt16();
            field27 = new Struct20(reader);
            field28 = reader.ReadBytes(112);
            Name = reader.ReadString();
            field30 = reader.ReadUInt16();
            field31 = reader.ReadUInt32();
            field32 = new Struct45(reader);
            field33 = reader.ReadByte();
            PlayerId = reader.ReadUInt64();
            field35 = reader.ReadByte();
            field36 = new Struct46(reader);
            field37 = new Struct47(reader);
            field38 = reader.ReadByte();
            field39 = reader.ReadByte();
            field40 = reader.ReadUInt64();
            field41 = reader.ReadBytes(25);
            hasfield42 = reader.ReadByte();
            if (hasfield42 == 1)
                field42 = reader.ReadUInt32();
            field43 = reader.ReadUInt16();
            field44 = reader.ReadByte();
            field45 = new Struct12(reader);
            field46 = reader.ReadUInt16();
            field47 = reader.ReadByte();
            field48 = new Struct15(reader);
            field49 = reader.ReadByte();
            field50 = reader.ReadByte();
            field51 = reader.ReadByte();
            field52 = reader.ReadUInt32();
        }
        public Byte field0; //24
        public UInt32 field1; //28
        public Byte field2; //32
        public Byte field3; //33
        public Byte field4; //34
        public UInt16 field5; //36
        public Byte field6; //38
        public UInt32 field7; //40
        public UInt64 field8; //48
        public Byte field9; //56
        public Byte field10; //57
        public UInt32 field11; //60
        public UInt16 field12; //64
        public UInt32 field13; //68
        public UInt32 field14; //72
        public UInt32 field15; //76
        public UInt32 field16; //80
        public Byte field17; //84
        public UInt64 field18; //88
        public UInt32 field19; //96
        public Struct43 field20; //100
        public Byte field21; //116
        public Byte field22; //117
        public Byte field23; //118
        public Struct44 field24; //119
        public Byte field25; //3241
        public UInt16 field26; //3242
        public Struct20 field27; //64
        public Byte[] field28; //6894
        public String Name; //7006
        public UInt16 field30; //7048
        public UInt32 field31; //7052
        public Struct45 field32; //7056
        public Byte field33; //7108
        public UInt64 PlayerId; //7112
        public Byte field35; //7120
        public Struct46 field36; //7121
        public Struct47 field37; //7228
        public Byte field38; //7278
        public Byte field39; //7279
        public UInt64 field40; //7280
        public Byte[] field41; //7288
        public Byte hasfield42; //7317
        public UInt32 field42; //7313
        public UInt16 field43; //7318
        public Byte field44; //7320
        public Struct12 field45; //7321
        public UInt16 field46; //18204
        public Byte field47; //18206
        public Struct15 field48; //18207
        public Byte field49; //18489
        public Byte field50; //18490
        public Byte field51; //18491
        public UInt32 field52; //18492
    }
}
