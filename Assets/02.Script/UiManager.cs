using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Text goldDisPlayer;
    public Text goldPerClickDisPlayer;
    public DataController dataController;

    void Update()
    {
        goldDisPlayer.text = "GOLD : " + dataController.GetGold();
        goldPerClickDisPlayer.text = "GOLD PER CLICK : " + dataController.GetGoldPerClick();
    }

}
