using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChargeBarView : MonoBehaviour
{
    [SerializeField] private Slider _energyBarView;
    [SerializeField] private GameController _gameController;
    private HolyKickBar _energyBar;
    // Start is called before the first frame update
    void Start()
    {
        _energyBar = new HolyKickBar();
    }

    // Update is called once per frame
    void Update()
    {
        _energyBar.currentEnergy = _gameController.holyKickCharge;
        _energyBarView.value = _energyBar.currentEnergy;
    }

}
