using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateCompleteVisual : MonoBehaviour
{
    [Serializable]
    public struct KitcheObjectSO_GameObject
    {

        public KitchenObjectSO kitchenObjectSO;
        public GameObject gameObject;

    }


    [SerializeField] private PlateKitchenObject plateKitchenObject;
    [SerializeField] private List<KitcheObjectSO_GameObject> kitchenObjectSOGameObjectList;

    private void Start() 
    {
        plateKitchenObject.OnIngridientAdded += PlateKitchenObject_OnIngridientAdded;

        foreach (KitcheObjectSO_GameObject kitcheObjectSO_GameObject in kitchenObjectSOGameObjectList)
        {
            kitcheObjectSO_GameObject.gameObject.SetActive(false);
        }
    }

    private void PlateKitchenObject_OnIngridientAdded(object sender, PlateKitchenObject.OnIngridientAddedEventArgs e)
    {
        foreach (KitcheObjectSO_GameObject kitcheObjectSO_GameObject in kitchenObjectSOGameObjectList)
        {
            if (kitcheObjectSO_GameObject.kitchenObjectSO == e.kitchenObjectSO)
            {
                kitcheObjectSO_GameObject.gameObject.SetActive(true);
            }
        }
    }
}
