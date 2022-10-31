using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum  CollectableType {
    healthPotion,
    manaPotion,
    money
    }

public class Colecctable : MonoBehaviour {
    // Start is called before the first frame update
    public CollectableType type = CollectableType.money;

    private SpriteRenderer sprite;
    private CircleCollider2D itemCollider;

    public int collectedObject = 0;

    bool hasBeenCollected = false;

    public int value = 1;

    void Awake() {
        sprite = GetComponent<SpriteRenderer>();
        itemCollider = GetComponent<CircleCollider2D>();
    } 

    void Show() {
        sprite.enabled = true;
        itemCollider.enabled = true;
        hasBeenCollected = false;
    }

    void Hide() {
        sprite.enabled = false;
        itemCollider-enabled = false;
    }

    void Collect() {

        Hide();
        hasBeenCollected = true;

        switch (this.type)
        {
            case CollectableType.money:
            //Logica de la Moneda
            GameManager.sharedInstance.CollectObject(this);
            break;

            case CollectableType.healthPotion:
            //Logica de la posicion
            break;

            case CollectableType.manaPotion:
            //Logica de la posion mana
            break;
            default:
        }

    }

    void OnTriggerEnter2D(Collider2D collision) {

        if( collision.tag == "Player" ) {
            Destroy(gameObject);
            Collect();
        }
    }
    
    public void CollectObject(Collectable collectable) {

        collectedObject += collectable.value;
    }
}
