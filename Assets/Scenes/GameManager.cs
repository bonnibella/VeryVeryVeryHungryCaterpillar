using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SpriteRenderer sky;

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Food").Length == 0)
        {
            sky.color = new Color(0.05f, 0.05f, 0.2f); // dark blue night
        }
    }
}
