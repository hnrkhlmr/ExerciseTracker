using StructureMap;

namespace ExerciseTracker.Infrastructure
{
    public static class IoC
    {
        public static IContainer Container { get; set; }

        static IoC()
        {
            Container = new Container();
        }
    }
}