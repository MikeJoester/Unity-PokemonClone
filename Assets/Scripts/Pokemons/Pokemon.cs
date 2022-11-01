using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon {
    public PokemonBase Base {get; set;}
    public int Level {get; set;}

    public int HP {get; set;}
    public List<Move> Moves {get; set;}

    public Pokemon(PokemonBase pBase, int pLevel) {
        Base = pBase; 
        Level = pLevel;
        HP = MaxHp;

        Moves = new List<Move>();
        foreach (var move in Base.LearnableMoves) {
            if (move.Level <= Level) {
                Moves.Add(new Move(move.Base));
            }

            if (Moves.Count >= 4) {
                break;
            }
        }
    }

    public int Attack {
        get { return Mathf.FloorToInt((Base.Atk * Level) / 100f) + 5; }
    }

    public int Defense {
        get { return Mathf.FloorToInt((Base.Def * Level) / 100f) + 5; }
    }

    public int SpAtk {
        get { return Mathf.FloorToInt((Base.spA * Level) / 100f) + 5; }
    }

    public int SpDef {
        get { return Mathf.FloorToInt((Base.spD * Level) / 100f) + 5; }
    }

    public int Speed {
        get { return Mathf.FloorToInt((Base.Spd * Level) / 100f) + 5; }
    }

    public int MaxHp {
        get { return Mathf.FloorToInt((Base.maxHp * Level) / 100f) + 10; }
    }
}
