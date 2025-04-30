using UnityEngine;

public class enemyprojectileshoot : MonoBehaviour
{public GameObject enemyProjectile;
public float spawnTimer;
public float min=3;
public float max=7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnTimer=Random.Range(min,max);
    }

    // Update is called once per frame
    void Update()
    {spawnTimer-=Time.deltaTime;
    if(spawnTimer<=0){
        Instantiate(enemyProjectile,transform.position,Quaternion.identity);
     spawnTimer=Random.Range(min,max);
     } }
}
