using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject arrow_prefab;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(arrow_prefab, transform.position, transform.rotation);
        }
        transform.localEulerAngles = new Vector3(0, 0, Vector2.SignedAngle(Vector2.up, Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position));
    }
}
