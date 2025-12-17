#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _WAIT_CONTEXT_BLOCK
    {
        [FieldOffset(0)]
        public _KDEVICE_QUEUE_ENTRY WaitQueueEntry;
        [FieldOffset(0)]
        public _LIST_ENTRY DmaWaitEntry;
        [FieldOffset(16)]
        public uint NumberOfChannels;
        [FieldOffset(20)]
        public uint SyncCallback;
        [FieldOffset(20)]
        public uint DmaContext;
        [FieldOffset(20)]
        public uint ZeroMapRegisters;
        [FieldOffset(20)]
        public uint Reserved;
        [FieldOffset(20)]
        public uint NumberOfRemapPages;
        [FieldOffset(24)]
        public IntPtr DeviceRoutine;
        [FieldOffset(32)]
        public IntPtr DeviceContext;
        [FieldOffset(40)]
        public uint NumberOfMapRegisters;
        [FieldOffset(48)]
        public IntPtr DeviceObject;
        [FieldOffset(56)]
        public IntPtr CurrentIrp;
        [FieldOffset(64)]
        public IntPtr BufferChainingDpc;
    }
}