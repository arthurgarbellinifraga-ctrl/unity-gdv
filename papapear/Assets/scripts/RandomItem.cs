using UnityEngine;

public class RandomItem : MonoBehaviour
{

    [SerializeField] private string[] items = new string[10];
}
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   /* void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void randomItem()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {

            int randomNumber = Random.Range(0, 10);
            string randomName = items[randomNumber];
            Debug.Log(randomName);
        }


    }
   */