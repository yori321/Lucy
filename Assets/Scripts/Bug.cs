using UnityEngine;
using System.Collections;


// Rigidbody2Dコンポーネントを必須にする
[RequireComponent(typeof(Rigidbody2D))]
public class Bug : MonoBehaviour
{
	// 移動スピード
	public float speed;


	// 機体の移動
	public void Move (Vector2 direction)
	{
		GetComponent<Rigidbody2D>().velocity = direction * speed;
	}
}

