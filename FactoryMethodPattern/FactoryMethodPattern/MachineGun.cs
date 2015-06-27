// **********************************************************************
// SOLUTION: FactoryMethodPattern
// PROJECT: FactoryMethodPattern 
// FILE NAME: MachineGun.cs 
// CREATED ON 2015-06-26 9:20 PM
//   
// Copyright (C) 2015 Simon8029
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license.  See the LICENSE file for details.
// **********************************************************************

using System;

namespace FactoryMethodPattern
{
    public class MachineGun:IWeapon
    {
        public string WeaponName
        {
            get { return "Machine Gun";}
        }

        public void Attack(int x, int y)
        {
            Console.WriteLine("Machine gun attack ({0},{1})",x,y);
        }
    }
}