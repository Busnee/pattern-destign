using System;

namespace SingletonPattern
{
    class Song
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public Song(int id, string name, string artist)
        {
            this.ID = id;
            this.Name = name;
            this.Artist = artist;
        }
        public string getDetail()
        {
            return this.Name + " by " + this.Artist;
        }
    }
    class Station
    {
        public int ID { get; set; }
        public string Name { get; set; }
        Song[] songs = [];
        public Station(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public void addSong(int id, string name, string artist)
        {
            Array.Resize(ref songs, songs.Length + 1);
            songs[songs.Length - 1] = new Song(id, name, artist);
        }
        public Song[] getSongs()
        {
            return songs;
        }
    }
    class Radio
    {
        static Radio r = null;
        private int volume = 1;
        public int Volume
        {
            get { return volume; }
            set
            {
                if (value < 1 || value > 3)
                {
                    return;
                }
                volume = value;
            }
        }
        public int CurrentStation { get; set; } // array index
        public int CurrentSong { get; set; } // array index
        Station[] stations;
        Radio()
        {
            Volume = 1;
            CurrentStation = 0;
            CurrentSong = 0;
            stations = new Station[5];

            stations[0] = new Station(1, "Classical");
            stations[1] = new Station(2, "Pop");
            stations[2] = new Station(3, "Jazz");
            stations[3] = new Station(4, "R&B");
            stations[4] = new Station(5, "Rock");

            stations[0].addSong(1, "Symphony no.9", "Ludwig Von Beethoven");
            stations[0].addSong(2, "The Four Seasons", "Antonio Vivaldi");
            stations[0].addSong(3, "Serenade no.13", "Wolfgang Amadeus Mozart");

            stations[1].addSong(4, "Bye Bye Bye", "NSYNC");
            stations[1].addSong(5, "Happy", "Pharrell Williams");
            stations[1].addSong(6, "Hall of Fame", "Stray Kids");
            stations[1].addSong(7, "Colorcon Wink", "AKB48");

            stations[2].addSong(8, "What A Wonderful World", "Louis Armstrong");
            stations[2].addSong(9, "So What", "Miles Davis");

            stations[3].addSong(10, "Fantasy", "Mariah Carey");
            stations[3].addSong(11, "The Hills", "The Weeknd");

            stations[4].addSong(12, "Congratulations", "Day6");
            stations[4].addSong(13, "She\'s In The Rain", "The Rose");
        }
        public static Radio getRadio()
        {
            if (r == null)
            {
                r = new Radio();
            }
            return r;
        }
        int getStationsIndex(string stationName)
        {
            for (int i = 0; i < stations.Length; i++)
            {
                if (stations[i].Name == stationName)
                {
                    return i;
                }
            }
            return 0;
        }
        int getStationsIndex(int stationId)
        {
            for (int i = 0; i < stations.Length; i++)
            {
                if (stations[i].ID == stationId)
                {
                    return i;
                }
            }
            return CurrentStation;
        }
        public void playStation(string stationName)
        {
            int index = getStationsIndex(stationName);
            CurrentStation = index;
            CurrentSong = 0;

            playCurrentStation();
        }
        public void playStation(int stationId)
        {
            int index = getStationsIndex(stationId);
            CurrentStation = index;
            CurrentSong = 0;

            playCurrentStation();
        }
        public void playCurrentStation()
        {
            Song song = stations[CurrentStation].getSongs()[CurrentSong];

            Console.WriteLine("---------------------------------");
            Console.WriteLine("This is " + stations[CurrentStation].Name + " station");
            Console.WriteLine("Now Playing " + song.Name + " by " + song.Artist);
            Console.WriteLine("---------------------------------");

        }
        public void suffleSong()
        {
            Random rand = new Random();
            CurrentSong = rand.Next(stations[CurrentStation].getSongs().Length - 1);
            playCurrentStation();
        }
        public void nextSong()
        {
            if (CurrentSong + 1 == stations[CurrentStation].getSongs().Length)
            {
                CurrentSong = 0;
                playCurrentStation();
                return;
            }
            CurrentSong += 1;
            playCurrentStation();
        }
        public void changeVolume(int level)
        {
            Volume = level;
        }
        public void stop()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Stop Playing music");
            Console.WriteLine("---------------------------------");
        }
        public void show()
        {
            int stationId = stations[CurrentStation].ID;
            string stationName = stations[CurrentStation].Name;
            Song song = stations[CurrentStation].getSongs()[CurrentSong];

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Current station: " + stationName);
            Console.WriteLine("Current song: " + song.getDetail());
            Console.WriteLine("Current volume: " + volume);
            Console.WriteLine("---------------------------------");
        }
        public Station[] getStations()
        {
            return stations;
        }
        public string getVolumeText(int level)
        {
            if (level == 1)
            {
                return "Low";
            }
            else if (level == 2)
            {
                return "Meduim";
            }
            else if (level == 3)
            {
                return "High";
            }
            return "";
        }
    }
    class Program
    {
        static void RadioMenu(ref Radio r)
        {
            bool exit = false;
            do
            {
                Console.WriteLine("1.Show detail");
                Console.WriteLine("2.Play current station");
                Console.WriteLine("3.Change station");
                Console.WriteLine("4.Next song");
                Console.WriteLine("5.Suffle song");
                Console.WriteLine("6.Change volume");
                Console.WriteLine("7.Stop and exit");

                Console.WriteLine("Select menu >>");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1: r.show(); break;
                    case 2: r.playCurrentStation(); break;
                    case 3:
                        {
                            Station[] s = r.getStations();
                            for (int i = 0; i < s.Length; i++)
                            {
                                Console.WriteLine(s[i].ID + "." + s[i].Name + " station");
                            }
                            Console.WriteLine("Select station >>");
                            int selectedStation = int.Parse(Console.ReadLine());
                            r.playStation(selectedStation);
                        } break;
                    case 4: r.nextSong(); break;
                    case 5: r.suffleSong(); break;
                    case 6:
                        {
                            Console.WriteLine("Now volume: " + r.getVolumeText(r.Volume));
                            Console.WriteLine("1." + r.getVolumeText(1));
                            Console.WriteLine("2." + r.getVolumeText(2));
                            Console.WriteLine("3." + r.getVolumeText(3));
                            Console.WriteLine("Select station >>");
                            int selectedVolume = int.Parse(Console.ReadLine());
                            r.changeVolume(selectedVolume);
                        } break;
                    case 7:
                        {
                            r.stop();
                            exit = true;
                        } break;
                }
            } while (!exit);
        }
        static void Main(string[] args)
        {
            bool exit = false;
            Radio radio1 = Radio.getRadio();
            Radio radio2 = Radio.getRadio();
            do
            {
                Console.WriteLine("1.Get Radio No.1");
                Console.WriteLine("2.Get Radio No.2");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Select menu >>");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        {
                            Console.WriteLine("--This is Radio No.1--");
                            RadioMenu(ref radio1);
                        } break;
                    case 2:
                        {
                            Console.WriteLine("--This is Radio No.2--");
                            RadioMenu(ref radio2);
                        } break;
                    case 3:
                        {
                            Console.WriteLine("Good bye radio1 ~~");
                            radio1.show();
                            Console.WriteLine("Good bye radio2 ~~");
                            radio2.show();
                            exit = true;
                        } break;

                }

            } while (!exit);
        }
    }
}