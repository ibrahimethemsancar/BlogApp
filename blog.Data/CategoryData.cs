using blog.Data.Infrastcructure.Entities;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Data.Infrastcructure
{
    public class CategoryData : EntityBaseData<Model.Category>
    {
        public CategoryData(IOptions<DataBaseSettings> dbOptions) : base(new DataContext(dbOptions.Value.ConnectionString))
        {

        }
    }
}


