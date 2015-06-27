﻿// **********************************************************************
// SOLUTION: FactoryMethodPattern
// PROJECT: FactoryMethodPattern 
// FILE NAME: IWeapon.cs 
// CREATED ON 2015-06-23 3:12 PM
//   
// Copyright (C) 2015 Simon8029
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license.  See the LICENSE file for details.
// **********************************************************************
namespace FactoryMethodPattern
{
    public interface IWeapon
    {
        string WeaponName { get;  }
        void Attack(int x, int y);
    }
}