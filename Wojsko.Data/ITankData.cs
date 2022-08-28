using System;
using System.Collections.Generic;
using System.Text;
using Wojsko.Core;

namespace Wojsko.Data
{
    public interface ITankData
    {
        Tank GetById(int id);
        IEnumerable<Tank> GetByName(string name);
        IEnumerable<Tank> GetAll();
        Tank Add(Tank newTank);
        Tank Update(Tank updatedTank);
        Tank Delete(int it);
        int Commit();

    }
}
