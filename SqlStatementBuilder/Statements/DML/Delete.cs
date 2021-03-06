﻿using System.Text;

namespace SqlStatementBuilder.Statements.DML
{
    public class Delete: DmlStatement
    {
        public Delete()
            :base("DELETE FROM")
        {
            
        }
        public Delete(string table)
            :base("DELETE FROM")
        {
            TableName = table;
        }

        public override string ToString()
        {
            StringBuilder query = new StringBuilder(Action);

            //table
            if (TableName != null && !TableName.Equals(string.Empty))
            {
                query.Append($" {TableName}");
            }

            //where
            if (Conditions.Count > 0)
            {
                var conditions = string.Join(" ", Conditions.ToArray());
                query.Append($" {conditions}");
            }

            return query.ToString();
        }

    }
}