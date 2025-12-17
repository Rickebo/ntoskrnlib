#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 208)]
    public partial struct _IRP
    {
        [FieldOffset(0)]
        public short Type;
        [FieldOffset(2)]
        public ushort Size;
        [FieldOffset(4)]
        public ushort AllocationProcessorNumber;
        [FieldOffset(6)]
        public ushort Reserved1;
        [FieldOffset(8)]
        public IntPtr MdlAddress;
        [FieldOffset(16)]
        public uint Flags;
        [FieldOffset(20)]
        public uint Reserved2;
        [FieldOffset(24)]
        public _unnamed_tag_ AssociatedIrp;
        [FieldOffset(32)]
        public _LIST_ENTRY ThreadListEntry;
        [FieldOffset(48)]
        public _IO_STATUS_BLOCK IoStatus;
        [FieldOffset(64)]
        public sbyte RequestorMode;
        [FieldOffset(65)]
        public byte PendingReturned;
        [FieldOffset(66)]
        public sbyte StackCount;
        [FieldOffset(67)]
        public sbyte CurrentLocation;
        [FieldOffset(68)]
        public byte Cancel;
        [FieldOffset(69)]
        public byte CancelIrql;
        [FieldOffset(70)]
        public sbyte ApcEnvironment;
        [FieldOffset(71)]
        public byte AllocationFlags;
        [FieldOffset(72)]
        public IntPtr UserIosb;
        [FieldOffset(72)]
        public IntPtr IoRingContext;
        [FieldOffset(80)]
        public IntPtr UserEvent;
        [FieldOffset(88)]
        public _unnamed_tag_ Overlay;
        [FieldOffset(104)]
        public IntPtr CancelRoutine;
        [FieldOffset(112)]
        public IntPtr UserBuffer;
        [FieldOffset(120)]
        public _unnamed_tag_ Tail;
    }
}