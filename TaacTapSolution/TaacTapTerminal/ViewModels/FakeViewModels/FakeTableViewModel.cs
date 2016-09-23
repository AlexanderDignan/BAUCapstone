using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaacTapTerminal.SampleData;

namespace TaacTapTerminal.ViewModels
{
    public class FakeTableViewModel : NotificationBase<FakeTable>
    {
        public FakeTableViewModel(FakeTable table = null) : base(table) { }
        public String Name
        {
            get { return This.Name; }
            set { SetProperty(This.Name, value, () => This.Name = value); }
        }

        public int TableId
        {
            get { return This.TableId; }
            set { SetProperty(This.TableId, value, () => This.TableId = value); }
        }

        public bool TableOpen
        {
            get { return This.TableOpen; }
            set { This.TableOpen = value; }
        }
    }
}
