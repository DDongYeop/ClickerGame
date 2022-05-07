using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Text goldDisPlayer;
    public Text goldPerClickDisPlayer;

    public Text goldPerSecDisplayer;

    void Update()
    {
        goldDisPlayer.text = "GOLD : " + DataController.GetInstance().GetGold();
        goldPerClickDisPlayer.text = "GOLD PER CLICK : " + DataController.GetInstance().GetGoldPerClick();
        goldPerSecDisplayer.text = "GOLD PER SEC : " + DataController.GetInstance().GetGoldPerSec();
    }

}
