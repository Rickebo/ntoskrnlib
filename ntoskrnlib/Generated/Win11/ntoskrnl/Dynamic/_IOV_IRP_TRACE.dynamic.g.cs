using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOV_IRP_TRACE")]
    public sealed class _IOV_IRP_TRACE : DynamicStructure
    {
        public IntPtr Irp { get; }
        public IntPtr Thread { get; }
        public short KernelApcDisable { get; }
        public short SpecialApcDisable { get; }
        public uint CombinedApcDisable { get; }
        public byte Irql { get; }
        public byte[] StackTrace { get; }

        public _IOV_IRP_TRACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOV_IRP_TRACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOV_IRP_TRACE.Irp),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOV_IRP_TRACE.Thread),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IOV_IRP_TRACE.KernelApcDisable),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IOV_IRP_TRACE.SpecialApcDisable),
                    new ulong[]
                    {
                        18UL
                    }
                },
                {
                    nameof(_IOV_IRP_TRACE.CombinedApcDisable),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IOV_IRP_TRACE.Irql),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_IOV_IRP_TRACE.StackTrace),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_IOV_IRP_TRACE>((mem, ptr) => new _IOV_IRP_TRACE(mem, ptr), offsets);
        }
    }
}