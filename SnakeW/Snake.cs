using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeW
{
    class Snake
    {
        public List<CellSnake> bodySnake = new List<CellSnake>();

        public Snake()
        {
            for (int i = 0; i < 6; i++)
            {
                CellSnake cell = new CellSnake(i*16, 1*16);
                bodySnake.Add(cell);
            }
        }
    }
}
