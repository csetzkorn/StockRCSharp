using System.Collections.Generic;

namespace Data
{
  public interface IDataSet
  {
    IList<string> ColumnNames { get; set; }
    double[,] MappedData { get; set; }
  }
}
