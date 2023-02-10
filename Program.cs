
#region Dog objects
using GenericsDogsAndCircles;

Dog dog1 = new Dog("King", 70, 55);
Dog dog2 = new Dog("Spot", 30, 10);
Dog dog3 = new Dog("Rufus", 80, 40);
#endregion

List<Dog> dogs= new List<Dog>() { dog1, dog2, dog3 };
dogs.Sort();
foreach (Dog dog in dogs)
{
    Console.WriteLine(dog);
}



#region Circle objects
Circle c1 = new Circle(10, 2, 3);
Circle c2 = new Circle(15, 6, 0);
Circle c3 = new Circle(8, 12, 7);
#endregion

List<Circle> circles = new List<Circle> { c1, c2, c3 };
circles.Sort();
foreach (Circle circle in circles)
{
    Console.WriteLine(circle);
}

#region ObjectComparer test
ObjectComparer comparer = new ObjectComparer();
Console.WriteLine(comparer.LargestDog(dog1, dog2, dog3));
Console.WriteLine(comparer.LargestCircle(c1, c2, c3));
#endregion

BetterObjectComparer<Dog> betterObjectComparer = new BetterObjectComparer<Dog>();
Dog largestDog = betterObjectComparer.Largest(dog1, dog2, dog3);
Console.WriteLine($"Largest Dog with BetterComparer {largestDog}");

BetterObjectComparer<Circle> betterObjectComparerCircle = new BetterObjectComparer<Circle>();
Circle largestCircle = betterObjectComparerCircle.Largest(c1, c2, c3);
Console.WriteLine($"Largest CIrcle with BetterComparer {largestCircle}");


Car ca1 = new Car("AB 23234", "Toyota");
Car ca2 = new Car("CC 54545", "Volvo");
Car ca3 = new Car("ZX 434444", "Skoda");
List<Car> cars = new List<Car> { ca1, ca2, ca3 };
cars.Sort();
foreach(Car car in cars)
{ 
    Console.WriteLine(car); 
}

BetterObjectComparer<Car> betterObjectComparerCar = new BetterObjectComparer<Car>();
Car largestCar = betterObjectComparerCar.Largest(ca1,ca2, ca3);
Console.WriteLine($"Largest car with BetterComparer {largestCar}"); ;