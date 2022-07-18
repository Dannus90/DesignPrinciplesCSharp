# Design principles - SOLID

## Single Responsibility Principle
- A class should only have one reason to change.
- Separation of concerns - different classes handling different, independent tasks/problems.

## Open-Closed Princples
- Classes should be open for extension but closed for modification.
- If you already have a class that has been written and tested it is a bad idea to build upon it.
- Rather use inheritance or interfaces to build upon it. 

## Liskov Substitution Principle
- You should be able to substitute a base type for a subtype. 
- You should be able to store your subtype in a basetype without altering functionality. 
- Virtual is the keywords so that you know that the inherited class can override.

## Interface Segregation Principle
- Don't put too mych into an interface; split into separate interfaces.
- YAGNI - You Ain't Going To Need It
- Smaller interfaces to avoid having to implement methods that they do not want.


## Dependency Inversion Principle
- High-level modules should not depend upon low-level ones; use abstractions.
- Instead of exposing internal variables, provide an extra interface for querying mechanics. 
- Don't expose the details -> Make a general interface with methods for accessibility. 