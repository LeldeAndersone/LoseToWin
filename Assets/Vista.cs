using UnityEngine;
using UnityEngine.UI;

public class Vista : MonoBehaviour {
    private int health, maxhealth;
    private Image healthBar;
    public int Health { get { return health; } }
	// Use this for initialization
	void Start () {
       //healthBar = transform.Find("EnemyCanvas").Find("HelthBG").Find("Helth").GetComponent<Image>();
        
        health = 50;
        maxhealth = 100;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
     public void Hit(int damage)
    {
        health -= damage;
        healthBar.fillAmount = health/maxhealth;
    }
}
