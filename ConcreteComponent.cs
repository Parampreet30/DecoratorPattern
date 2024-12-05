namespace DecoratorPttern;
 public class ConcreteComponent : IComponent<string>
 {
    public string GetText()
    {
        return "Decorator Pattern Assignment";
    }
 }