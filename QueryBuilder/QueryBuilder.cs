using System;

class QueryBuilder
{
    string Query = "";

    public QueryBuilder Select(string columns)
    {
        Query += $"SELECT {columns} ";
        return this;
    }

    public QueryBuilder From(string table)
    {
        Query += $"FROM {table} ";
        return this;
    }

    public QueryBuilder Where(string condition)
    {
        Query += $"WHERE {condition} ";
        return this;
    }

    public QueryBuilder OrderBy(string column)
    {
        Query += $"ORDER BY {column} ";
        return this;
    }

    public string Build()
    {
        return Query;
    }
}