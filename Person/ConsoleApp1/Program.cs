using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program {
        static void Main(string[] args) {
            HealPotion hp1 = new HealPotion(50);
            Person p1 = new Person("Fred", 1, hp1);

            Console.WriteLine("P1 name: " + p1.name);
            Console.WriteLine("P1 health: " + p1.healthPool);
            Console.WriteLine("Potion value: " + p1.potion1.health);

            p1.usePotion();
            Console.WriteLine("P1 health: " + p1.healthPool);

            Console.ReadKey();
        }
    }

    public class HealPotion {
        public int health;

        // Constructor
        public HealPotion(int h) {
            health = h;
        }

        public int use() {
            return health;
        }
    }

    public class Person {
        public string name;
        public int healthPool;
        public HealPotion potion1;

        public Person(string n, int hp, HealPotion p) {
            name = n;
            healthPool = hp;
            potion1 = p;
        }

        public void usePotion() {
            healthPool += potion1.use();
            potion1 = null;
        }
    }
}
