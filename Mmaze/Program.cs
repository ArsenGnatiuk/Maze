using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mmaze
{
	class Program
	{
		//це якраз для вверх вниз
		static void Jbig(int[,] board, int i, int j, int xe, int ye)
		{
			if (xe == i && ye < j)
			{
				if (board[i, j - 1] == 0)
				{
					j--;
					Console.WriteLine(i + " " + j);
				}
				else if (board[i + 1, j] == 0)
				{
					i++;
					Console.WriteLine(i + " " + j);
					if (ye < j)
					{
						j--;
						Console.WriteLine(i + " " + j);
					}
 
						Upper(board, i, j, xe, ye);
					 
				}
			}
		}
		//це якраз для вверх вниз
		static void Jsmall(int[,] board, int i, int j, int xe, int ye)
		{
			 
				if (board[i, j + 1] == 0)
				{
					j++;
					Console.WriteLine(i + " " + j);
				}
				else if (board[i + 1, j] == 0)
				{
					i++;
					Console.WriteLine(i + " " + j);
					if (ye > j)
					{
						j++;
						Console.WriteLine(i + " " + j);
					}
					if (xe < i)
					{
						Upper(board, i, j, xe, ye);
					}
				}
			 
		}
		//ВВЕРХ
		static void Upper(int[,] board, int i, int j, int xe, int ye)
		{
			if (xe == i && ye > j)
			{
				Jbig(board, i, j, xe, ye);
			}
			if (xe == i && ye < j)
			{
				Jsmall(board, i, j, xe, ye);
			}
			if (board[i-1, j] == 0&&xe<i)
			{
				i--;
				Console.WriteLine(i + " " + j);
			}
			if (ye > j)
			{
				Right(board, i, j, xe, ye);
			}
			if (ye < j)
			{
				Left(board, i, j, xe, ye);
			}
			if (board[i - 1, j] == 0 && xe < i)
			{
				i--;
				Console.WriteLine(i + " " + j);
			}
			if (board[i - 1, j] == 0 && xe < i)
			{
				i--;
				Console.WriteLine(i + " " + j);
			}
			if (ye > j)
			{
				Right(board, i, j, xe, ye);
			}
			if (ye < j)
			{
				Left(board, i, j, xe, ye);
			}
			Upper(board, i, j, xe, ye);
		}
		//ВПРАВО
		static void Right(int[,] board, int i, int j, int xe, int ye)
		{
			if (xe == i && ye > j)
			{
				Jbig(board, i, j, xe, ye);
			}
			if (xe == i && ye < j)
			{
				Jsmall(board, i, j, xe, ye);
			}
			if (board[i, j+1] == 0)
			{
				j++;
				Console.WriteLine(i + " " + j);
			}
			if (board[i, j + 1] != 0 && board[i+1, j] != 0)
			{
				if (board[i, j - 1] == 0)
				{
					j--;
					Console.WriteLine(i + " " + j);
				}
				if (xe > i)
				{
					Down(board, i, j, xe, ye);
				}
			}
			if (board[i, j + 1] == 0&&ye>j)
			{
				j++;
				Console.WriteLine(i + " " + j);
			}
			if (xe < i)
			{
				Upper(board, i, j, xe, ye);
			}
			if (xe > i)
			{
				Down(board, i, j, xe, ye);
			}
			if (board[i, j + 1] != 0 && board[i + 1, j] != 0)
			{
				if (board[i, j - 1] == 0)
				{
					j--;
					Console.WriteLine(i + " " + j);
				}
				if (ye < j)
				{
					Left(board, i, j, xe, ye);
				}
			} 
			Upper(board, i, j, xe, ye);
		}
		//ФУНКЦІЯ ВНИЗ
		static void Down(int[,] board, int i, int j, int xe, int ye) {
			if (xe == i && ye > j)
			{
				Jbig(board, i, j, xe, ye);
			}
			if (xe == i && ye < j)
			{
				Jsmall(board, i, j, xe, ye);
			}
			if (xe == i && ye > j)
			{
				if (board[i + 1, j] == 0)
				{
					i++;
					Console.WriteLine(i + " " + j);
				}
			} 
			if (xe<i)
			{
				Upper(board, i, j, xe, ye);
			}
			if (xe > i)
			{
				if (board[i + 1, j] == 0)
				{
					i++;
					Console.WriteLine(i + " " + j);
				}
			}
			if (ye < j)
			{
				Left(board, i, j, xe, ye);
			}
			if (ye > j)
			{
				Right(board, i, j, xe, ye);
			}	 
			Down(board, i, j, xe, ye);
		}
		//ВЛІВО
		static void Left(int[,] board, int i, int j,int xe, int ye)
		{
			if (xe == i && ye > j)
			{
				Jbig(board, i, j, xe, ye);
			}
			if (xe == i && ye < j)
			{
				Jsmall(board, i, j, xe, ye);
			}
			if (board[i, j - 1] == 0)
			{
				j--;
				Console.WriteLine(i + " " + j);
			}
			if (board[i, j - 1] != 0 && board[i + 1, j] != 0)
			{
				if (board[i, j + 1] == 0&&ye<j)
				{
					j++;
					Console.WriteLine(i + " " + j);
				}
				else
				{
					i--;
					Console.WriteLine(i + " " + j);
				}
				if (xe > i)
				{
					Down(board, i, j, xe, ye);
				}
			}
			if (board[i, j - 1] == 0)
			{
				j--;
				Console.WriteLine(i + " " + j);
			}
			if (xe < i)
			{
				Upper(board, i, j, xe, ye);
			}
			if (xe > i)
			{
				Down(board, i, j, xe, ye);
			}
			if (board[i, j - 1] != 0 && board[i - 1, j] != 0)
			{
				if (board[i, j + 1]  == 0)
				{
					j++;
					Console.WriteLine(i + " " + j);
				}
				if (ye > j)
				{
					Right(board, i, j, xe, ye);
				}
			}
			Left(board, i, j, xe, ye);
		}
		//ПОШУК КОРЕКТНОГО ПОЧАТКУ ТА КІНЦЯ
		static void Maze(int[,] board, int i, int j,int x, int y,  int xe, int ye)
		{
			i = x;
			j = y;
			if (board[xe,ye]!=0)
			{
				Console.WriteLine("Bad end, end not path(not 0)");
				return;
			}
			if (board[i, j] == 0)
			{
				Console.WriteLine(i+" START "+j);
				Console.WriteLine();
				Console.WriteLine(xe + " END " + ye);
				Console.WriteLine(i + " " + j);
				Down(board,i,j,xe,ye);
			}
			else 
			{
				Console.WriteLine("Bad start, start not path(not 0)");
				return;
			}
		}
		static void Main(string[] args)
		{
			int[,] board = new int[6, 6]
			{
				{-1,-1, 0,-1,-1,-1},
				{-1, 0, 0,-1, 0,-1},
				{-1, 0,-1, 0, 0,-1},
				{-1, 0, 0, 0, 0,-1},
				{-1, 0,-1, 0,-1,-1},
				{-1,-1,-1,-1,-1,-1}
			};
			Start:
			string xo;
			string yo;
			string xt;
			string yt;
			Console.WriteLine("Введiть початковi координати X Y");
			xo = Console.ReadLine();
			int x = Convert.ToInt32(xo);
			yo = Console.ReadLine();
			int y = Convert.ToInt32(yo);
			Console.WriteLine("Введiть кiнцеві координати X Y");
			xt = Console.ReadLine();
			int xe = Convert.ToInt32(xt);
			yt = Console.ReadLine();
			int ye = Convert.ToInt32(yt);
			int i = 0; int j = 0;
			if(x>6|| y > 6 || ye > 6 || xe > 6)
			{
				goto Start;
			}
			Maze(board, i, j,x,y,xe,ye);
		}
	}
}
