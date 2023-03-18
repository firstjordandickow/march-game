using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    //attach the image called Health in Canvas to this field
    [SerializeField] private Image healthBar;

    //Enter a damage amount between 1 - 100
    [SerializeField] private float damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(healthBar.fillAmount <= 0)
        {
            print("Death");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            healthBar.fillAmount -= damage/100; 
        }
    }
}
