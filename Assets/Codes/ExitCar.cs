using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCar : MonoBehaviour
{
    public EntryCar entryCar;
    public GameObject carCamera;
    public GameObject player;
    public CarController carController;

    // Start is called before the first frame update
    void Start()
    {
        player = entryCar.player;    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
            exitCar();
    }

    public void exitCar() {
        player.SetActive(true);
        player.transform.position = gameObject.transform.position;
        carCamera.SetActive(false);
        carController.enabled = false;
        entryCar.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
