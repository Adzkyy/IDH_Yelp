using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDbSetConverter.Helpers
{
    public static class CursorHelper
    {
        public static (int, int) GetCurPos()
        {
            var top = Console.CursorTop;
            var left = Console.CursorLeft;
            return (top, left);
        }
    }
}
