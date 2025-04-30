using UnityEngine;

public class projectile : MonoBehaviour
{ public float moveSpeed=5;
private pointManager pointmanager;
public GameObject explosionPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      pointmanager=GameObject.Find("pointManager").GetComponent<pointManager>();  
    }
 
    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector2.up*moveSpeed*Time.deltaTime); 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    { if (collision.CompareTag("barrier"))
    {Debug.Log("barrier");
        collision.GetComponent<barrierhealth>()?.TakeDamage();
        Destroy(gameObject);
    }
        if(collision.gameObject.tag=="Enemy"){
            Instantiate(explosionPrefab,transform.position,Quaternion.identity);
            Destroy(collision.gameObject);
            pointmanager.UpdateScore(50); 
            Destroy(gameObject);
        }
        if(collision.gameObject.tag=="boundary"){
            Destroy(gameObject);
        }

    }
}
