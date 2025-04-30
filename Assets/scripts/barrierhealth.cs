using UnityEngine;
using TMPro;
public class barrierhealth : MonoBehaviour
{public TMP_Text healthText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         healthText.text=health+" ";
    }

    // Update is called once per frame
  public int health = 10;

    public void TakeDamage()
    {
        health -= 1;
        healthText.text=health+" ";

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
