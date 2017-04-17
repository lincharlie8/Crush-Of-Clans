using UnityEngine;
using System.Collections;

public class fontSize : MonoBehaviour {
	private float screenDPI;

	public GUISkin guiSkin;
		
	void setFontSize(float edit){

		guiSkin.box.fontSize = (int)(guiSkin.box.fontSize *edit);
		guiSkin.label.fontSize = (int)(guiSkin.box.fontSize *edit);
		guiSkin.button.fontSize = (int)(guiSkin.box.fontSize *edit);
		guiSkin.textField.fontSize = (int)(guiSkin.box.fontSize *edit);
		for (int i=0; i<8; i++) {
			guiSkin.customStyles[i].fontSize = (int)(guiSkin.box.fontSize *edit);
				
		}
	}
	void Awake(){
		screenDPI = Screen.dpi;

	}
	void Start()
	{


		if (screenDPI < 300) {
			setFontSize(0.9f);
		}
		if (screenDPI >= 400) {
			setFontSize(1.2f);
		}
			
	}

	void OnGUI(){


	}
}