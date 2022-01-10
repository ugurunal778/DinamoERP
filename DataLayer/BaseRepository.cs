using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BaseRepository
    {
        private DinamoERPdbEntities _dinamoERPmodel;
        public DinamoERPdbEntities DinamoERPModel
        {
            get
            {
                if (_dinamoERPmodel is null)
                {
                    _dinamoERPmodel = new DinamoERPdbEntities();
                }
                return _dinamoERPmodel;
            }
        }
    }
}
