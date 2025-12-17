#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 312)]
    public partial struct _CM_KEY_CONTROL_BLOCK
    {
        [FieldOffset(0)]
        public ulong RefCount;
        [FieldOffset(8)]
        public uint ExtFlags;
        [FieldOffset(8)]
        public uint Freed;
        [FieldOffset(8)]
        public uint Discarded;
        [FieldOffset(8)]
        public uint HiveUnloaded;
        [FieldOffset(8)]
        public uint Decommissioned;
        [FieldOffset(8)]
        public uint SpareExtFlag;
        [FieldOffset(8)]
        public uint TotalLevels;
        [FieldOffset(16)]
        public _CM_KEY_HASH KeyHash;
        [FieldOffset(16)]
        public _CM_PATH_HASH ConvKey;
        [FieldOffset(24)]
        public IntPtr NextHash;
        [FieldOffset(32)]
        public IntPtr KeyHive;
        [FieldOffset(40)]
        public uint KeyCell;
        [FieldOffset(48)]
        public _EX_PUSH_LOCK KcbPushlock;
        [FieldOffset(56)]
        public IntPtr Owner;
        [FieldOffset(56)]
        public int SharedCount;
        [FieldOffset(64)]
        public byte DelayedDeref;
        [FieldOffset(64)]
        public byte DelayedClose;
        [FieldOffset(64)]
        public byte Parking;
        [FieldOffset(65)]
        public byte LayerSemantics;
        [FieldOffset(66)]
        public short LayerHeight;
        [FieldOffset(68)]
        public uint Spare1;
        [FieldOffset(72)]
        public IntPtr ParentKcb;
        [FieldOffset(80)]
        public IntPtr NameBlock;
        [FieldOffset(88)]
        public IntPtr CachedSecurity;
        [FieldOffset(96)]
        public _CHILD_LIST ValueList;
        [FieldOffset(104)]
        public IntPtr LinkTarget;
        [FieldOffset(112)]
        public IntPtr IndexHint;
        [FieldOffset(112)]
        public uint HashKey;
        [FieldOffset(112)]
        public uint SubKeyCount;
        [FieldOffset(120)]
        public _LIST_ENTRY KeyBodyListHead;
        [FieldOffset(120)]
        public _LIST_ENTRY ClonedListEntry;
        [FieldOffset(136)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public IntPtr[] KeyBodyArray;
        [FieldOffset(168)]
        public _LARGE_INTEGER KcbLastWriteTime;
        [FieldOffset(176)]
        public ushort KcbMaxNameLen;
        [FieldOffset(178)]
        public ushort KcbMaxValueNameLen;
        [FieldOffset(180)]
        public uint KcbMaxValueDataLen;
        [FieldOffset(184)]
        public uint KcbUserFlags;
        [FieldOffset(184)]
        public uint KcbVirtControlFlags;
        [FieldOffset(184)]
        public uint KcbDebug;
        [FieldOffset(184)]
        public uint Flags;
        [FieldOffset(188)]
        public uint Spare3;
        [FieldOffset(192)]
        public IntPtr LayerInfo;
        [FieldOffset(200)]
        public IntPtr RealKeyName;
        [FieldOffset(208)]
        public _LIST_ENTRY KCBUoWListHead;
        [FieldOffset(224)]
        public _LIST_ENTRY DelayQueueEntry;
        [FieldOffset(224)]
        public IntPtr Stolen;
        [FieldOffset(240)]
        public IntPtr TransKCBOwner;
        [FieldOffset(248)]
        public _CM_INTENT_LOCK KCBLock;
        [FieldOffset(264)]
        public _CM_INTENT_LOCK KeyLock;
        [FieldOffset(280)]
        public _CHILD_LIST TransValueCache;
        [FieldOffset(288)]
        public IntPtr TransValueListOwner;
        [FieldOffset(296)]
        public IntPtr FullKCBName;
        [FieldOffset(296)]
        public ulong FullKCBNameStale;
        [FieldOffset(296)]
        public ulong Reserved;
        [FieldOffset(304)]
        public ulong SequenceNumber;
    }
}