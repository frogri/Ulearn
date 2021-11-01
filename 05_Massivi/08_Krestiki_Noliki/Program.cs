/*
Вам с Васей наконец-то надоело тренироваться на маленьких программках и вы взялись за настоящее дело! Вы решили написать игру крестики-нолики!
Начать было решено с подпрограммы, определяющей не закончилась ли уже игра, а если закончилась, то кто выиграл.

Методу GetGameResult передается поле, представленное массивом 3х3 из enum Markers. Вам надо вернуть победителя CrossWin или CircleWin, 
если таковой имеется или Draw, если выигрышной последовательности нет ни у одного, либо есть у обоих.
Постарайтесь придумать красивое, понятное решение.
Подумайте, как разбить задачу на более простые подзадачи. Попытайтесь выделить один или два вспомогательных метода.
 */

using System;
using System.Linq;

namespace _08_Krestiki_Noliki
{
    public class Program
    {
        public enum Mark
        {
            Empty,
            Cross,
            Circle
        }

        public enum GameResult
        {
            CrossWin,
            CircleWin,
            Draw
        }

        public static void Main()
        {
            Run("XXX OO. ..."); // CrossWin
            Run("OXO XO. .XO"); // CircleWin
            Run("OXO XOX OX."); // CircleWin
            Run("XOX OXO OXO"); // Draw
            Run("... ... ..."); // Draw
            Run("XXX OOO ..."); // Draw
            Run("XOO XOO XX."); // CrossWin
            Run(".O. XO. XOX"); // CircleWin

            Console.ReadKey();
        }

        private static void Run(string description)
        {
            Console.WriteLine(description.Replace(" ", Environment.NewLine));
            Console.WriteLine(GetGameResult(CreateFromString(description)));
            Console.WriteLine();
        }

        private static Mark[,] CreateFromString(string str)
        {
            var field = str.Split(' ');
            var ans = new Mark[3, 3];
            for (int x = 0; x < field.Length; x++)
                for (var y = 0; y < field.Length; y++)
                    ans[x, y] = field[x][y] == 'X' ? Mark.Cross : (field[x][y] == 'O' ? Mark.Circle : Mark.Empty);
            return ans;
        }

        private static GameResult GetGameResult(Mark[,] field)
        {
            var isCrossWin = HasWinSequence(field, Mark.Cross);
            var isCircleWin = HasWinSequence(field, Mark.Circle);

            if (isCrossWin && !isCircleWin)
                return GameResult.CrossWin;

            if (isCircleWin && !isCrossWin)
                return GameResult.CircleWin;

            return GameResult.Draw;
        }

        private static bool HasWinSequence(Mark[,] field, Mark mark)
        {
            Mark[] winCombination = { mark, mark, mark };
            return CheckHorizontal(field, mark, winCombination) || CheckVertical(field, mark, winCombination) || CheckDiagonal(field, mark, winCombination);
        }

        private static bool CheckHorizontal(Mark[,] field, Mark mark, Mark[] winCombination)
        {
            for (var i = 0; i < field.GetLength(0); i++)
            {
                var raw = new Mark[3];

                for (var j = 0; j < field.GetLength(1); j++)
                    raw[j] = field[i, j];

                if (raw.SequenceEqual(winCombination))
                    return true;
            }

            return false;
        }

        private static bool CheckVertical(Mark[,] field, Mark mark, Mark[] winCombination)
        {
            for (var i = 0; i < field.GetLength(1); i++)
            {
                var column = new Mark[3];

                for (var j = 0; j < field.GetLength(0); j++)
                    column[j] = field[j, i];

                if (column.SequenceEqual(winCombination))
                    return true;
            }

            return false;
        }

        private static bool CheckDiagonal(Mark[,] field, Mark mark, Mark[] winCombination)
        {
            var principalDiagonal = new Mark[3];
            var secondaryDiagonal = new Mark[3];

            for (var i = 0; i < field.GetLength(0); i++)
            {
                for (var j = 0; j < field.GetLength(1); j++)
                {
                    if (i == j)
                        principalDiagonal[i] = field[i, j];

                    if (i + j == field.GetLength(0) - 1)
                        secondaryDiagonal[i] = field[i, j];
                }
            }

            if (principalDiagonal.SequenceEqual(winCombination) || secondaryDiagonal.SequenceEqual(winCombination))
                return true;

            return false;
        }
    }
}