using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaletteStudio.FileSystem
{
    public interface IRegistable
    {
        string ID { get; }
        string Name { get; }
    }
}
