using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WNF_SILODRIVERSTATE")]
    public sealed class _WNF_SILODRIVERSTATE : DynamicStructure
    {
        public IntPtr ScopeMap { get; }
        public IntPtr PermanentNameStoreRootKey { get; }
        public IntPtr PersistentNameStoreRootKey { get; }
        public long PermanentNameSequenceNumber { get; }
        public _WNF_LOCK PermanentNameSequenceNumberLock { get; }
        public long PermanentNameSequenceNumberPool { get; }
        public long RuntimeNameSequenceNumber { get; }

        public _WNF_SILODRIVERSTATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WNF_SILODRIVERSTATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WNF_SILODRIVERSTATE.ScopeMap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WNF_SILODRIVERSTATE.PermanentNameStoreRootKey),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WNF_SILODRIVERSTATE.PersistentNameStoreRootKey),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WNF_SILODRIVERSTATE.PermanentNameSequenceNumber),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WNF_SILODRIVERSTATE.PermanentNameSequenceNumberLock),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WNF_SILODRIVERSTATE.PermanentNameSequenceNumberPool),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_WNF_SILODRIVERSTATE.RuntimeNameSequenceNumber),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_WNF_SILODRIVERSTATE>((mem, ptr) => new _WNF_SILODRIVERSTATE(mem, ptr), offsets);
        }
    }
}