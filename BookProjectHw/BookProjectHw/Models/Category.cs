using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProjectHw.Models;

public class Category : EntityBase<string>
{
    public string Name { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}, Name : {Name}";
    }
}
