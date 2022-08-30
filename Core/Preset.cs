using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixInStyle.Core
{
    [Serializable]
    internal class Preset : List<Tuple<string, string, int>>{}
}
