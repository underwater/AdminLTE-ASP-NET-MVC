using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdrData.Entities;

namespace AdrData.Repositories
{
    public class FakePosRepository  
    {
        public IList<PosMapping> GetAllPosMappings()
        {
            return new List<PosMapping>
            {
                new PosMapping { PosGroup ="Cheap Tickets", SuperRegion ="AMER"},
                new PosMapping { PosGroup ="EAN AMER", SuperRegion ="AMER"},
                new PosMapping { PosGroup ="Egencia AMER", SuperRegion ="AMER"},

                new PosMapping { PosGroup ="EAN APAC", SuperRegion ="APAC"},
                new PosMapping { PosGroup ="Egencia APAC", SuperRegion ="APAC"},
                new PosMapping { PosGroup ="eLong Legacy", SuperRegion ="APAC"},


                new PosMapping { PosGroup ="eBookers CH", SuperRegion ="EMEA"},
                new PosMapping { PosGroup ="eBookers DE", SuperRegion ="EMEA"},
                new PosMapping { PosGroup ="eBookers FI", SuperRegion ="EMEA"},


                new PosMapping { PosGroup ="EAN LATAM", SuperRegion ="LATAM"},
                new PosMapping { PosGroup ="Exp Arg", SuperRegion ="LATAM"},
                new PosMapping { PosGroup ="Exp Bra", SuperRegion ="LATAM"},
            };
        }
    }
}













