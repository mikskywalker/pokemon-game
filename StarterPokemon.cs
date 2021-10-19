using System;
using System.Collections.Generic;

namespace uhm
{
    public class classStarterPokemon
    {
        public static List<classPokemon> GetList()
        {
            return new List<classPokemon>
            {
                new classPokemon
                {
                    pokemonName = "Pikachu",
                    pokemonHealth = 100,
                    pokemonSkills = new List<classPokemonSkills>
                    {
                        new classPokemonSkills { attackName = "Growl", attackValue = 0 },
                        new classPokemonSkills { attackName = "Tackle", attackValue = 15 },
                        new classPokemonSkills { attackName = "Royal Thunder", attackValue = 100 },
                        new classPokemonSkills { attackName = "Electro Ball", attackValue = 50 }
                    }

                },
                new classPokemon
                {
                    pokemonName = "Meowth",
                    pokemonHealth = 100,
                    pokemonSkills = new List<classPokemonSkills>
                    {
                        new classPokemonSkills { attackName = "Scratch", attackValue = 15 },
                        new classPokemonSkills { attackName = "Tackle", attackValue = 15 },
                        new classPokemonSkills { attackName = "Coin attack", attackValue = 25 },
                        new classPokemonSkills { attackName = "Psybeam", attackValue = 89 }
                    }
                },
                new classPokemon
                {
                    pokemonName = "Goldeen",
                    pokemonHealth = 100,
                    pokemonSkills = new List<classPokemonSkills>
                    {
                        new classPokemonSkills { attackName = "Water Ball", attackValue = 31 },
                        new classPokemonSkills { attackName = "Tackle", attackValue = 15 },
                        new classPokemonSkills { attackName = "Icebolt", attackValue = 40 },
                        new classPokemonSkills { attackName = "Storm", attackValue = 120 }
                    }
                }
            };
            
        }
    }
}