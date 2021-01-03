using System;

namespace M2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sodier \n");

            var warrior1 = new Soldier(new Gun());
            var warrior2 = new Soldier(new ametralladora());
            var warrior3 = new Soldier(new HandGrenade());
            warrior1.Attack("the evildoers");
            warrior2.Attack("the evildoers");
            warrior3.Attack("the evildoers");

            Console.WriteLine("Tank \n");

            var vehicle1 = new Soldier(new CanyonM68A1());
            var vehicle2 = new Soldier(new ametralladoraM240());
            var vehicle3 = new Soldier(new CanyonM256());
            vehicle1.Attack("the evildoers");
            vehicle2.Attack("the evildoers");
            vehicle3.Attack("the evildoers");

        }
    }

    interface IWeapon
    {
        void Shoot(string target);
    }

    class ametralladora : IWeapon
    {
        public void Shoot(string target)
        {
            Console.WriteLine("Chopped {0} clean in half", target);
        }
    }

    class Soldier
    {
        readonly IWeapon weapon;
        public Soldier(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void Attack(string target)
        {
            this.weapon.Shoot(target);
        }
    }

    class Gun : IWeapon
    {
        public void Shoot(string target)
        {
            Console.WriteLine("Pierced {0}'s armor", target);
        }
    }

    class HandGrenade : IWeapon
    {
        public void Shoot(string target)
        {
            Console.WriteLine("Pierced {0}'s armor", target);
        }
    }

/*
    ***************************************************************************
                                     TANK
    *************************************************************************** */


    class Tank
    {
        readonly IWeapon weapon;
        public Tank(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void Attack(string target)
        {
            this.weapon.Shoot(target);
        }
    }

    class ametralladoraM240 : IWeapon
    {
        public void Shoot(string target)
        {
            Console.WriteLine("Chopped {0} clean in half", target);
        }
    }

    class CanyonM68A1 : IWeapon
    {
        public void Shoot(string target)
        {
            Console.WriteLine("damaged {0} armor", target);
        }
    }

    class CanyonM256 : IWeapon
    {
        public void Shoot(string target)
        {
            Console.WriteLine("damaged {0} armor", target);
        }
    }









}
