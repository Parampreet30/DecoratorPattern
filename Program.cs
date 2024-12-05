namespace DecoratorPttern;
class Program
{
    static void Main(string[] args)
    {
        IComponent<string> baseComponent = new ConcreteComponent();
    
            IComponent<string> plaindecorator = new PlainDecorator(baseComponent);
            IComponent<string> uppercasedecorator = new UpperCaseDecorator(baseComponent);
            IComponent<string> colordecorator = new ColorDecorator(baseComponent);

            Console.WriteLine("Base Component: " + baseComponent.GetText());
            Console.WriteLine("Plain Decorator: " + plaindecorator.GetText());
            Console.WriteLine("UpperCase Decorator: " + uppercasedecorator.GetText());
            Console.WriteLine("Color Decorator: " + colordecorator.GetText());


    }
    
     }
