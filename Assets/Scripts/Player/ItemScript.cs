using UnityEngine;

public class Item : MonoBehaviour
{
      [SerializeField] private string ingredientName = "pitta";

    public void OnClick()
    {
        Debug.Log("Clicked on ingredient: " + ingredientName);

        if (SelectionList.Instance != null)
        {
            SelectionList.Instance.AddIngredient(ingredientName);
        }
        else
        {
            Debug.LogWarning("SelectionList.Instance is null!");
        }
    }
}
