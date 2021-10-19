using System;
using System.Collections.Generic;

namespace uhm
{
    class Program
    {
        static classPokemon StarterPokemon;
        static classPokemon WildPokemon;

        static void Main(string[] args)
        {

            Console.WriteLine("Hey Trainer! Input your name: ");
            var TrainerName = Console.ReadLine();

            List<classPokemon> starterPokemons = classStarterPokemon.GetList();
            List<classItems> healingItems = classHealingItems.GetList();

            int index = 0;
            foreach (var pokemon in starterPokemons)
            {
                index++;
                Console.WriteLine($"{index} - {pokemon.pokemonName}\n");
            }

            int chosenPokemon = 0;
            bool invalidInput = false;
            do
            {
                try
                {
                    invalidInput = false;
                    Console.WriteLine("Choose your starting Pokemon: ");
                    chosenPokemon = Convert.ToInt32(Console.ReadLine());

                    if (chosenPokemon > starterPokemons.Count || chosenPokemon < 1) //4 > 3
                    {

                        throw new Exception("INVALID INPUT");

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry sir Invalid Input");
                    invalidInput = true;
                }

            } while (invalidInput);



            StarterPokemon = starterPokemons[chosenPokemon - 1];
            Console.WriteLine($"You have chosen:\n{StarterPokemon.pokemonName}");
            Console.WriteLine("");

            WildPokemon = GetWildPokemon();
            Console.WriteLine($"A wild {WildPokemon.pokemonName} appeared!");

            bool proceed = true;
            do
            {

                try
                {
                    DisplayMenu();
                    var action = Convert.ToInt32(Console.ReadLine());

                    if (action == 1)
                    {

                        bool invalidAttack = false;

                        do
                        {
                            try
                            {
                                Console.WriteLine($"Select an attack: \n{StarterPokemon.GetSkills()}");
                                var pkmnAttack = Convert.ToInt32(Console.ReadLine());

                                invalidAttack = false;

                                if (pkmnAttack > 0 && pkmnAttack < 5)
                                {
                                    AttackWildPokemon(pkmnAttack - 1);
                                }
                                else
                                {
                                    throw new Exception("Sorry maam Invalid Input");
                                }

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Sorry : {ex.Message}");
                                invalidAttack = true;
                            }

                        } while (invalidAttack);


                    }
                    else if (action == 2)
                    {
                        //use item
                        GetHealingItem();
                        //then wild pokemon turn
                        attackTheChosePokemon();


                    }
                    else if (action == 3)
                    {
                        //run
                        Console.WriteLine($"bye bye {WildPokemon.pokemonName}");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Sorry po maling number po ang inyong na pinili!");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine($"Hello {TrainerName}! You have made an error.");
                }


                if (IsPokemonDefeated(WildPokemon))
                {
                    Console.WriteLine("You Win");
                    proceed = false;
                }
                else if (IsPokemonDefeated(StarterPokemon))
                {
                    Console.WriteLine("You Lose");
                    proceed = false;
                }

            } while (proceed);

            Console.WriteLine("");
            Console.WriteLine($"Congratulations Trainer {TrainerName} and {StarterPokemon.pokemonName}!");
            Console.WriteLine("What an amazing battle!");



            Console.ReadKey();


        }

        //methods

        static classPokemon GetWildPokemon()
        {
            List<classPokemon> wildPokemons = classWildPokemon.GetList();

            Random random = new Random();

            var indexPokemon = random.Next(wildPokemons.Count);
            return wildPokemons[indexPokemon];
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nSelect an action:\n 1. Attack\n 2. Use Item\n 3. Run");
        }

        static void AttackWildPokemon(int attackIndex)
        {
            //get random attack from wild pokemon
            Random randomAttack = new Random();
            var wildAttackIndex = randomAttack.Next(WildPokemon.pokemonSkills.Count - 1); //can be an alternative: randomAttack.Next(0,4)


            //reduce wild pkmn health
            Console.WriteLine($"{StarterPokemon.pokemonName} used {StarterPokemon.GetAttackName(attackIndex)}!");
            WildPokemon.pokemonHealth -= StarterPokemon.Attack(attackIndex);

            Console.WriteLine("");

            //reduce starter pkmn health
            Console.WriteLine($"{WildPokemon.pokemonName} used {WildPokemon.GetAttackName(wildAttackIndex)}!\n");
            StarterPokemon.pokemonHealth -= WildPokemon.Attack(wildAttackIndex);

            Console.WriteLine($"{StarterPokemon.pokemonName}'s HP is now: {StarterPokemon.pokemonHealth} \n{WildPokemon.pokemonName}'s HP is now: {WildPokemon.pokemonHealth}");
        }

        static bool IsPokemonDefeated(classPokemon pokemon)
        {
            return pokemon.pokemonHealth <= 0;
        }

        static void GetHealingItem()
        {
            List<classItems> healingItem = classHealingItems.GetList();

            var invalidInput = true;
            do
            {

                try
                {
                    Console.WriteLine("\nChoose an Item: ");

                    var index = 1;
                    foreach (var item in healingItem)
                    {
                        Console.WriteLine($"{index} - {item.ItemName} : {item.ItemValue}");
                        index++;
                    }

                    int chosenItemNumber = Convert.ToInt32(Console.ReadLine());

                    // if (chosenItemNumber > 4 || chosenItemNumber < 1)
                    // {
                    //     Console.WriteLine("SORRY! Invalid Choice");
                    //     invalidInput = false;

                    // }
                    var ChosenItem = healingItem[chosenItemNumber - 1];

                    var newHealth = ChosenItem.ItemValue + StarterPokemon.pokemonHealth;

                    StarterPokemon.pokemonHealth = newHealth;

                    Console.WriteLine($"Your chosen Item is {ChosenItem.ItemName}");
                    Console.WriteLine($"Your {StarterPokemon.pokemonName}'s health is now: {StarterPokemon.pokemonHealth}\n");
                    invalidInput = false;
                }
                catch (Exception)
                {
                    invalidInput = true;
                    Console.WriteLine("\nError! Please input only numbers 1, 2, 3, or 4.");

                }


            } while (invalidInput);


        }

        static void attackTheChosePokemon()
        {

            Random randomAttack = new Random();
            var wildAttackIndex = randomAttack.Next(WildPokemon.pokemonSkills.Count - 1);

            Console.WriteLine($"{WildPokemon.pokemonName} used {WildPokemon.GetAttackName(wildAttackIndex)}");
            StarterPokemon.pokemonHealth -= WildPokemon.Attack(wildAttackIndex);
            Console.WriteLine("");
            Console.WriteLine($"{StarterPokemon.pokemonName}'s HP is now: {StarterPokemon.pokemonHealth} \n{WildPokemon.pokemonName}'s HP is now: {WildPokemon.pokemonHealth}\n");
        }



    }
}
