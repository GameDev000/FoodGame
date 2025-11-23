using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SelectionList : MonoBehaviour
{
    public static SelectionList Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI selectedText;

    private List<string> selectedIngredients = new List<string>();

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    private void Start()
    {
        UpdateText();
    }

    public void AddIngredient(string ingredientName)
    {
        Debug.Log("Adding ingredient: " + ingredientName);
        selectedIngredients.Add(ingredientName);
        UpdateText();
    }

    public void ClearIngredients()
    {
        selectedIngredients.Clear();
        UpdateText();
    }

    private void UpdateText()
    {
        if (selectedText == null) return;

        string result = "Selected items:\n";
        foreach (string ing in selectedIngredients)
        {
            result += "- " + ing + "\n";
        }

        selectedText.text = result;
    }

    public bool IsSelectionMatching(List<string> correctOrder)
    {
        if (selectedIngredients.Count != correctOrder.Count)
            return false;

        foreach (string item in correctOrder)
        {
            Debug.Log("Check item: " + item);


            if (!selectedIngredients.Contains(item.ToLower()))
            {
                Debug.Log("Missing item: " + item);
                return false;
            }

        }

        return true;
    }
}
