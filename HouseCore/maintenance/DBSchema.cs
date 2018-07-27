﻿using es.dmoreno.house.core.dto;
using es.dmoreno.utils.dataaccess.db;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace es.dmoreno.house.core.maintenance
{
    internal class DBSchema
    {
        private SQLStatement _statement;

        public DBSchema(SQLStatement statement)
        {
            this._statement = statement;
        }

        public async Task generate()
        {
            await this._statement.createUpdateTableAsync<DTOMaster>();
        }
    }
}
