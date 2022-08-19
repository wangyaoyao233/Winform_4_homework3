using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_4_homework3.interfaces;

namespace Winform_4_homework3
{
    /// <summary>
    /// ItemInfo展示类, 实现Imanage接口
    /// </summary>
    public class ItemInfoDisplay : IManage
    {
        public string GetItemInfo(ItemInfo item)
        {
            return $"{item.Id}, {item.Name}, {item.Type}\r\n";
        }
    }
}
