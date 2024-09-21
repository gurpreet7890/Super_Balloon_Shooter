using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera mainCamera;          
    public LayerMask balloonLayer;     

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Shoot(Input.mousePosition); 
        }

        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Shoot(touch.position);
            }
        }
    }


    void Shoot(Vector3 inputPosition)
    {
        
        Ray ray = mainCamera.ScreenPointToRay(inputPosition);
        RaycastHit hit;

        
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, balloonLayer))
        {
            // Check if the raycast hit a balloon
            if (hit.collider != null)
            {
                Balloon balloon = hit.collider.GetComponent<Balloon>();
                if (balloon != null)
                {
                    balloon.Pop();  // Call the Pop() method when a balloon is hit
                }
            }
        }
    }
}
