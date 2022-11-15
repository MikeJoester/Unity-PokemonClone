using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleDialogBox : MonoBehaviour
{
    [SerializeField] int letterPerSecond;
    [SerializeField] Text dialogText;
    [SerializeField] GameObject actionSelector;
    [SerializeField] GameObject moveSelector;
    // [SerializeField] GameObject moveDetails;

    // [SerializeField] List<Button> actionButtons;
    [SerializeField] List<Text> moveTexts;
    [SerializeField] List<Text> movePPs;
    [SerializeField] List<Text> moveTypes;

    // [SerializeField] Text ppText;
    // [SerializeField] Text typeText;

    public void SetDialog(string dialog) {
        dialogText.text = dialog;
    }

    public IEnumerator TypeDialog(string dialog) {
        dialogText.text = "";
        foreach (var item in dialog.ToCharArray()) {
            dialogText.text += item;
            yield return new WaitForSeconds(1f/letterPerSecond);
        }
    }

    public void EnableDialogText(bool enabled) {
        dialogText.enabled = enabled;
    }

    public void EnableActionSelector(bool enabled) {
        actionSelector.SetActive(enabled);
    }
    public void EnableMoveSelector(bool enabled) {
        moveSelector.SetActive(enabled);
    }

    public void Back() {
        moveSelector.SetActive(false);
        // actionSelector.SetActive(true);
    }

    public void SetMoveName(List<Move> moves) {
        for (int i = 0; i < moveTexts.Count; i++) {
            if (i < moves.Count) {
                moveTexts[i].text = moves[i].Base.Name;
                movePPs[i].text = $"PP {moves[i].PP}/{moves[i].Base.Pp}";
                moveTypes[i].text = moves[i].Base.Type.ToString();
            }
            else {
                moveTexts[i].text = "";
                movePPs[i].text = "";
                moveTypes[i].text = "";
            }
        }
    }

    // public void SetMoveDetails(Move move) {
    //     ppText.text = $"PP {move.PP}/{move.Base.Pp}";
    //     typeText.text = move.Base.Type.ToString();
    // }
}
