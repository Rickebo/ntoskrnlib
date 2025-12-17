using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_JOB_NOTIFICATION_INFORMATION")]
    public sealed class _JOB_NOTIFICATION_INFORMATION : DynamicStructure
    {
        public _JOB_NOTIFICATION_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _JOB_NOTIFICATION_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_JOB_NOTIFICATION_INFORMATION>((mem, ptr) => new _JOB_NOTIFICATION_INFORMATION(mem, ptr), offsets);
        }
    }
}