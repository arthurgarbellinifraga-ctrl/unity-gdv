using UnityEngine;

public class RandomItem : MonoBehaviour
{

    [SerializeField] private string[] items = new string[10];

void Update()
{
    // Check if Enter (Return) is pressed
    if (Input.GetKeyDown(KeyCode.Return))
    {
        PrintRandomItem();
    }
}

void PrintRandomItem()
{
    if (items.Length == 0)
    {
        Debug.LogWarning("Items array is empty!");
        return;
    }

    int randomIndex = Random.Range(0, items.Length);
    string chosenItem = items[randomIndex];

    Debug.Log("Random Item: " + chosenItem);
}
}