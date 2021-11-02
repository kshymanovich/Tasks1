using System.Collections.Generic;
using NUnit.Framework;
using Test010_Inheritance.Animals;
using Test010_Inheritance.Birds;
using Test010_Inheritance.Fishes;
using Test010_Inheritance.Hunting;
using Test010_Inheritance.Owls;

namespace Test010_Inheritance
{
    public class Test
    {
        [Test]
        public void Test01()
        {
            Dog dog = new Dog();
            dog.Run();
        }

        /// <summary>
        /// Раскомментить метод и пофиксить его, чтобы тест прошел успешно.
        /// Ожидаемый результат:
        /// i'm running
        ///
        /// О наследовании: https://metanit.com/sharp/tutorial/3.7.php
        /// </summary>
        [Test]
        public void Test02()
        {
            Cat cat = new Cat();
            cat.Run();
        }

        /// <summary>
        /// все работает, исправлять не нужно, просто изучите метод и классы в директории bird
        /// </summary>
        [Test]
        public void Test03()
        {
            Parrot parrot = new Parrot();
            parrot.Fly();
        }

        /// <summary>
        /// Пофиксить, используя наследование
        /// Ожидаемый результат:
        /// Gull is flying
        /// </summary>
        [Test]
        public void Test04()
        {
            new Gull().Fly();
        }

        /// <summary>
        /// Переопределить метод в классе Penguin, чтобы в результате выполнения теста выводилось сообщение:
        /// "i'm penguin and i cannot fly"
        ///
        /// Виртуальные методы: https://metanit.com/sharp/tutorial/3.19.php
        /// Про наследование (+ сравнение с сокрытием): https://metanit.com/sharp/tutorial/3.42.php
        /// </summary>
        [Test]
        public void Test05()
        {
            new Penguin().Fly();
        }

        /// <summary>
        /// Пофиксить.
        /// Создавать новый класс не нужно. Тестовый метод должен остаться неизменным

        /// Ожидаемый результат:
        /// pterodactyl is flying
        /// 
        /// https://metanit.com/sharp/tutorial/3.8.php
        /// https://metanit.com/sharp/tutorial/3.2.php
        /// </summary>
        [Test]
        public void Test06()
        {
            new Bird("pterodactyl").Fly();
        }

        /// <summary>
        /// Ожидаемый результат:
        /// chicken is flying
        /// but not far
        ///
        /// ключевое слово base: https://metanit.com/sharp/tutorial/3.19.php
        /// </summary>
        [Test]
        public void Test07()
        {
            new Chicken().Fly();
        }

        /// <summary>
        /// Унаследовать Whale от Fish.
        /// Ожидаемые результат:
        /// whale is swimming
        ///
        /// Дополнительно: заменить метод GetName() в классе Fish на auto property
        /// public abstract string Name { get; }
        ///
        /// Абстрактные методы: https://metanit.com/sharp/tutorial/3.8.php
        /// Автоматические свойства: https://metanit.com/sharp/tutorial/3.4.php
        /// </summary>
        [Test]
        public void Test08()
        {
            new Whale().Swim();
        }

        /// <summary>
        /// Создать массив или список птиц.
        /// Добавить в список попугая, курицу, пингвина и чайку.
        /// Написать цикл, который будет вызывать метод Fly() для каждого элемента из списка/массива.
        ///
        /// Ожидаемый результат:
        /// parrot is flying
        /// chicken is flying
        /// but not far
        /// i'm penguin and i cannot fly
        /// gull if flying
        ///
        /// Циклы: https://metanit.com/sharp/tutorial/2.6.php
        /// Массивы: https://metanit.com/sharp/tutorial/2.4.php
        /// Списки: https://metanit.com/sharp/tutorial/4.5.php
        /// </summary>
        [Test]
        public void Test09()
        {
            
            Parrot parrot = new Parrot();
            Chicken chicken = new Chicken();
            Penguin penguin = new Penguin();
            Gull gull = new Gull();
            Bird[] birds1 = new Bird[] {parrot, chicken, penguin, gull};
            foreach (Bird j in birds1)
            {
                j.Fly();
            }

        }

        /// <summary>
        /// Пофиксить, не меняя в тестовом методе ничего, кроме последней строчки (ее нужно расскомментить).
        /// В классе должен оставаться один метод Run(), но таким образом, чтобы он работал для любого вида птиц
        ///
        /// Ожидаемый результат:
        /// chicken is flying
        /// but not far
        /// hunter is shooting
        /// parrot is flying
        /// hunter is shooting
        /// </summary>
        [Test]
        public void Test10()
        {
            HuntingSimulator huntingSimulator = new HuntingSimulator();
            Hunter hunter = new Hunter();
            Chicken chicken = new Chicken();
            Parrot parrot = new Parrot();
            huntingSimulator.Run(chicken, hunter);
            huntingSimulator.Run(parrot, hunter);
        }

        /// <summary>
        /// Пофиксить.
        /// Унаследовать BarnOwl и SnowyOwl от класса Owl.
        /// Изменить конструктор в классе Owl таким образом, чтобы он брал часть имени ('barn' или 'snowy') из конструкторов дочерних классов,
        /// и добавлял к слову 'owl'.
        ///
        /// Ожидаемый результат:
        /// barn owl is flying
        /// snowy owl is flying

        /// интерполяция строк: https://metanit.com/sharp/tutorial/7.5.php
        /// </summary>
        [Test]
        public void Test11()
        {
            new BarnOwl().Fly();
            new SnowyOwl().Fly();
        }
    }
}