using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PowerupType { 
    Movement,
    Jump,
    Wallrun
}

public class PowerupController : MonoBehaviour {

    public static PowerupController instance;

    public PowerupType type;

    public GlassDoorController door;

    public void Activate() {

        // Activate particle system

        // Give player powerup

        switch (type) {

            case PowerupType.Movement: 
                // PlayerMovement.instance.
                break;
        
        }

    }

    private void OnTriggerEnter(Collider other) {
        if (door) {
            door.Activate();
        }   
    }

    private void Awake() {
        instance = this;
    }

}
