using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Events
{
    public class MenuActionItem : MenuItem
    {
        private readonly Action r_ActionToExecute;

        public MenuActionItem(string i_Title, Action i_ActionToExecute)
            : base(i_Title)
        {
            r_ActionToExecute = i_ActionToExecute;
        }

        internal override void Select()
        {
            r_ActionToExecute.Invoke();
        }
    }
}