using Demo;

Publisher publisher = new Publisher();
Subscriber subscriber = new Subscriber();
subscriber.Name = "Mimi";
subscriber.Age = 22;

publisher.ContentChanged += subscriber.Test;
publisher.Content = "Test";
publisher.ContentChanged += ((string content) =>
{
    Console.WriteLine($"Subscriber from lambda {content}");
});

publisher.Content = "Test2";