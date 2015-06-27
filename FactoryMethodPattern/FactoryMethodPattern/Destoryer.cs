// **********************************************************************
// SOLUTION: FactoryMethodPattern
// PROJECT: FactoryMethodPattern 
// FILE NAME: Distoryer.cs 
// CREATED ON 2015-06-23 3:42 PM
//   
// Copyright (C) 2015 Simon8029
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license.  See the LICENSE file for details.
// **********************************************************************
namespace FactoryMethodPattern
{
    public class Destoryer:Unit
    {
        public Destoryer()
        {
            Type = UnitType.Destroyer;
            Speed = 40;
            Behavior = new SeaBehavior();
        }

        public override IWeapon Weapon { get; set; }

        public override IBehavior Behavior { get; set; }
    }
}