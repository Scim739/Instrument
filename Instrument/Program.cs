namespace Instrument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gitara guitar = new Gitara(6);
            Baraban drum = new Baraban(16);
            Truba trumpet = new Truba(160);
            Instrument[] instruments = { guitar, drum, trumpet };
            for (int i = 0; i < instruments.Length; i++)
            {
                instruments[i].Play();
            }
            
        }
    }
    public interface Instrument
    {
        public void Play();
        const string KEY = "До Мажор";
    }
    public class Gitara : Instrument
    {
        public Gitara(int strings)
        {
            this.strings = strings;
        }
        public int strings;

        public void Play()
        {
            Console.WriteLine("Играет гитара с " + strings + " струнами");
        }
    }
    public class Baraban : Instrument
    {
        public Baraban(int size)
        {
            this.size = size;
        }
        public int size;

        public void Play()
        {
            Console.WriteLine("Играет барабан размером: " + size + " см");
        }
    }
    public class Truba : Instrument
    {
        public Truba(int diameter)
        {
            this.diameter = diameter;
        }
        public int diameter;

        public void Play()
        {
            Console.WriteLine("Играет труба  диаметром: " + diameter + " см");
        }
    }
}