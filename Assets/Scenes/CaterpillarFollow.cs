using UnityEngine;

public class CaterpillarFollow : MonoBehaviour
{
    public float speed = 5f;

  void Update()
{
    if (Input.GetMouseButton(0))
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;
        transform.position = Vector3.Lerp(transform.position, mousePos, speed * Time.deltaTime);
    }
}
}
