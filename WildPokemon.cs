using System;
using System.Collections.Generic;

namespace uhm
{
    public class classWildPokemon
    {
        public static List<classPokemon> GetList()
        {
            return new List<classPokemon>
            {
                new classPokemon
                {
                    pokemonName = "Raichu",
                    pokemonHealth = 100,
                    pokemonSkills = new List<classPokemonSkills>
                    {
                        new classPokemonSkills { attackName = "Growl", attackValue = 0 },
                        new classPokemonSkills { attackName = "Tackle", attackValue = 15 },
                        new classPokemonSkills { attackName = "Scratch", attackValue = 25 },
                        new classPokemonSkills { attackName = "Bite", attackValue = 50 }
                    }

                },
                new classPokemon
                {
                    pokemonName = "Togepi",
                    pokemonHealth = 100,
                    pokemonSkills = new List<classPokemonSkills>
                    {
                        new classPokemonSkills { attackName = "Life Drain", attackValue = 50 },
                        new classPokemonSkills { attackName = "Fly", attackValue = 50 },
                        new classPokemonSkills { attackName = "Water Gun", attackValue = 15 },
                        new classPokemonSkills { attackName = "Dig", attackValue = 0 }
                    }
                },
                new classPokemon
                {
                    pokemonName = "Butterfree",
                    pokemonHealth = 100,
                    pokemonSkills = new List<classPokemonSkills>
                    {
                        new classPokemonSkills { attackName = "Pollen", attackValue = 0 },
                        new classPokemonSkills { attackName = "Tackle", attackValue = 20 },
                        new classPokemonSkills { attackName = "Fly", attackValue = 50 },
                        new classPokemonSkills { attackName = "Gust", attackValue = 65 }
                    }
                }
            };
            
        }
    }
}