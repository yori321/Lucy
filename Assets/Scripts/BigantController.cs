using UnityEngine;
using System.Collections;

public class BigantController : MonoBehaviour 
{
	// Spaceshipコンポーネント
	Bug bug;


void Start ()
{

	// Spaceshipコンポーネントを取得
		bug = GetComponent<Bug> ();

	// ローカル座標のY軸のマイナス方向に移動する
		bug.Move (transform.right * -1);

}
}