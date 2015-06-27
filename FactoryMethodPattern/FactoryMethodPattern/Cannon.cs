﻿// **********************************************************************
// SOLUTION: FactoryMethodPattern
// PROJECT: FactoryMethodPattern 
// FILE NAME: Cannon.cs 
// CREATED ON 2015-06-23 3:46 PM
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
    public class Cannon : IWeapon
    {
        public string WeaponName
        {
            get { return "Cannon"; }
        }

        public void Attack(int x, int y)
        {
            Console.WriteLine("{0} is attack ({1},{2}).", WeaponName, x, y);
        }
    }
}