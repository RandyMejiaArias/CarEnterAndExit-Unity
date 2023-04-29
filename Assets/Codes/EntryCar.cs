using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryCar : MonoBehaviour
{
    public GameObject carCamera;
    public GameObject player;
    public bool canEntry;
    public CarController carController;
    public GameObject exitCar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
            enterCar();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
            player = other.gameObject;
            canEntry = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag == "Player") {
            player = other.gameObject;
            canEntry = false;
        }
    }

    public void enterCar() {
        if(canEntry) {
            player.SetActive(false);
            carCamera.SetActive(true);
            carController.enabled = true;

            exitCar.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
