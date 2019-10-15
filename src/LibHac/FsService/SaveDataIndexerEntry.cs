﻿using System.Runtime.InteropServices;
using LibHac.Fs;

namespace LibHac.FsService
{
    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct SaveDataIndexerEntry
    {
        [FieldOffset(0x00)] public ulong SaveDataId;
        [FieldOffset(0x08)] public ulong Size;
        [FieldOffset(0x10)] public ulong Field10;
        [FieldOffset(0x18)] public SaveDataSpaceId SpaceId;
        [FieldOffset(0x19)] public byte State;
    }
}
