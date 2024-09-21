using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    private void Update() {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float rotateY = 0f;
        
        if(mousePos.x < transform.position.x){
            rotateY = 180f;
        }
        transform.eulerAngles = new Vector3(transform.rotation.x, rotateY, transform.rotation.z);
        
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }    

    private void Shoot(){
        GameObject bullet = Instantiate(bulletPrefab, firePoint.transform.position, firePoint.transform.rotation);
        Destroy(bullet, 5f);
    }
}
