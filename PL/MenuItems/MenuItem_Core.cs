using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.MenuItems
{
    public abstract class MenuItem_Core
    {
        public abstract string Title { get; }//заголовок пункта меню, который будет отображаться

        public abstract void Execute();// метод, который будет выполнен, если мы вызовем этот пункт меню
    }
}
