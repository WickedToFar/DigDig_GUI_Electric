using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SantaSpriteswap : MonoBehaviour
{

    public Sprite happySanta;
    public Sprite sadSanta;

    public int currentHealth = 50;
    public int maxHealth = 100;
    public int dmg = 10;
    public int heal = 10;

    public HealthBar healthBar;

    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        healthBar.SetMaxHealt(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            Destroy(healthBar.gameObject);
            Destroy(gameObject);
        }

        if(currentHealth < 50)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sadSanta;
        }

        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = happySanta;
        }
    }
    
    
    public void TakeDamage () 
    {
        currentHealth -= dmg;
        healthBar.setHealth(currentHealth);
    }
    

    public void HealHealth() 
    {
        if(currentHealth < maxHealth)
        {
            currentHealth += heal;
            healthBar.setHealth(currentHealth);
        }

        else
        {
            currentHealth = maxHealth;
        }
    }
}
