using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleDialogBox : MonoBehaviour
{
    [SerializeField] Text dialogText;
    [SerializeField] int letterPerSecond;

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
}
