using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbuotojai.Contracts
{
    public interface IEmployee
    {
        void ReadData();
        void WriteData();

        void SaveData(StreamWriter writer);

    }
}
