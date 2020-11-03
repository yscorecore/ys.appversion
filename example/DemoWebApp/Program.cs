using YS.Knife.Hosting;

namespace DemoWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var host = new KnifeWebHost(args))
            {
                host.Run();
            }
        }
    }
}
