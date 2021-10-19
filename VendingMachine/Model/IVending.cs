using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    public interface IVending
    {
        bool InsertMoney(string amount);

        string EndTransaction();

    }
}
