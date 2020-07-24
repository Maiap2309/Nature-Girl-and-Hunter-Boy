using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHacky : MonoBehaviour
{   public GameObject newDoozy;
    public static GameObject staticDoozy;
    public GameObject oldClone;
    public static GameObject staticOldClone;
    // Start is called before the first frame update
    void Start()
    {   
        staticDoozy = newDoozy;
        staticOldClone=oldClone;
    }

    // Update is called once per frame

        public static void CreateNewDoozy() {
        Destroy(staticOldClone);
        staticOldClone=Instantiate(staticDoozy);

    

    }
}
