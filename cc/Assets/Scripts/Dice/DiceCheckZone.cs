using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZone : MonoBehaviour
{
    Vector3 diceSpeed;

    private void FixedUpdate()
    {
        diceSpeed = Dice.diceVelocity;
    }

    private void OnTriggerStay(Collider col)
    {
        if (diceSpeed.x == 0f && diceSpeed.y == 0f && diceSpeed.z == 0f)
        {
            switch (col.gameObject.name)
            {
                case "1":
                    Move.indexCasas += 1;
                    this.gameObject.SetActive(false);
                    break;
                case "2":
                    Move.indexCasas += 2;
                    this.gameObject.SetActive(false);
                    break;
                case "3":
                    Move.indexCasas += 3;
                    this.gameObject.SetActive(false);
                    break;
                case "4":
                    Move.indexCasas += 4;
                    this.gameObject.SetActive(false);
                    break;
                case "5":
                    Move.indexCasas += 5;
                    this.gameObject.SetActive(false);
                    break;
                case "6":
                    Move.indexCasas += 6;
                    this.gameObject.SetActive(false);
                    break;
            }
        }
    }
}
