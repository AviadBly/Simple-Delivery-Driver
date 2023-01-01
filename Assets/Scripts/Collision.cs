using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    [SerializeField] Color32 hasPackageColor= new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor= new Color32(1,1,1,1);
    [SerializeField] float destroyDelay=1f;

    SpriteRenderer spriteRenderer;
    bool hasPackage=false;

    void  Start() {
        spriteRenderer= GetComponent<SpriteRenderer>();
    }
     void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Collision just happened fr");

    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag=="Package" && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage=true;
            Destroy(other.gameObject,destroyDelay);
            spriteRenderer.color=hasPackageColor;
           
        }
        else if(other.tag=="Customer" && hasPackage)
        {
            Debug.Log("Package Delievered");
            hasPackage=false;
            spriteRenderer.color=noPackageColor;

        }

    }
}
