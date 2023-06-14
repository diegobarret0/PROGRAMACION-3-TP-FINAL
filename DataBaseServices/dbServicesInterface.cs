using System;
public interface dbServicesInterface
{
    public string insertRow(object obj, string tableName);
    public string updateRow(object obj, string tableName, string condition);
    public string deleteRow(string tableName, string condition);
    public List<object> searchRow(Type objectType, string tableName, string condition);
}
