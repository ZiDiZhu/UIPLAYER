using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderController : MonoBehaviour
{
    public float min,max,lowthreshold,highthreshold;    
    public GameObject lamp_prefab; //currently selected model of lamp

    public Transform startPivot,endPivot;

    public GameObject[] lamp_models;//catalogue of all lamps


    [SerializeField]
    List<GameObject> lamp_built; //currently in the scene

    private void Start() {

        float val = this.gameObject.GetComponent<Slider>().value;
        lowthreshold = this.GetComponent<Slider>().maxValue * 0.2f;
        highthreshold = this.GetComponent<Slider>().maxValue * 0.8f;

        MakeARowOf(lamp_prefab,val);
    }

    public TMP_Text valueText;
    public void OnSliderChanged(float displayMultiplier){ //muliplies a value to scale the display of raw value

        float val = this.gameObject.GetComponent<Slider>().value;

        valueText.text = (val*displayMultiplier).ToString();

        MakeARowOf(lamp_prefab,val);
    }

    public void MakeARowOf(GameObject thing, float densityValue){

        //destroy old
        for (int i=0; i<lamp_built.Count;i++){
            Destroy(lamp_built[i].gameObject);
        }

        lamp_built.Clear();


        //instantiate new
        GameObject lamp_temp;

        float streetLength = startPivot.position.x-endPivot.position.x;
        float dir = 1; //direction
            if(streetLength>=0){
                dir=-1;
            }
        Debug.Log("Street Lnegth:"+streetLength+", density:"+ densityValue);
        float step = streetLength/densityValue;

        for (int i=0; i<densityValue;i++){
            
            lamp_temp = Instantiate(lamp_prefab, new Vector3(((i*step)*dir)+ startPivot.position.x, 0, 0),Quaternion.identity); 
            lamp_built.Add(lamp_temp);
        }
        

    }

    public void ToggleForAll(){
        for (int i=0; i<lamp_built.Count;i++){
            Destroy(lamp_built[i]);
            lamp_built.RemoveAt(i);
        }
    }

}
