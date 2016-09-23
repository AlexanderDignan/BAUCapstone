using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaacTapTerminal.SampleData
{
    public class FakeTable
    {
        public String Name { get; set; }
        public int TableId { get; set;}
        public bool TableOpen { get; set; }
    }
    public class FakeCloudService
    {
        public static string Name = "Fake Cloud Data";

        public static List<FakeTable> GetTable()
        {
            Debug.WriteLine("Get for Table.");
            return new List<FakeTable>()
            {
                new FakeTable() {Name="Table1",TableId=1,TableOpen=true },
                new FakeTable() {Name="Table2",TableId=2,TableOpen=true },
                new FakeTable() {Name="Table3",TableId=3,TableOpen=false }
            };
        }

        public static void Write(FakeTable table)
        {
            Debug.WriteLine("INSERT table with name " + table.Name);
        }
        public static void Delete(FakeTable table)
        {
            Debug.WriteLine("DELETE Table with name " + table.Name);
        }
    }
}
