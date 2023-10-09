using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            Console.WriteLine("Белые клавиши: A, S, D, F, G, H, J; Чёрные клавиши: W, E, T, Y, U.\n" +
                "Переключение между октавами осуществляется с помощью F6, F7, F8.\n" +
                "Повторное нажатие на клавишу октавы останавливает её работу.\n" +
                "Для выхода из программы нажмите на любую клавишу или Enter.");
            while (true)
            {
                key = Console.ReadKey();
                Piano(key);
            }
        }
        static int[] Octave = new int[] { };
        static int[] SixthOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
        static int[] SeventhOctave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
        static int[] EigthOctave = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
        static void beep(int[] O, int N)
        {
            Console.Beep(O[N], 300);
        }
        static void change(int[] next)
        {
            Octave = next;
        }
        static void Piano(ConsoleKeyInfo OctaKey)
        {
            switch (OctaKey.Key)
            {
                case ConsoleKey.F6:
                    change(SixthOctave);
                    Console.WriteLine("\nТекущая октава: 6");
                    break;
                case ConsoleKey.F7:
                    change(SeventhOctave);
                    Console.WriteLine("\nТекущая октава: 7");
                    break;
                case ConsoleKey.F8:
                    change(EigthOctave);
                    Console.WriteLine("\nТекущая октава: 8");
                    break;
                case ConsoleKey.A:
                    beep(Octave, 0);
                    break;
                case ConsoleKey.W:
                    beep(Octave, 1);
                    break;
                case ConsoleKey.S:
                    beep(Octave, 2);
                    break;
                case ConsoleKey.E:
                    beep(Octave, 3);
                    break;
                case ConsoleKey.D:
                    beep(Octave, 4);
                    break;
                case ConsoleKey.F:
                    beep(Octave, 5);
                    break;
                case ConsoleKey.T:
                    beep(Octave, 6);
                    break;
                case ConsoleKey.G:
                    beep(Octave, 7);
                    break;
                case ConsoleKey.Y:
                    beep(Octave, 8);
                    break;
                case ConsoleKey.H:
                    beep(Octave, 9);
                    break;
                case ConsoleKey.U:
                    beep(Octave, 10);
                    break;
                case ConsoleKey.J:
                    beep(Octave, 11);
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}