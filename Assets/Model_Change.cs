using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model_Change : MonoBehaviour {

	public GameObject modelA;
    public GameObject modelB;
    public GameObject modelC;
    public GameObject modelD;
    public string key;
    private int modelNumber;

	// Use this for initialization
	void Start () {
		 modelNumber = 1;
		 modelB.transform.localScale = new Vector3(0, 0, 0);
		 modelC.transform.localScale = new Vector3(0, 0, 0);
		 modelD.transform.localScale = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(key)){
       		ModelSwitch();
		}
	}

  	void ModelSwitch(){
		if(modelNumber == 1){
			modelA.transform.localScale = new Vector3(0, 0, 0);
			modelB.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
			modelNumber = 2;            
		}else if(modelNumber == 2){
			modelB.transform.localScale = new Vector3(0, 0, 0);
			modelC.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
			modelNumber = 3;
		}else if(modelNumber == 3){
			modelC.transform.localScale = new Vector3(0, 0, 0);
			modelD.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
			modelNumber = 4;
		}else if(modelNumber == 4){
			modelD.transform.localScale = new Vector3(0, 0, 0);
			modelA.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
			modelNumber = 1;
		}
	}
}
