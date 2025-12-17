#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public partial struct _HALP_DMA_ADAPTER_OBJECT
    {
        [FieldOffset(0)]
        public _DMA_ADAPTER DmaHeader;
        [FieldOffset(16)]
        public uint Signature;
        [FieldOffset(24)]
        public IntPtr ContiguousMapRegisters;
        [FieldOffset(32)]
        public IntPtr ScatterBufferListHead;
        [FieldOffset(40)]
        public uint NumberOfFreeScatterBuffers;
        [FieldOffset(48)]
        public IntPtr ContiguousTranslations;
        [FieldOffset(56)]
        public IntPtr ScatterTranslations;
        [FieldOffset(64)]
        public _HALP_DMA_TRANSLATION_BUFFER_POSITION ContiguousTranslationEnd;
        [FieldOffset(80)]
        public _HALP_DMA_TRANSLATION_BUFFER_POSITION ScatterTranslationEnd;
        [FieldOffset(96)]
        public _unnamed_tag_ CrashDump;
        [FieldOffset(128)]
        public ulong SpinLock;
        [FieldOffset(136)]
        public ulong GrowLock;
        [FieldOffset(144)]
        public _LARGE_INTEGER MaximumPhysicalAddress;
        [FieldOffset(152)]
        public byte IsMasterAdapter;
        [FieldOffset(153)]
        public byte DmaCanCross64K;
        [FieldOffset(156)]
        public uint LibraryVersion;
    }
}