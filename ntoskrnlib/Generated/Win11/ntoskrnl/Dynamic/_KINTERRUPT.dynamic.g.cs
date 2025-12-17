using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KINTERRUPT")]
    public sealed class _KINTERRUPT : DynamicStructure
    {
        public short Type { get; }
        public short Size { get; }
        public _LIST_ENTRY InterruptListEntry { get; }
        public IntPtr ServiceRoutine { get; }
        public IntPtr MessageServiceRoutine { get; }
        public uint MessageIndex { get; }
        public IntPtr ServiceContext { get; }
        public ulong SpinLock { get; }
        public uint TickCount { get; }
        public IntPtr ActualLock { get; }
        public IntPtr DispatchAddress { get; }
        public uint Vector { get; }
        public byte Irql { get; }
        public byte SynchronizeIrql { get; }
        public byte FloatingSave { get; }
        public byte Connected { get; }
        public uint Number { get; }
        public byte ShareVector { get; }
        public byte EmulateActiveBoth { get; }
        public ushort ActiveCount { get; }
        public int InternalState { get; }
        public uint Mode { get; }
        public uint Polarity { get; }
        public uint ServiceCount { get; }
        public uint DispatchCount { get; }
        public IntPtr PassiveEvent { get; }
        public IntPtr TrapFrame { get; }
        public IntPtr DisconnectData { get; }
        public IntPtr ServiceThread { get; }
        public IntPtr ConnectionData { get; }
        public IntPtr IntTrackEntry { get; }
        public _ISRDPCSTATS IsrDpcStats { get; }
        public IntPtr RedirectObject { get; }
        public byte[] Padding { get; }

        public _KINTERRUPT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KINTERRUPT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KINTERRUPT.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KINTERRUPT.Size),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_KINTERRUPT.InterruptListEntry),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KINTERRUPT.ServiceRoutine),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KINTERRUPT.MessageServiceRoutine),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KINTERRUPT.MessageIndex),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KINTERRUPT.ServiceContext),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KINTERRUPT.SpinLock),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KINTERRUPT.TickCount),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KINTERRUPT.ActualLock),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_KINTERRUPT.DispatchAddress),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_KINTERRUPT.Vector),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_KINTERRUPT.Irql),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_KINTERRUPT.SynchronizeIrql),
                    new ulong[]
                    {
                        93UL
                    }
                },
                {
                    nameof(_KINTERRUPT.FloatingSave),
                    new ulong[]
                    {
                        94UL
                    }
                },
                {
                    nameof(_KINTERRUPT.Connected),
                    new ulong[]
                    {
                        95UL
                    }
                },
                {
                    nameof(_KINTERRUPT.Number),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_KINTERRUPT.ShareVector),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_KINTERRUPT.EmulateActiveBoth),
                    new ulong[]
                    {
                        101UL
                    }
                },
                {
                    nameof(_KINTERRUPT.ActiveCount),
                    new ulong[]
                    {
                        102UL
                    }
                },
                {
                    nameof(_KINTERRUPT.InternalState),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_KINTERRUPT.Mode),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_KINTERRUPT.Polarity),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KINTERRUPT.ServiceCount),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KINTERRUPT.DispatchCount),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KINTERRUPT.PassiveEvent),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_KINTERRUPT.TrapFrame),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KINTERRUPT.DisconnectData),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_KINTERRUPT.ServiceThread),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_KINTERRUPT.ConnectionData),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_KINTERRUPT.IntTrackEntry),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_KINTERRUPT.IsrDpcStats),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_KINTERRUPT.RedirectObject),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_KINTERRUPT.Padding),
                    new ulong[]
                    {
                        280UL
                    }
                }
            };
            Register<_KINTERRUPT>((mem, ptr) => new _KINTERRUPT(mem, ptr), offsets);
        }
    }
}