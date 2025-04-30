using UnityEngine;
using UnityEngine.UI ;
public class playerLives : MonoBehaviour
{ public int lives=3;
public Image []livesUI;
public GameObject explosionPrefab;
 
    public Sprite emptyHeart;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag=="Enemy"){
             Destroy(collision.collider.gameObject);
             Instantiate(explosionPrefab,transform.position,Quaternion.identity);
lives-=1;
for(int i=0;i<livesUI.Length;i++){
    if(i<lives){
        livesUI[i].enabled=true;
    }
    else{
         livesUI[i].sprite=emptyHeart;
    }
}
if(lives<=0){
    
    Destroy(gameObject); 
}

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag=="Enemy Projectile"){
             Destroy(collision.gameObject);
             Instantiate(explosionPrefab,transform.position,Quaternion.identity);
lives-=1;
for(int i=0;i<livesUI.Length;i++){
    if(i<lives){
        livesUI[i].enabled=true;
    }
    else{
         livesUI[i].sprite=emptyHeart;
    }
}
if(lives<=0){
    
    Destroy(gameObject); 
}

        } 
    }
}
