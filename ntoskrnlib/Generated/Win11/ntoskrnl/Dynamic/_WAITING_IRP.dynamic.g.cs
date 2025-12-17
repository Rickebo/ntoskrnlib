using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WAITING_IRP")]
    public sealed class _WAITING_IRP : DynamicStructure
    {
        public _LIST_ENTRY Links { get; }
        public IntPtr Irp { get; }
        public IntPtr CompletionRoutine { get; }
        public IntPtr Context { get; }
        public IntPtr Event { get; }
        public uint Information { get; }
        public byte BreakAllRH { get; }
        public byte OplockBreakNotify { get; }
        public IntPtr FileObject { get; }

        public _WAITING_IRP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WAITING_IRP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WAITING_IRP.Links),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WAITING_IRP.Irp),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WAITING_IRP.CompletionRoutine),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WAITING_IRP.Context),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WAITING_IRP.Event),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_WAITING_IRP.Information),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_WAITING_IRP.BreakAllRH),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_WAITING_IRP.OplockBreakNotify),
                    new ulong[]
                    {
                        53UL
                    }
                },
                {
                    nameof(_WAITING_IRP.FileObject),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_WAITING_IRP>((mem, ptr) => new _WAITING_IRP(mem, ptr), offsets);
        }
    }
}