using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.ChooseOperation();
        }
    }

    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class Player : IPlayable, IRecordable
    {

        private string button;

        public void ChooseOperation()
        {
            Console.WriteLine("Press 'P' to play,'R' to record or any other button to exit");

            string button = Console.ReadLine();

            switch (button)
            {
                case string b when b == "P" || b == "p":
                    {
                        ((IPlayable)this).Play();
                        break;
                    }
                case string b when b == "R" || b == "r":
                    {
                        ((IRecordable)this).Record();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        public void Play()
        {
            Console.WriteLine("Playing is in progress. Press 'P' to pause, 'S' to stop or any other button to exit");
            button = Console.ReadLine();

            switch (button)
            {
                case string c when c == "P" || c == "p":
                    {
                        ((IPlayable)this).Pause();
                        break;
                    }
                case string c when c == "S" || c == "s":
                    {
                        ((IPlayable)this).Stop();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Playing is paused. Press 'R' to resume, 'S' to stop or any other button to exit");

            button = Console.ReadLine();

            switch (button)
            {

                case string c when c == "R" || c == "r":
                    {
                        ((IPlayable)this).Play();
                        break;
                    }
                case string c when c == "S" || c == "s":
                    {
                        ((IPlayable)this).Stop();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Playing is stopped. Press 'C' to select operation or any other key to exit");

            button = Console.ReadLine();

            switch (button)
            {

                case string c when c == "C" || c == "c":
                    {
                        ChooseOperation();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
       
        public void Record()
        {
            Console.WriteLine("Recording is in progress. Press 'P' to pause, 'S' to stop or any other button to exit");
            button = Console.ReadLine();

            switch (button)
            {
                case string c when c == "P" || c == "p":
                    {
                        ((IRecordable)this).Pause();
                        break;
                    }
                case string c when c == "S" || c == "s":
                    {
                        ((IRecordable)this).Stop();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
       
        void IRecordable.Pause()
        {
            Console.WriteLine("Recording is paused. Press 'R' to resume, 'S' to stop or any other button to exit");

            button = Console.ReadLine();

            switch (button)
            {

                case string c when c == "R" || c == "r":
                    {
                        ((IRecordable)this).Record();
                        break;
                    }
                case string c when c == "S" || c == "s":
                    {
                        ((IRecordable)this).Stop();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }      
               
        void IRecordable.Stop()
        {
            Console.WriteLine("Recording is stopped. Press 'C' to select operation or any other key to exit");

            button = Console.ReadLine();

            switch (button)
            {

                case string c when c == "C" || c == "c":
                    {
                        ChooseOperation();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }        
    }
}
