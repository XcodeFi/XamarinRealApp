﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealApp
{
    public interface IDatabaseAccess
    {
        //SQLiteAsyncConnection GetConnection();
        SQLiteConnection GetConnection();
    }
}
