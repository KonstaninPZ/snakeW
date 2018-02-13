using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeW
{
     class MoveSnake
    {
        public static void moveDown(Snake snake)
        {
            for (int i = 0; i < snake.bodySnake.Count; i++)
            {
                if (i == snake.bodySnake.Count - 1)
                {
                    snake.bodySnake[i].Y += 16;
                    continue;
                }
                snake.bodySnake[i].X = snake.bodySnake[i + 1].X;
                snake.bodySnake[i].Y = snake.bodySnake[i + 1].Y;
            }
            
        }
        public static void moveUp(Snake snake)
        {

            for (int i = 0; i < snake.bodySnake.Count; i++)
            {
                if (i == snake.bodySnake.Count - 1)
                {
                    snake.bodySnake[i].Y -= 16;
                    continue;
                }
                snake.bodySnake[i].X = snake.bodySnake[i + 1].X;
                snake.bodySnake[i].Y = snake.bodySnake[i + 1].Y;
            }

        }
        public static void moveLeft(Snake snake)
        {
            for (int i = 0; i < snake.bodySnake.Count; i++)
            {
                if (i == snake.bodySnake.Count - 1)
                {
                    snake.bodySnake[i].X -= 16;
                    continue;
                }
                snake.bodySnake[i].X = snake.bodySnake[i + 1].X;
                snake.bodySnake[i].Y = snake.bodySnake[i + 1].Y;
            }
        }

        public static void moveRight(Snake snake)
        {
            for (int i = 0; i < snake.bodySnake.Count; i++)
            {
                if (i == snake.bodySnake.Count - 1)
                {
                    snake.bodySnake[i].X += 16;
                    continue;
                }
                snake.bodySnake[i].X = snake.bodySnake[i + 1].X;
                snake.bodySnake[i].Y = snake.bodySnake[i + 1].Y;
            }
        }
    }
}
