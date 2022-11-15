using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public enum BattleState {
    Start,
    PlayerAction,
    PlayerMove,
    EnemyMove,
    Busy,
};
public class BattleSystem : MonoBehaviour
{
    [SerializeField] BattleUnit playerUnit;
    [SerializeField] BattleUnit enemyUnit;

    [SerializeField] battleHUD playerHud;
    [SerializeField] battleHUD enemyHud;

    [SerializeField] BattleDialogBox dialogBox;

    BattleState state;

    void Start() {
        StartCoroutine(SetupBattle());
    }

    public IEnumerator SetupBattle() {
        playerUnit.Setup();
        playerHud.SetData(playerUnit.Pokemon);

        enemyUnit.Setup();
        enemyHud.SetData(enemyUnit.Pokemon);

        dialogBox.SetMoveName(playerUnit.Pokemon.Moves);

        yield return dialogBox.TypeDialog($"A wild {enemyUnit.Pokemon.Base.Name} appeared!");
        yield return new WaitForSeconds(1f);

        PlayerAction();
    }

    void PlayerAction() {
        state = BattleState.PlayerAction;
        StartCoroutine(dialogBox.TypeDialog("What will you do?"));
        dialogBox.EnableActionSelector(true);
    }

    public void PlayerMove() {
        state = BattleState.PlayerMove;
        dialogBox.EnableActionSelector(false);
        dialogBox.EnableDialogText(false);
        dialogBox.EnableMoveSelector(true);
    }

    public void ExportButtonDetails() {
        int index = Int32.Parse(EventSystem.current.currentSelectedGameObject.name);
        //Debug.Log(playerUnit.Pokemon.Moves[index]);
        StartCoroutine(PerformPlayerMove(index));
    }

    IEnumerator PerformPlayerMove(int index) {
        state = BattleState.Busy;

        var move = playerUnit.Pokemon.Moves[index];
        dialogBox.EnableMoveSelector(false);
        yield return dialogBox.TypeDialog($"{playerUnit.Pokemon.Base.Name} used {move.Base.Name}");
        yield return new WaitForSeconds(1f);
        dialogBox.EnableMoveSelector(true);

        bool isFainted = enemyUnit.Pokemon.TakeDmg(move, playerUnit.Pokemon);

        if (isFainted) {
            yield return dialogBox.TypeDialog($"{enemyUnit.Pokemon.Base.Name} Fainted!");
        }
        else {
            StartCoroutine(EnemyMove());
        }
    }

    IEnumerator EnemyMove() {
        
    }
}
