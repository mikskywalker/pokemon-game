using System;
using System.Collections.Generic;

namespace uhm
{
    public class classPokemon
    {
        public string pokemonName { get; set; }
        public int pokemonHealth { get; set; }
        public List<classPokemonSkills> pokemonSkills { get; set; } = new List<classPokemonSkills>();


        //method
        public string GetSkills()
        {
            string skills = "";
            int index = 0;
            foreach (var skill in pokemonSkills)
            {
                index++;
                skills += $"{index}. {skill.attackName}\n";
            }

            return skills;
        }

        public string GetAttackName(int attackIndex)
        {
            return pokemonSkills[attackIndex].attackName;
        }
        public int Attack(int attackIndex)
        {
            return pokemonSkills[attackIndex].attackValue;
        }
    }
}