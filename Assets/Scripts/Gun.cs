using UnityEngine;

public class Gun : MonoBehaviour
{
    private void Update()
    {
        
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        
        mouseWorldPos.z = 0f; 
        
        
        if (mouseWorldPos == Vector3.zero)
        {
            Debug.Log("Mouse position is at (0, 0, 0).");
        }
        else
        {
            Debug.Log("Mouse position is: " + mouseWorldPos);
        }

        
        Vector3 direction = mouseWorldPos - transform.position;
        
        
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        
        
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
