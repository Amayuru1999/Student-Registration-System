using System;

namespace GUI_Project
{
    internal class SQLiteConnection
    {
        private string v;

        public SQLiteConnection(string v)
        {
            this.v = v;
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}