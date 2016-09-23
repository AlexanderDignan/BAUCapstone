using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaacTapTerminal.SampleData;

namespace TaacTapTerminal.Models
{
    public class FakeRestaurantModel
    {
        public List<FakeTable> Table { get; set; }
        public String Name { get; set; }

        public FakeRestaurantModel(String databaseName)
        {
            Name = databaseName;
            Table = FakeCloudService.GetTable();
        }

        public void Add(FakeTable table)
        {
            if (!Table.Contains(table))
            {
                Table.Add(table);
                FakeCloudService.Write(table);
            }
        }

        public void Delete(FakeTable table)
        {
            if (Table.Contains(table))
            {
                Table.Remove(table);
                FakeCloudService.Delete(table);
            }
        }

        public void Update(FakeTable table)
        {
            FakeCloudService.Write(table);
        }
    }
}
