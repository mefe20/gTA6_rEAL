using System;
using System.Collections.Generic;

class Food
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Food(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Display()
    {
        Console.WriteLine($"Блюдо: {Name}");
        Console.WriteLine($"Описание: {Description}");
    }
}

class KekwPizza : Food
{
    public KekwPizza(string name, string description) : base(name, description)
    {
    }

    public void Enjoy()
    {
        Console.WriteLine($"Приятного аппетита, вот ваша {Name}!");
    }
}

class RoflBurger : Food
{
    public RoflBurger(string name, string description) : base(name, description)
    {
    }

    public void Devour()
    {
        Console.WriteLine($"Съешьте {Name} и расслабьтесь~");
    }
}

class LmaoDessert : Food
{
    public LmaoDessert(string name, string description) : base(name, description)
    {
    }

    public void Indulge()
    {
        Console.WriteLine($"Разгрузитесь с {Name}!");
    }
}

class PrankDrink : Food
{
    public PrankDrink(string name, string description) : base(name, description)
    {
    }

    public void Sip()
    {
        Console.WriteLine($"Выпей(и потом пописяй) {Name} как настоящий чемпион!");
    }
}

class Program
{
    static void Main()
    {
        List<Food> menu = new List<Food>
        {
            new KekwPizza("Пицца 'Космический гастрит'", "Смесь ингредиентов со всей галактики."),
            new RoflBurger("Бургер 'Легенда о запоре'", "Секретный рецепт для запора в каждом укусе."),
            new LmaoDessert("Десерт 'Сладкий диабет'", "Интригующая комбинация вкусов и текстур."),
            new PrankDrink("Напиток 'Экзотический туалет'", "Освежающая гармония фруктов и трав.")
        };

        foreach (Food item in menu)
        {
            item.Display();

            if (item is KekwPizza pizza)
            {
                pizza.Enjoy();
            }
            else if (item is RoflBurger burger)
            {
                burger.Devour();
            }
            else if (item is LmaoDessert dessert)
            {
                dessert.Indulge();
            }
            else if (item is PrankDrink drink)
            {
                drink.Sip();
            }

            Console.WriteLine();
        }
    }
}
