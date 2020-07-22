using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    private NatureGirlDoor natureDoor;

    private HunterBoyDoor hunterDoor;
    public string name;
    // Start is called before the first frame update
    void Start()
    {
        natureDoor = FindObjectOfType<NatureGirlDoor>();
        hunterDoor = FindObjectOfType<HunterBoyDoor>();
    }

    // Update is called once per frame
    void Update()
    {
        print("testing " + natureDoor.touching);
        if(natureDoor.touching && hunterDoor.touching)
        {
            SceneManager.LoadScene(name);
        }
    }
}
