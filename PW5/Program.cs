namespace PW5
{
    internal class Program
    {
        interface IAnimal
        {
            void Voice();
        }

        class Pedigri : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("Гав гав");
            }
        }

        class Slonyara : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("*беспощадно дует в трубу*");
            }
        }

        class Hrusha : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("Хрю-хрю");
            }
        }
        class Babuin : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("Ооооо маиии`яяя рай`о");
            }
        }

        class Owl : IAnimal
        {
            private int GetCurrentTime()
            {
                return 22;
            }

            public void Voice()
            {
                int currentTime = GetCurrentTime();

                if ((currentTime >= 8) && (currentTime <= 21))
                {
                    Console.WriteLine("Тише, я сплю!");
                }
                else
                {
                    Console.WriteLine("Ух! Ух! Ух!");
                }
            }
        }

            static void PetAnimal(IAnimal animal)
            {
                Console.WriteLine("Мы гладим зверушку, а она нам говорит: ");
                animal.Voice();
            }

            static void Main(string[] args)
            {

                Pedigri Hatiko = new Pedigri();
                PetAnimal(Hatiko);

                Slonyara Igor = new Slonyara();
                PetAnimal(Igor);

                Hrusha Nastya = new Hrusha();
                PetAnimal(Nastya);

                Babuin Vasiliy = new Babuin();
                PetAnimal(Vasiliy);

                Owl Owl = new Owl();
                PetAnimal(Owl);

                Console.ReadKey(true);
        }
    }
}