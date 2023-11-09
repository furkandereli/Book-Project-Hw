using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProjectHw.Models;

public class EntityBase<TId>
{
    public TId Id { get; set; }
}
