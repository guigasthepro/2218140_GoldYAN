using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperExtensions.Mapper;

namespace GoldYAN.Data
{
    public class EncomendasClassMapper : ClassMapper<Encomendas>
    {
        public EncomendasClassMapper()
        {
            Map(x => x.idencomenda).Key(KeyType.Assigned);
            Map(x => x.linha).Key(KeyType.Assigned);
            AutoMap();  // <-- Maps the unmapped columns
        }
    }
}
