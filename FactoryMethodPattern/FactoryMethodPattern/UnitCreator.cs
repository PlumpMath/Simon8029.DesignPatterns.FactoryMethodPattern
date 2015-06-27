// **********************************************************************
// SOLUTION: FactoryMethodPattern
// PROJECT: FactoryMethodPattern 
// FILE NAME: UnitCreator.cs 
// CREATED ON 2015-06-23 4:08 PM
//   
// Copyright (C) 2015 Simon8029
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license.  See the LICENSE file for details.
// **********************************************************************
namespace FactoryMethodPattern
{
    public abstract class UnitCreator
    {
        public abstract IUnit CreateUnit(UnitType unitType);
    }
}