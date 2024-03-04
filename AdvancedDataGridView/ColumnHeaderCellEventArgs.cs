#region License
// Advanced DataGridView
//
// Original work Copyright (c), 2013 Zuby <zuby@me.com> 
// Modified work Copyright (c), 2014 Davide Gironi <davide.gironi@gmail.com>
//
// Please refer to LICENSE file for licensing information.
#endregion

using System;
using System.Windows.Forms;

namespace Zuby.ADGV
{
    internal class ColumnHeaderCellEventArgs : EventArgs
    {
        public MenuStrip FilterMenu { get; private set; }

        public DataGridViewColumn Column { get; private set; }

        public ColumnHeaderCellEventArgs(MenuStrip filterMenu, DataGridViewColumn column)
        {
            FilterMenu = filterMenu;
            Column = column;
        }
    }

}