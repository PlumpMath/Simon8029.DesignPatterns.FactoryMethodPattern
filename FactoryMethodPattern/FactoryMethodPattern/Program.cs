// Program.cs --FactoryMethodPattern -- FactoryMethodPattern
// CREATED ON 2015-06-23 2:43 PM
//   
// Copyright (C) 2015 Simon8029
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license.  See the LICENSE file for details.
// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unit ua = new Unit {Name = "Mark", WeaponName = "gun", BehaviorName = "soldier"};
            //ua.Move(1, 1);
            //ua.Attack(2,2);
            //Console.WriteLine("Mark changes weapon.");
            //ua.WeaponName = "Cannon";
            //ua.Attack(2,2);

            LandUnitCreator landUnitCreator = new LandUnitCreator();
            IUnit soldier1 = landUnitCreator.CreateUnit(UnitType.Soldier);
            soldier1.Name = "Mark";
            soldier1.Move(1, 1);
            soldier1.Attack(2,2);
           
        }
    }
}
