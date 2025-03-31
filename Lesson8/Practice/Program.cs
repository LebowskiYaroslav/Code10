﻿﻿﻿﻿using System;
using System.Collections.Generic;

// Идея игры:
// Игрок управляет героем, который может сражаться с монстрами и собирать сокровища.
// В игре есть несколько типов монстров и предметов. Герой может атаковать и получать урон.


// Creature - абстрактный базовый класс, представляющий общее существо с именем и здоровьем. Включает абстрактный метод Attack и виртуальный метод TakeDamage.
// Hero - класс, представляющий героя, наследует Creature. Реализует метод Attack, который атакует другое существо.
// Monster - класс, представляющий монстра, наследует Creature. Также реализует метод Attack.
// Item - базовый класс для предметов, содержит имя и описание, а также виртуальный метод Use.
// HealingPotion - класс, представляющий зелье лечения, наследует Item. Переопределяет метод Use, чтобы увеличивать здоровье героя.
// Game - класс, управляющий игрой. Содержит героя, список монстров и инвентарь предметов. Метод Play запускает игру, где герой сражается с монстрами и использует предметы.
// Program - основной класс, запускающий игру.

abstract class Creature {
    public string Name {get; set;}
    public int Health {get; set;}   
    public Creature(string name, int Health){
        Name = name;
        Health = health;
    }
    public abstract void Attack(Target Creature);
    public virtual void TakeDamage(int damage) {
        Health -= damage;
        if(Health < 0){
            Health = 0;
        }
    }
}
public class Game
{
    private Hero hero;
    private List<Monster> monsters;
    private List<Item> inventory;

    public Game()
    {
        hero = new Hero("Knight", 100, 20);
        monsters = new List<Monster>
        {
            new Monster("Goblin", 30, 5),
            new Monster("Orc", 50, 10),
            new Monster("Meganite", 80, 20),
            new Monster("Sablezub", 15, 7)
        };
        inventory = new List<Item>
        {
            new HealingPotion("Small Healing Potion", "Heals 20 health points", 20),
            new HealingPotion("Large Healing Potion", "Heals 50 health points", 50)
        };
    }

    public void Play()
    {
        Console.WriteLine("Welcome to the RPG Game!");
        Console.WriteLine($"{hero.Name} starts the journey with {hero.Health} health and {hero.AttackPower} attack power.");

        foreach (var monster in monsters)
        {
            Console.WriteLine($"\nA wild {monster.Name} appears!");

            while (monster.Health > 0 && hero.Health > 0)
            {
                hero.Attack(monster);
                if (monster.Health > 0)
                {
                    monster.Attack(hero);
                }
            }

            if (hero.Health > 0)
            {
                Console.WriteLine($"{hero.Name} defeated the {monster.Name}!");
            }
            else
            {
                Console.WriteLine($"{hero.Name} was defeated by the {monster.Name}...");
                return;
            }
        }

        Console.WriteLine($"\n{hero.Name} has defeated all the monsters!");

        foreach (var item in inventory)
        {
            item.Use(hero);
        }

        Console.WriteLine($"{hero.Name} has {hero.Health} health remaining after using items.");
    }
}
class Hero : Creature{
    public int AttackPower{get; set;}
    public Hero(string name, int health, int attackPower) : base(name, health){
        AttackPower = attackPower;
    }
    public override void Attack(Creature target){
        System.Console.WriteLine($"{name} attacks {target.Name} for {AttackPower} damage");
    }
}
class Monster : Creature{
    public int AttackPower{get; set;}
    public Monster(string name, int health, int attackPower) : base(name, health){
        AttackPower = attackPower;
    }
    public override void Attack(Creature target){
        System.Console.WriteLine($"{name} attacks {target.Name} for {AttackPower} damage");
    }
}
class Item {
        public string Name {get; set;}
        public string Description {get; set;}
        public Item(string name, string description){
            Name = name;
            Description = description;
        }
        public virtual void Use(){
            Console.WriteLine($"Using {Name}: {Description}");
        }
}

class HealingPotion : Item {
        private int healingAmount;

    private HealingPotion(string name, string description, int healingAmount) : base(name, description) {
        this.healingAmount = healingAmount;
    }
    public override void Use(Hero hero) {
        base.Use(hero);
        hero.Health += healingAmount;
        Console.WriteLine($"You healed for {healingAmount} health. Current health: {hero.Health}");
    }
}

public class Program
{
    public static void Main()
    {
        Game game = new Game();
        game.Play();
    }
}       