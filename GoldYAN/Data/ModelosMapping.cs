using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperExtensions.Mapper;

namespace GoldYAN.Data
{
    public class ModelosClassMapper : ClassMapper<Modelos>
    {
        public ModelosClassMapper()
        {
            Map(x => x.idmodelo).Key(KeyType.Assigned);
            Map(x => x.linha).Key(KeyType.Assigned);
            AutoMap();  // <-- Maps the unmapped columns
        }
    }
}
