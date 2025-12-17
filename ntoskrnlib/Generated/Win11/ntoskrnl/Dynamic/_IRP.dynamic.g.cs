using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IRP")]
    public sealed class _IRP : DynamicStructure
    {
        public short Type { get; }
        public ushort Size { get; }
        public IntPtr MdlAddress { get; }
        public uint Flags { get; }
        public _unnamed_tag_ AssociatedIrp { get; }
        public _LIST_ENTRY ThreadListEntry { get; }
        public _IO_STATUS_BLOCK IoStatus { get; }
        public sbyte RequestorMode { get; }
        public byte PendingReturned { get; }
        public sbyte StackCount { get; }
        public sbyte CurrentLocation { get; }
        public byte Cancel { get; }
        public byte CancelIrql { get; }
        public sbyte ApcEnvironment { get; }
        public byte AllocationFlags { get; }
        public IntPtr UserIosb { get; }
        public IntPtr IoRingContext { get; }
        public IntPtr UserEvent { get; }
        public _unnamed_tag_ Overlay { get; }
        public IntPtr CancelRoutine { get; }
        public IntPtr UserBuffer { get; }
        public _unnamed_tag_ Tail { get; }

        public _IRP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IRP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IRP.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IRP.Size),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_IRP.MdlAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IRP.Flags),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IRP.AssociatedIrp),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IRP.ThreadListEntry),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_IRP.IoStatus),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_IRP.RequestorMode),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_IRP.PendingReturned),
                    new ulong[]
                    {
                        65UL
                    }
                },
                {
                    nameof(_IRP.StackCount),
                    new ulong[]
                    {
                        66UL
                    }
                },
                {
                    nameof(_IRP.CurrentLocation),
                    new ulong[]
                    {
                        67UL
                    }
                },
                {
                    nameof(_IRP.Cancel),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_IRP.CancelIrql),
                    new ulong[]
                    {
                        69UL
                    }
                },
                {
                    nameof(_IRP.ApcEnvironment),
                    new ulong[]
                    {
                        70UL
                    }
                },
                {
                    nameof(_IRP.AllocationFlags),
                    new ulong[]
                    {
                        71UL
                    }
                },
                {
                    nameof(_IRP.UserIosb),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_IRP.IoRingContext),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_IRP.UserEvent),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_IRP.Overlay),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_IRP.CancelRoutine),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_IRP.UserBuffer),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_IRP.Tail),
                    new ulong[]
                    {
                        120UL
                    }
                }
            };
            Register<_IRP>((mem, ptr) => new _IRP(mem, ptr), offsets);
        }
    }
}