# Simple C# application

This project demonstrates a simple Console application where we ask the user for information, parse (convert) it to an integer (number) then perform a calculation and advise actions based on energy levels.

It is kept simple to only show a single class (default generated Program.cs which is hidden based on top-level statements, link: [https://learn.microsoft.com/en-gb/dotnet/core/tutorials/top-level-templates](https://learn.microsoft.com/en-gb/dotnet/core/tutorials/top-level-templates))

The projects main focus is feeling the friction of having a strict type system. So we take in user input as a string (how terminals return data from their standard input) and convert it to an int.

We use the TryParse method, which returns true or false depending on whether the string can be converted to a number. It also "returns" the converted value using the `out` keyword.

This allows us to define a variable that becomes available in the enclosing scope `{ ... }`.

To explain:

```c#
string number = "1";
int converted = int.Parse(number);
```

This uses the Parse method to convert a string to an int. (We will discuss how methods are available on a datatype - normally they live on classes, but C# has some tricks here.)

This works fine, until things aren’t happy.

```c#
string number = "q";
int converted = int.Parse(number);
```

This compiles fine. But when you run it, you get a runtime exception because `"q"` can’t be converted to an int.

The issue is that this doesn’t protect us until runtime.
While this is normal from our experience with JS, it’s not really the mindset we want here. We want to handle failure explicitly.

So we look for an alternative.

This is where `TryParse` comes in. It takes a string (that could even be null) and returns whether the conversion worked.

```c#
string number = "q";
bool couldConvert = int.TryParse(number, out int converted);
```

Here we get two things:

* The return value (`true` or `false`)
* The converted number via the `out` variable

The `out` keyword is the interesting part.

Normally a method can only return one value.
With `out`, the method assigns a value to a variable we provide.

You can think of it like this:

* The method returns: “did this work?”
* The `out` variable gives us: “what is the converted value?”

You could also write it like this:

```c#
int converted;
bool couldConvert = int.TryParse(number, out converted);
```

Same thing. The inline version is just syntactic sugar.

Important detail:
A variable marked with `out` does not need to be initialized first.
The method is required to assign it before it finishes.

In the actual program we combine this with simple control flow:

* Ask for hours of sleep
* Ask for coffees consumed
* Safely parse both
* Calculate energy
* Advise action

The point of this example is not the energy formula.

It’s:

* User input is always a string
* We must convert it explicitly
* Conversions can fail
* We should handle that failure deliberately

It’s your first taste of C# being stricter than JS.

That friction is intentional.




