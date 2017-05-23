using UnityEngine;
using UnityEditor;
using System.Collections;
 
public class SnapToGrid : ScriptableObject {
	 
	[MenuItem ("Window/Snap to Grid %g")]
	static void MenuSnapToGrid() {
		foreach (Transform t in Selection.GetTransforms(SelectionMode.TopLevel | SelectionMode.OnlyUserModifiable)) {
			float x = Mathf.Round (t.position.x / EditorPrefs.GetFloat ("MoveSnapX")) * EditorPrefs.GetFloat ("MoveSnapX");
			float y = Mathf.Round (t.position.y / EditorPrefs.GetFloat ("MoveSnapY")) * EditorPrefs.GetFloat ("MoveSnapY");
			float z = Mathf.Round (t.position.z / EditorPrefs.GetFloat ("MoveSnapZ")) * EditorPrefs.GetFloat ("MoveSnapZ");
			//Debug.Log ("x: " + x.ToString () + "; y: " + y.ToString () + "; z: " + z.ToString ()); 
			Vector3 new_pos = new Vector3 (x,y,z);
			t.position = new_pos;
		}
	}
	 
}