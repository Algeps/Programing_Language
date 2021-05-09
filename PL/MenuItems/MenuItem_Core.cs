
namespace PL.MenuItems
{
    public abstract class Task
    {
        public abstract string Title
        {
            get;
        }//заголовок пункта меню, который будет отображаться

        public abstract void Execute();// метод, который будет выполнен, если мы вызовем этот пункт меню
    }
}
