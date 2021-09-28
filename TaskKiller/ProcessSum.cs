using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskKiller
{
    class ProcessSum
    {
        public int ID { get; set; }
        public Button IDKill = new Button();
        public string Name { get; set; }
        public string User { get; set; }

        public ProcessSum(int ID_C, string name_C, string user_C)
        {
            ID = ID_C;
            Name = name_C;
            User = user_C;
        }
    }
}
