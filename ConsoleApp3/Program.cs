namespace ConsoleApp3
{
    internal class Program
    {
        static int[] SixthOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };

        static int[] SeventhOctave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };

        static int[] EigthOctave = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };

        static void PianoOctave(int[] Octave)
        {
            while (true)
            {
                System.ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.F6 || key.Key == ConsoleKey.F7 || key.Key == ConsoleKey.F8)
                {
                    break;
                }
                switch (key.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(Octave[0], 300);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(Octave[1], 300);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(Octave[2], 300);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(Octave[3], 300);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(Octave[4], 300);
                        break;
                    case ConsoleKey.F:
                        Console.Beep(Octave[5], 300);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(Octave[6], 300);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(Octave[7], 300);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(Octave[8], 300);
                        break;
                    case ConsoleKey.H:
                        Console.Beep(Octave[9], 300);
                        break;
                    case ConsoleKey.U:
                        Console.Beep(Octave[10], 300);
                        break;
                    case ConsoleKey.J:
                        Console.Beep(Octave[11], 300);
                        break;
                }
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Белые клавиши: A, S, D, F, G, H, J; Чёрные клавиши: W, E, T, Y, U.");
            Console.WriteLine("Переключение между октавами осуществляется с помощью F6, F7, F8.");

            while (true)
            {

                System.ConsoleKeyInfo Octave = Console.ReadKey(true);
                switch (Octave.Key)
                {
                    case ConsoleKey.F6:
                        Console.WriteLine("F6");
                        PianoOctave(SixthOctave);
                        continue;
                    case ConsoleKey.F7:
                        Console.WriteLine("F7");
                        PianoOctave(SeventhOctave);
                        continue;
                    case ConsoleKey.F8:
                        Console.WriteLine("F8");
                        PianoOctave(EigthOctave);
                        continue;
                    default:
                        Console.WriteLine("Чтобы выйти нажмите ENTER");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                }
            }
        }
        
    }
}