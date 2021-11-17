using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Common
{
    public abstract class BaseEntity
    {
        protected BaseEntity(int id)
        {
            Id = id;
        }

        protected BaseEntity() { }

        public int Id { get; set; }
    }
}
