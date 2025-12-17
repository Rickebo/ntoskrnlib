using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOV_FORCED_PENDING_TRACE")]
    public sealed class _IOV_FORCED_PENDING_TRACE : DynamicStructure
    {
        public IntPtr Irp { get; }
        public IntPtr Thread { get; }
        public byte[] StackTrace { get; }

        public _IOV_FORCED_PENDING_TRACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOV_FORCED_PENDING_TRACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOV_FORCED_PENDING_TRACE.Irp),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOV_FORCED_PENDING_TRACE.Thread),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IOV_FORCED_PENDING_TRACE.StackTrace),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_IOV_FORCED_PENDING_TRACE>((mem, ptr) => new _IOV_FORCED_PENDING_TRACE(mem, ptr), offsets);
        }
    }
}