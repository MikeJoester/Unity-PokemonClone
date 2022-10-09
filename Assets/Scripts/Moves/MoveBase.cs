using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MoveBase", menuName = "PokemonClone/Create New Move", order = 0)]

public class MoveBase : ScriptableObject {
    [SerializeField] string moveName;

    [TextArea]
    [SerializeField] string description;
    [SerializeField] PokemonType type;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int pp;

    public string Name { 
        get { return moveName; }
    }

    public string Desc {
        get { return description; }
    }

    public PokemonType Type {
        get { return type; }
    }

    public int Power {
        get { return power; }
    }

    public int Accuracy {
        get { return accuracy; }
    }

    public int Pp {
        get { return pp; }
    }
    
}
