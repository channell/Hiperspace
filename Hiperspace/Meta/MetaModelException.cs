using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiperspace.Meta
{
    public class MetaModelException : Exception
    {
        public (int id, string reason)[] Reason;
        public MetaModelException (MetaModel domainModel, MetaModel storedModel) : base()
        {
            Reason = domainModel.Difference(storedModel).ToArray();
        }
    }
}
