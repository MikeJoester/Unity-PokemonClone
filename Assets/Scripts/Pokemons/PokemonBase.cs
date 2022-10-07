using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon_Creator", menuName = "PokemonClone/Create New Pokemon", order = 0)]
public class PokemonBase : ScriptableObject   {
    [SerializeField] string name;
    
    [TextArea]

    [SerializeField] string description;
    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] PokemonType type1;
    [SerializeField] PokemonType type2;

    [SerializeField] int maxHP;
    [SerializeField] int atk;
    [SerializeField] int def;
    [SerializeField] int spAtk;
    [SerializeField] int spDef;
    [SerializeField] int speed;

    public string Name {
        get { return name; }
    }

    public string Description {
        get { return description; }
    }

    public int maxHp {
        get { return maxHP; }
    }

    public int Atk {
        get { return atk; }
    }

    public int Def {
        get { return def; }
    }
    
    public int spA {
        get { return spAtk; }
    }

    public int spD {
        get { return spDef; }
    }

    public int Spd {
        get { return speed; }
    }
}

public enum PokemonType {
    Normal, 
    Fire, 
    Water, 
    Grass, 
    Flying, 
    Fighting, 
    Poison, 
    Electric, 
    Ground, 
    Rock, 
    Psychic, 
    Ice, 
    Bug, 
    Ghost, 
    Steel, 
    Dragon, 
    Dark, 
    Fairy
}
