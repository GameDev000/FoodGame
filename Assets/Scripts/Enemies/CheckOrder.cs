using UnityEngine;
using System.Collections.Generic;

public class CheckOrder : MonoBehaviour
{
    [SerializeField] private SelectionList selectionList;
    [SerializeField] private List<string> correctOrder = new List<string> { "pitta", "tahini", "eggplant", "egg" };
    private void OnMouseDown()
    {
        if (selectionList == null)
        {
            Debug.LogWarning("SelectionList is not assigned to CheckOrder on " + gameObject.name);
            return;
        }

        bool isCorrect = selectionList.IsSelectionMatching(correctOrder);

        if (isCorrect)
        {
            GetComponent<CustomerMoodTimer>().CustomerServed();
            selectionList.ClearIngredients();
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Wrong!");

        }
    }
}