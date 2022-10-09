using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon {
    PokemonBase _base;
    int level;

    public int HP {get; set;}
    public List<Move> Moves {get; set;}

    public Pokemon(PokemonBase pBase, int pLevel) {
        _base = pBase; 
        level = pLevel;
        HP = _base.maxHp;

        Moves = new List<Move>();
        foreach (var move in _base.LearnableMoves) {
            if (move.Level <= level) {
                Moves.Add(new Move(move.Base));
            }

            if (Moves.Count >= 4) {
                break;
            }
        }
    }

    public int Attack {
        get { return Mathf.FloorToInt((_base.Atk * level) / 100f) + 5; }
    }

    public int Defense {
        get { return Mathf.FloorToInt((_base.Def * level) / 100f) + 5; }
    }

    public int SpAtk {
        get { return Mathf.FloorToInt((_base.spA * level) / 100f) + 5; }
    }

    public int SpDef {
        get { return Mathf.FloorToInt((_base.spD * level) / 100f) + 5; }
    }

    public int Speed {
        get { return Mathf.FloorToInt((_base.Spd * level) / 100f) + 5; }
    }

    public int MaxHp {
        get { return Mathf.FloorToInt((_base.maxHp * level) / 100f) + 10; }
    }
}
