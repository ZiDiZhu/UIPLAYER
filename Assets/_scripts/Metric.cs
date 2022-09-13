using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metric : MonoBehaviour
{
    public string name;
    public int value;

    public List<Metric> linkedMetrics; 
    public List<int> linkedMetricMultiplier;

    [SerializeField]
    int lastVal; //get difference

    public void ValueSlider(){
        //value = this.gameObject.GetComponent<Slider>().value;

        


    }

}
