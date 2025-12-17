using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PFN_FLAGS")]
    public sealed class _MI_PFN_FLAGS : DynamicStructure
    {
        public ushort ReferenceCount { get; }
        public byte PageLocation { get; }
        public byte WriteInProgress { get; }
        public byte Modified { get; }
        public byte ReadInProgress { get; }
        public byte CacheAttribute { get; }
        public byte Priority { get; }
        public byte OnProtectedStandby { get; }
        public byte InPageError { get; }
        public byte SystemChargedPage { get; }
        public byte RemovalRequested { get; }
        public byte ParityError { get; }
        public uint EntireField { get; }

        public _MI_PFN_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PFN_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PFN_FLAGS.ReferenceCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS.PageLocation),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS.WriteInProgress),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS.Modified),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS.ReadInProgress),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS.CacheAttribute),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS.Priority),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS.OnProtectedStandby),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS.InPageError),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS.SystemChargedPage),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS.RemovalRequested),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS.ParityError),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS.EntireField),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_PFN_FLAGS>((mem, ptr) => new _MI_PFN_FLAGS(mem, ptr), offsets);
        }
    }
}