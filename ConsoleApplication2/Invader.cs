﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    //abstract base invader class
    abstract class Invader : IInvader  //invader implements iinvader interface
    {
        //private MapLocation _location;

        //make public member variables properties not fields
        //Fields are ordinary member variables or member instances of a class. Properties are an abstraction to get and set their values.


        

            //force implementation of health in subclasses - cannot initialize here.
            public abstract int health { get; protected set; }
        //make a method abstract by removing curly braces and adding semicolon

            //give subclasses access to setter with protected set
        //public virtual int health { get; protected set; } = 2;  //health starts at 2.

        //protected only allows access to class and its subclasses
        //medium between private and public
        protected virtual int StepSize { get; } = 1; // no setter so it is basically readonly
        //accessor methods getter and setter with 2 methods
        /*
        public MapLocation GetLocation()
        {
        return _location;
        }

        public void SetLocation(MapLocation value)
        {
            _location = value;
        }
        */

        //sugar

        //getters and setters

        /*
    public MapLocation Location
    {

        //private set = other classes can get the _location but can't set it, but methods and properties in this class can set it.
        get
        {
            return _location;
        }
        private set
        {
             _location = value;
        }
    }
    */

        //public MapLocation Location { get; set; } //automaticaly implement a getter and setter.
        private int _pathStep = 0;
        private readonly Path _path;

        //check if invader has reached end of path
        public bool HasScored { get {return _pathStep >= _path.Length; } }

        //public MapLocation Location { get; private set; } // other classes can't set the value

            //computed properties - property that doesn't wrap an actual field
        public MapLocation Location
        {
            //location property always reflects location of invader
            get
            {
                return _path.GetLocationAt(_pathStep);
            }
        }

        //another way to do above computed property using expression bodied members:
        //public MapLocation Location => _path.GetLocationAt(_pathStep);
        //DRY don't repeat yourself

        //CONSTRUCTOR
        public Invader(Path path)
        {
            _path = path; //invader path
            // Location = path.GetLocationAt(_pathStep);  - Removed due to using computed property 

        }

        //advance invader 1 step
        public void Move()
        {
            _pathStep += StepSize;
            //Location = _path.GetLocationAt(_pathStep+=1);  - Removed due to using computed property 
        }

        //virtual makes this method polymorphic
        public virtual void decreaseHealth(int hit) => health -= hit;

        
        public bool IsNeutralized => health <= 0;   //public bool IsNeutralized { get { return health <= 0; } }

        public bool IsActive => !(IsNeutralized || HasScored); //return true if invader is not neutralized and has not scored
        //another way to write: public void Move() => _pathStep +=1;
    } 
}
