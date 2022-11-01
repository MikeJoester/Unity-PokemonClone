using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon_Creator", menuName = "PokemonClone/Create New Pokemon", order = 0)]
public class PokemonBase : ScriptableObject   {
    [SerializeField] string pokeName;
    
    [TextArea]

    //Appearance/Description of Pokemon
    [SerializeField] string description;
    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    //Pokemon Type(s)
    [SerializeField] PokemonType type1;
    [SerializeField] PokemonType type2;

    //Pokemon Stats
    [SerializeField] int maxHP;
    [SerializeField] int atk;
    [SerializeField] int def;
    [SerializeField] int spAtk;
    [SerializeField] int spDef;
    [SerializeField] int speed;

    //List of Learnable moves of Pokemon
    [SerializeField] List<LearnableMove> learnableMoves;

    public string Name {
        get { return pokeName; }
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

    public Sprite FrontSprite {
        get {return frontSprite; }
    }

    public Sprite BackSprite {
        get {return backSprite; }
    }

    public List<LearnableMove> LearnableMoves {
        get {return learnableMoves;}
    }
}

[System.Serializable]
public class LearnableMove {
    [SerializeField] MoveBase moveBase;
    [SerializeField] int level;

    public MoveBase Base {
        get {return moveBase;}
    }

    public int Level {
        get { return level;}
    }
}

public enum PokemonType {
    Normal, Fire, Water, Grass, 
    Flying, Fighting, Poison, 
    Electric, Ground, Rock, 
    Psychic, Ice, Bug, Ghost, 
    Steel, Dragon, Dark, Fairy
}
