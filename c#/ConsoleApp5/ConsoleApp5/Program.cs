
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Animal
{
    public virtual void makenoise()
    {
        cw("I am an animal making noise");
    }
}

class Dog : Animal
{
    public override void makenoise()
    {
        cw("Bow,Bow");
    }
}

class A { cgvhbjkk;}
-concrete class (is that which has all implementations) -abstraction and not concretion

interface

user/ client


class flightbooking : IFlightBooking - concrete class

class B
{

    public B(IFlightBooking ib) { }
