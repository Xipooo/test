using System;
using test.Interfaces;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            IMammal[] critters = {
                new Zebra(), new SnoopLion(), new Bat(), new SnoopLion(), new Human(), new MountainLion()
            };

            foreach(IMammal critter in critters){
                critter.Breath();
                critter.Eat();
                critter.Sleep();
                Console.WriteLine();
                
            }
            ILion[] lions = {
                new MountainLion()
            };
            foreach(ILion lion in lions){
                lion.Roar();
                lion.Breath();
                lion.Eat();
                lion.Sleep();
            }
        }
    }
}
