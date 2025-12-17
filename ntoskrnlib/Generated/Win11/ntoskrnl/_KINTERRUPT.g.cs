#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 288)]
    public partial struct _KINTERRUPT
    {
        [FieldOffset(0)]
        public short Type;
        [FieldOffset(2)]
        public short Size;
        [FieldOffset(8)]
        public _LIST_ENTRY InterruptListEntry;
        [FieldOffset(24)]
        public IntPtr ServiceRoutine;
        [FieldOffset(32)]
        public IntPtr MessageServiceRoutine;
        [FieldOffset(40)]
        public uint MessageIndex;
        [FieldOffset(48)]
        public IntPtr ServiceContext;
        [FieldOffset(56)]
        public ulong SpinLock;
        [FieldOffset(64)]
        public uint TickCount;
        [FieldOffset(72)]
        public IntPtr ActualLock;
        [FieldOffset(80)]
        public IntPtr DispatchAddress;
        [FieldOffset(88)]
        public uint Vector;
        [FieldOffset(92)]
        public byte Irql;
        [FieldOffset(93)]
        public byte SynchronizeIrql;
        [FieldOffset(94)]
        public byte FloatingSave;
        [FieldOffset(95)]
        public byte Connected;
        [FieldOffset(96)]
        public uint Number;
        [FieldOffset(100)]
        public byte ShareVector;
        [FieldOffset(101)]
        public byte EmulateActiveBoth;
        [FieldOffset(102)]
        public ushort ActiveCount;
        [FieldOffset(104)]
        public int InternalState;
        [FieldOffset(108)]
        public uint Mode;
        [FieldOffset(112)]
        public uint Polarity;
        [FieldOffset(116)]
        public uint ServiceCount;
        [FieldOffset(120)]
        public uint DispatchCount;
        [FieldOffset(128)]
        public IntPtr PassiveEvent;
        [FieldOffset(136)]
        public IntPtr TrapFrame;
        [FieldOffset(144)]
        public IntPtr DisconnectData;
        [FieldOffset(152)]
        public IntPtr ServiceThread;
        [FieldOffset(160)]
        public IntPtr ConnectionData;
        [FieldOffset(168)]
        public IntPtr IntTrackEntry;
        [FieldOffset(176)]
        public _ISRDPCSTATS IsrDpcStats;
        [FieldOffset(272)]
        public IntPtr RedirectObject;
        [FieldOffset(280)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] Padding;
    }
}