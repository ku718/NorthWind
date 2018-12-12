using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinformControl
{
    class BookCompare : IComparer<BookInfo>
    {
        public int Compare(BookInfo x, BookInfo y)
        {
            int result;
            if (x.Price > y.Price)
            {
                // 앞의 객체 가격이 더 크면 양수 반환
                result = 1;
            }
            else if (x.Price == y.Price)
            {
                // 가격이 같다면 0반환
                result = 0;
            }
            else
            {
                // 뒤의 객체 가격이 더 크면 음수 반환
                result = -1;
            }
            return result;
        }
    }
}
