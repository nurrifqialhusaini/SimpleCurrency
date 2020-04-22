using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCurrency
{
    class Backend
    {
        double Money, Konversi;
        private OnLoad ui;

        public Backend(OnLoad ui)
        {
            this.ui = ui;
        }
        public void StartUp()
        {
            int Choice;
            Console.Clear();
            this.ui.Header();
            Console.WriteLine("1. Dollar ke Rupiah");
            Console.WriteLine("2. Dollar ke Ringgit");
            Console.WriteLine("3. Dollar ke Euro");
            Console.WriteLine("4. Dollar ke Yen");
            Console.WriteLine("5. Dollar ke Won");
            Console.WriteLine("6. Dollar ke Riyal");
            Console.WriteLine("7. Dollar ke Bitcoin");
            this.ui.FormTittle("Silahkan memilih konversi mata uang : ");
            Choice = Convert.ToInt32(Console.ReadLine());
            if(Choice == 1)
            {
                Menu(1);
            } 
            else if(Choice == 2)
            {
                Menu(2);
            }
            else if(Choice == 3)
            {
                Menu(3);
            }
            else if(Choice == 4)
            {
                Menu(4);
            }
            else if (Choice == 5)
            {
                Menu(5);
            }
            else if (Choice == 6)
            {
                Menu(6);
            }
            else if (Choice == 7)
            {
                Menu(7);
            }
            else
            {
                StartUp();
            }
            
        }
        public void Menu(int menu)
        {
            Console.Clear();
            switch(menu)
            {
                case 1:
                    {
                        this.ui.Header();
                        this.ui.TittleMenu("Aplikasi Konversi Dollar ke Rupiah");
                        Console.Write("Masukkan Jumlah Uang (Dollar) : ");
                        Money = double.Parse(Console.ReadLine());
                        if(Money < 0)
                        {
                            Console.WriteLine("Tidak bisa mengkonversi uang kurang dari 0");
                            break;
                        }
                        Konversi = Money * 15000;
                        Console.WriteLine("Hasil Konversi dari " + Money + " Dollar adalah Rp " + Konversi);
                        Ask();
                        break;
                    }
                case 2:
                    {
                        this.ui.Header();
                        this.ui.TittleMenu("Aplikasi Konversi Dollar ke Ringgit");
                        Console.Write("Masukkan Jumlah Uang (Dollar) : ");
                        Money = double.Parse(Console.ReadLine());
                        if (Money < 0)
                        {
                            Console.WriteLine("Tidak bisa mengkonversi uang kurang dari 0");
                            break;
                        }
                        Konversi = Money * 4.40;
                        Console.WriteLine("Hasil Konversi dari " + Money + " Dollar adalah " + Konversi + " Ringgit");
                        Ask();
                        break;
                    }
                case 3:
                    {
                        this.ui.Header();
                        this.ui.TittleMenu("Aplikasi Konversi Dollar ke Euro");
                        Console.Write("Masukkan Jumlah Uang (Dollar) : ");
                        Money = double.Parse(Console.ReadLine());
                        if (Money < 0)
                        {
                            Console.WriteLine("Tidak bisa mengkonversi uang kurang dari 0");
                            break;
                        }
                        Konversi = Money * 0.92;
                        Console.WriteLine("Hasil Konversi dari " + Money + " Dollar adalah " + Konversi + " Euro");
                        Ask();
                        break;
                    }
                case 4:
                    {
                        this.ui.Header();
                        this.ui.TittleMenu("Aplikasi Konversi Dollar ke Yen");
                        Console.Write("Masukkan Jumlah Uang (Dollar) : ");
                        Money = double.Parse(Console.ReadLine());
                        if (Money < 0)
                        {
                            Console.WriteLine("Tidak bisa mengkonversi uang kurang dari 0");
                            break;
                        }
                        Konversi = Money * 107.56;
                        Console.WriteLine("Hasil Konversi dari " + Money + " Dollar adalah " + Konversi + " Yen");
                        Ask();
                        break;
                    }
                case 5:
                    {
                        this.ui.Header();
                        this.ui.TittleMenu("Aplikasi Konversi Dollar ke Won");
                        Console.Write("Masukkan Jumlah Uang (Dollar) : ");
                        Money = double.Parse(Console.ReadLine());
                        if (Money < 0)
                        {
                            Console.WriteLine("Tidak bisa mengkonversi uang kurang dari 0");
                            break;
                        }
                        Konversi = Money * 1.234;
                        Console.WriteLine("Hasil Konversi dari " + Money + " Dollar adalah " + Konversi + " Won");
                        Ask();
                        break;
                    }
                case 6:
                    {
                        this.ui.Header();
                        this.ui.TittleMenu("Aplikasi Konversi Dollar ke Riyal");
                        Console.Write("Masukkan Jumlah Uang (Dollar) : ");
                        Money = double.Parse(Console.ReadLine());
                        if (Money < 0)
                        {
                            Console.WriteLine("Tidak bisa mengkonversi uang kurang dari 0");
                            break;
                        }
                        Konversi = Money * 3.75;
                        Console.WriteLine("Hasil Konversi dari " + Money + " Dollar adalah " + Konversi + " Riyal");
                        Ask();
                        break;
                    }
                case 7:
                    {
                        this.ui.Header();
                        this.ui.TittleMenu("Aplikasi Konversi Dollar ke Bitcoin");
                        Console.Write("Masukkan Jumlah Uang (Dollar) : ");
                        Money = double.Parse(Console.ReadLine());
                        if (Money < 0)
                        {
                            Console.WriteLine("Tidak bisa mengkonversi uang kurang dari 0");
                            break;
                        }
                        Konversi = Money * 0.00015;
                        Console.WriteLine("Hasil Konversi dari " + Money + " Dollar adalah " + Konversi + " Bitcoin");
                        Ask();
                        break;
                    }
                default:
                    {
                        StartUp();
                        break;
                    }
            }
        }
        public void Ask()
        {
            string answer;
            Console.Write("Apakah anda ingin konversi lagi ? ( Y / N ) : ");
            answer = Console.ReadLine();
            if(answer == "Y" || answer == "y")
            {
                StartUp();
            }
            else if(answer == "N" || answer == "n")
            {
                Console.WriteLine("Terimakasih telah menggunakan Program ini");
            } 
            else
            {
                StartUp();
            }
        }
    }
}
