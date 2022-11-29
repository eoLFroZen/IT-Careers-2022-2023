using Observer_Design_Pattern;

Subject subject = new Subject();

subject.Age = 5;

FirstObserver first = new FirstObserver();
SecondObserver second = new SecondObserver();

subject.AddObserver(first);
subject.AddObserver(second);

subject.Age = 10;
subject.RemoveObserver(second);
subject.Age = 101;