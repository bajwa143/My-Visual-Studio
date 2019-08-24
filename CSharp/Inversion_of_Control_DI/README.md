## Dependency Injection in C# from c-sharpcorner

[Reference to Material](https://www.c-sharpcorner.com/UploadFile/85ed7a/dependency-injection-in-C-Sharp/)

Dependency Injection (DI) is a software design pattern. It allows us to develop loosely-coupled code.
The intent of Dependency Injection is to make code maintainable. Dependency Injection helps to reduce 
the tight coupling among software components. Dependency Injection reduces the hard-coded dependencies
among your classes by injecting those dependencies at run time instead of design time technically. 
This article explains how to implement Dependency Injection in C# and .NET code.

We have the following ways to implement Dependency Injection.
 
### Constructor Injection
 
**This is the most commonly used dependency pattern in Object Oriented Programming**. 
*The constructor injection normally has only one parameterized constructor*, so in this constructor 
dependency there is no default constructor and we need to pass the specified value at the time of 
object creation. We can use the injection component anywhere within the class. It addresses the most 
common scenario where a class requires one or more dependencies.

### Property Injection

We use constructor injection, but there are some cases where 
I need a parameter-less constructor so we need to use property injection.

### Method Injection
 
In method injection we need to pass the dependency in the method only. 
The entire class does not need the dependency, just the one method. 
I have a class with a method that has a dependency. I do not want to use constructor 
injection because then I would be creating the dependent object every time this class
 is instantiated and most of the methods do not need this dependent object.

---

## From TutorilsTeacher

[Reference to Material](https://www.tutorialsteacher.com/ioc/introduction)

![Image](principles-and-patterns.png)

### Inversion of Control
IoC is a design principle which recommends the inversion of different kinds of controls in object-oriented design to achieve loose coupling between application classes. In this case, control refers to any additional responsibilities a class has, other than its main responsibility, such as control over the flow of an application, or control over the dependent object creation and binding (Remember SRP - Single Responsibility Principle). If you want to do TDD (Test Driven Development), then you must use the IoC principle, without which TDD is not possible.

### Dependency Inversion Principle
The DIP principle also helps in achieving loose coupling between classes. It is highly recommended to use DIP and IoC together in order to achieve loose coupling.

DIP suggests that high-level modules should not depend on low level modules. Both should depend on abstraction.

The DIP principle was invented by Robert Martin (a.k.a. Uncle Bob). He is a founder of the SOLID principles.

#### Dependency Injection
Dependency Injection (DI) is a design pattern which implements the IoC principle to invert the creation of dependent objects

### IoC Container
The IoC container is a framework used to manage automatic dependency injection throughout the application, so that we as programmers do not need to put more time and effort into it. There are various IoC Containers for .NET, such as Unity, Ninject, StructureMap, Autofac, etc.

We cannot achieve loosely coupled classes by using IoC alone. Along with IoC, we also need to use DIP, DI and IoC container.

## Dependency Injection
Dependency Injection (DI) is a design pattern used to implement IoC.
It allows the creation of dependent objects outside of a class and provides those objects to a class through different ways. Using DI, we move the creation and binding of the dependent objects outside of the class that depends on them.

### Types of Dependency Injection
As you have seen above, the injector class injects the service (dependency) to the client (dependent). The injector class injects dependencies broadly in three ways: through a constructor, through a property, or through a method.

#### Constructor Injection:
In the constructor injection, the injector supplies the service (dependency) through the client class constructor.

#### Property Injection:
In the property injection (aka the Setter Injection), the injector supplies the dependency through a public property of the client class.

#### Method Injection:
In this type of injection, the client class implements an interface which declares the method(s) to supply the dependency and the injector uses this interface to supply the dependency to the client class.











































