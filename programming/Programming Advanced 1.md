# Programming Advanced 1

##  Heap / Stack

Primitiv Types or Value Types = int, bool, long, struct, Enum etc. = Auf Stack abgelegt

Complex Types or Refference Type = Everything else + string = Auf Heap abgelegt



Stack ist limitiert. 2-4 MB

Complext type wird im Heap abgelegt und Ref auf Heap in Stack geschrieben



String manipulation = new object of string in heap.

Array<int> verhält sich nicht gleich wie ein String.

## Namespace

Teil des Full qualifier name

Namenskonflikte eliminieren

Strukturierung der Applikation

## Overriding

```c#
public class Program
{
	public static void Main()
	{
		Vehicle v = new Jetski();
		v.Move();
	}
}

public class Vehicle {
	public virtual void Move() {	
		Console.WriteLine("moving");
	}
}
public class Boat : Vehicle {
	public override void Move() {
		Console.WriteLine("swimming");
	}
}
public class Jetski : Boat {
	public override void Move() {
		Console.Write("speed");
		base.Move();
	}
}
```

Wenn virtual und override nicht sind würde ```moving``` ausgegeben werden anstelle von ```speedswimming```.

## Abstract

```c#
public void Do() {
    Something();
    GC.WaitForPendingFinalizers();
}
public void Something() {
    int a = 10;
    long b = 10;
    object c = (object)b;
    int? d = 10;
    Vehicle e = new Vehicle();
}
```

Nach Something:

Stack {

​	a, b, d

​	ref auf: c, e

}

Heap {

​	c, e

}



## Boxing

Value Type Object z.B. int zu object casten damit er auf den Heap gelegt wird.

## Struct

Primitiv auf Stack (z.B. 1x int), ansonsten auf Heap.

Man weiss nicht genau wo er ist.

## Garbage Collector

Räumt nur Heap auf.

## Compile via CMD

```bash
csc <file1> <file2> <file3> /t:exe # erstellt exe
csc <file1> <file2> <file3> /t:library # erstellt dll
```

