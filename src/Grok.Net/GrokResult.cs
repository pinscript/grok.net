using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GrokNet
{
    public sealed class GrokResult : ReadOnlyCollection<GrokItem>
    {
        private readonly Dictionary<string, int> _groupNamesMap;

        public GrokResult(IList<GrokItem> grokItems, Dictionary<string, int> groupNamesMap)
            : base(grokItems ?? new List<GrokItem>())
        {
            _groupNamesMap = groupNamesMap;
        }

        public object this[string key]
        {
            get
            {
                return this[_groupNamesMap[key]].Value;
            }
        }
    }
}
